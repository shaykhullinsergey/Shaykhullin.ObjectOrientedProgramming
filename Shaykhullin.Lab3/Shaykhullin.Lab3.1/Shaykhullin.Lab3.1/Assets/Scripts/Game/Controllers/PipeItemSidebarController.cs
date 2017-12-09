using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PipeItemSidebarController : PipeBehaviour
{
  [SerializeField] private RectTransform content;
  [SerializeField] private GameObject normalPipeItemPrefab;
  [SerializeField] private GameObject bonusPipeItemPrefab;
  [SerializeField] private GameObject rewardPipeItemPrefab;

  [SerializeField] private PipeItem selectedPipeItem;
  [SerializeField] private List<PipeItem> pipeItems;

  public PipeItem SelectedPipeItem => selectedPipeItem;

  public void AddRandom()
  {
    var pipeItemPrefab = Random.Range(0, 100) < Settings.BonusPipeChance
      ? bonusPipeItemPrefab
      : normalPipeItemPrefab;

    pipeItems.Add(Instantiate<PipeItem>(pipeItemPrefab, content));
    AddSizeDelta(content);
  }

  public void AddReward()
  {
    pipeItems.Add(Instantiate<PipeItem>(rewardPipeItemPrefab, content));
    AddSizeDelta(content);
  }

  public void Select(PipeItem pipeItem)
  {
    Sound.PlayPipeItemSelected();
    if (selectedPipeItem == pipeItem)
    {
      selectedPipeItem.Selected = false;
      selectedPipeItem = null;
      return;
    }

    if(selectedPipeItem != null)
    {
      selectedPipeItem.Selected = false;
    }

    selectedPipeItem = pipeItem;
    selectedPipeItem.Selected = true;
    Game.GameField.ResetSelected();
  }

  public void UseSelected()
  {
    if (selectedPipeItem == null)
    {
      Notification.Show("Select pipe item!");
      return;
    }

    selectedPipeItem.Use();

    pipeItems.Remove(selectedPipeItem);
    Destroy(selectedPipeItem.gameObject);
    selectedPipeItem = null;

    RemoveSizeDelta(content);
  }

  public void OnExitClicked()
  {
    Sound.PlayButtonClicked();
    SceneManager.LoadScene("Menu");
  }
}
