using UnityEngine;
using UnityEngine.UI;

public class GameScoreController : PipeBehaviour
{
  [SerializeField] private Text scoreText;
  [SerializeField] private Animator animator;

  public void Show()
  {
    scoreText.text = Score.CurrentScore.ToString();
    animator.SetTrigger("ShowScore");
  }
}
