using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class GameResultFieldController : PipeBehaviour
{
  [SerializeField] private Text selectedGameResultScoreText;
  [SerializeField] private GameObject hydrantPrefab;
  [SerializeField] private List<GameResultHydrant> hydrants;
  [SerializeField] private GameObject pipeRendererPrefab;
  [SerializeField] private List<PipeRenderer> pipeRenderers;
  [SerializeField] private Coroutine currentGameResultCoroutine;

  private IEnumerator Start()
  {
    foreach (var result in Score.GameResults.AsEnumerable().Reverse())
    {
      yield return new WaitForSeconds(0.1f);
      Score.Sidebar.AddResult(result);
    }
  }

  public void GenerateGameResult(GameResultItem gameResult)
  {
    selectedGameResultScoreText.text = gameResult.GameResult.Score.ToString();

    if (currentGameResultCoroutine != null)
      StopCoroutine(currentGameResultCoroutine);
    
    DestroyGameResult();
    currentGameResultCoroutine = StartCoroutine(GenerateGameResultCoroutine(gameResult));
  }

  private IEnumerator GenerateGameResultCoroutine(GameResultItem gameResult)
  {
    foreach (var data in gameResult.GameResult.Hydrants)
    {
      var hydrant = Instantiate<GameResultHydrant>(hydrantPrefab, transform, new Vector3(data.X, data.Y, data.Z));

      yield return new WaitForFixedUpdate();
      hydrant.InitializeWith(data);
      hydrants.Add(hydrant);

      yield return new WaitForSeconds(0.1f);
    }

    foreach (var data in gameResult.GameResult.Connections)
    {
      var hydrant1 = gameResult.GameResult.Hydrants.Single(x => x.Id == data.HydrantId1);
      var hydrant2 = gameResult.GameResult.Hydrants.Single(x => x.Id == data.HydrantId2);

      var pipeRenderer = Instantiate<PipeRenderer>(pipeRendererPrefab, transform)
        .WithStartPosition(new Vector3(hydrant1.X, hydrant1.Y, hydrant1.Z))
        .WithEndPosition(new Vector3(hydrant2.X, hydrant2.Y, hydrant2.Z))
        .WithStreamPower(data.StreamPower)
        .WithColor(Settings.PipeConnectedColor);

      pipeRenderers.Add(pipeRenderer);
      yield return new WaitForSeconds(0.1f);
    }
  }

  private void DestroyGameResult()
  {
    foreach (var hydrant in hydrants)
    {
      Destroy(hydrant.gameObject);
    }
    hydrants = new List<GameResultHydrant>();

    foreach (var pipeRenderer in pipeRenderers)
    {
      Destroy(pipeRenderer.gameObject);
    }
    pipeRenderers = new List<PipeRenderer>();
  }
}
