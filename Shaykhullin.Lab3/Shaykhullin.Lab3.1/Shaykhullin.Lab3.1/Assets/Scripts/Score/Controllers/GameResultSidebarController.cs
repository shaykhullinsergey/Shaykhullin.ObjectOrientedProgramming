using UnityEngine;
using UnityEngine.SceneManagement;

public class GameResultSidebarController : PipeBehaviour
{
  [SerializeField] private RectTransform content;
  [SerializeField] private GameObject gameResultPrefab;

  [SerializeField] private GameResultItem selectedGameResultItem;

  internal void AddResult(GameResult result)
  {
    var gameResult = Instantiate<GameResultItem>(gameResultPrefab, content);
    gameResult.InitializeWith(result);
    AddSizeDelta(content);
  }

  public void Select(GameResultItem gameResultItem)
  {
    if(selectedGameResultItem != null)
    {
      selectedGameResultItem.Selected = false;
    }
    selectedGameResultItem = gameResultItem;

    selectedGameResultItem.Selected = true;
    Score.Result.GenerateGameResult(selectedGameResultItem);
  }

  public void OnExitClicked()
  {
    Sound.PlayButtonClicked();
    SceneManager.LoadScene("Menu");
  }
}
