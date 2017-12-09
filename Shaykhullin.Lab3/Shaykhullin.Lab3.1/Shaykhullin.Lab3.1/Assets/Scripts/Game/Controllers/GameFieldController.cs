using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class GameFieldController : PipeBehaviour
{
  public List<Hydrant> Hydrants => hydrants;
  private PipeRenderer LastRenderer => pipeRenderers.Last();
  public GameScoreController CurrentScore => currentScoreController;

  [SerializeField] private GameObject hydrantPrefab;
  [SerializeField] private GameObject pipeRendererPrefab;
  [SerializeField] private GameScoreController currentScoreController;

  [SerializeField] private Hydrant selectedHydrant;
  [SerializeField] private List<Hydrant> hydrants;
  [SerializeField] private List<PipeRenderer> pipeRenderers;


  public void AddRandom()
  {
    var position = Settings.GetRandomHydrantPosition();

    var repeats = 0;
    while (repeats < 100 && hydrants.Any(h => Vector3.Distance(h.transform.position, position) < Settings.MinDistanceBetweenHydrants))
    {
      position = Settings.GetRandomHydrantPosition();
      repeats++;
    }
    if (repeats == 100)
    {
      Notification.Show("Can't add more hydrants because settings min distance!");
      return;
    }

    hydrants.Add(Instantiate<Hydrant>(hydrantPrefab, transform, position));
  }

  public void Select(Hydrant hydrant)
  {
    if (Game.Sidebar.SelectedPipeItem == null)
    {
      Notification.Show("Select Pipe Item!");
      return;
    }

    if (selectedHydrant == null)
    {
      pipeRenderers.Add(Instantiate<PipeRenderer>(pipeRendererPrefab, transform));
      selectedHydrant = hydrant;
      LastRenderer.WithStartPosition(selectedHydrant.transform.position);
      return;
    }

    if (selectedHydrant == hydrant)
    {
      Notification.Show("Target can't be selected!");
      ResetSelected();
      return;
    }

    var selected = Game.Sidebar.SelectedPipeItem;

    if (Vector3.Distance(selectedHydrant.transform.position, hydrant.transform.position) > selected.MaxLength
      || Vector3.Distance(selectedHydrant.transform.position, hydrant.transform.position) < selected.MinLength)
    {
      ResetSelected();
      return;
    }

    if (Game.LockEndTurn)
    {
      Notification.Show("Wait for end turn!");
      ResetSelected();
      return;
    }

    if (Game.Connections.Any(x => x.From == selectedHydrant && x.To == hydrant || x.From == hydrant && x.To == selectedHydrant))
    {
      Notification.Show("Connection already exists!");
      ResetSelected();
      return;
    }

    AddSelectedConnection(hydrant);
  }

  private void FixedUpdate()
  {
    if (selectedHydrant == null)
    {
      return;
    }

    var cameraPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    var mousePosition = new Vector3(cameraPosition.x, cameraPosition.y, 0);

    var distance = Vector3.Distance(selectedHydrant.transform.position, mousePosition);
    var color = distance < Game.Sidebar.SelectedPipeItem.MinLength
      ? Settings.PipeLengthOutOfRangeColor
      : distance < Game.Sidebar.SelectedPipeItem.MaxLength
        ? Settings.PipeLengthInRangeColor
        : Settings.PipeLengthOutOfRangeColor;

    LastRenderer
      .WithEndPosition(mousePosition)
      .WithColor(color);
  }

  private void AddSelectedConnection(Hydrant targetHydrant)
  {
    var selected = Game.Sidebar.SelectedPipeItem;

    LastRenderer
      .WithEndPosition(targetHydrant.transform.position)
      .WithColor(Settings.PipeConnectedColor)
      .WithStreamPower(selected.StreamPower);

    Game.Connections.Add(new Connection(selectedHydrant, LastRenderer, targetHydrant));
    Game.Sidebar.UseSelected();

    selectedHydrant = null;
  }

  public void ResetSelected()
  {
    if (selectedHydrant != null)
    {
      Sound.PlayResetSelected();
      selectedHydrant = null;
      var last = LastRenderer;
      pipeRenderers.Remove(last);
      Destroy(last.gameObject);
    }
  }
}
