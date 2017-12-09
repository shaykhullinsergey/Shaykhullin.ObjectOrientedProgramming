using UnityEngine;
using UnityEngine.UI;

public class GameResultItem : PipeBehaviour
{
  [SerializeField] private Image gameResultImage;
  [SerializeField] private Text gameResultNickname;
  [SerializeField] private GameResult gameResult;

  public GameResult GameResult => gameResult;

  public bool Selected { set { GetComponent<Image>().enabled = value; } }

  private void Start()
  {
    Sound.PlayPipeItemAppear();
    gameResultImage.sprite = Settings.GetRandomPipeSprite();
  }

  public void InitializeWith(GameResult gameResult)
  {
    gameResultNickname.text = gameResult.PlayerName;
    this.gameResult = gameResult;
  }

  public void OnClick()
  {
    Score.Sidebar.Select(this);
  }
}
