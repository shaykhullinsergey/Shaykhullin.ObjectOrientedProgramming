using UnityEngine;

public class MiniGameController : PipeBehaviour
{
  public void StartRandom()
  {
    Sound.PlayMinigameAppear();
    gameObject.SetActive(true);
  }

  public void OnDone()
  {
    Sound.PlayDaladno();
    var reward = Random.Range(1, 4);
    for (int count = 0; count < reward; count++)
    {
      Game.Sidebar.AddReward();
    }

    Game.EndTurn();

    gameObject.SetActive(false);
  }
}
