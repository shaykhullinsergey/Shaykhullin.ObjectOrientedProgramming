using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public sealed class GameManager : Manager<GameManager>
{
  public override bool DestroyOnLoad => true;

  [SerializeField] private bool lockEndTurn;
  [SerializeField] private int turnToNextHydrant;
  [SerializeField] private PipeItemSidebarController pipeItemSidebarController;
  [SerializeField] private GameFieldController gameField;
  [SerializeField] private MiniGameController miniGame;
  [SerializeField] private GameOverController gameOver;
  [SerializeField] private List<Connection> connections;

  public PipeItemSidebarController Sidebar => pipeItemSidebarController;
  public GameFieldController GameField => gameField;
  public MiniGameController MiniGame => miniGame;
  public List<Connection> Connections => connections;
  public GameOverController GameOver => gameOver;

  public bool LockEndTurn => lockEndTurn;

  private IEnumerator Start()
  {
    Sound.PlayGameAmbient();
    Score.CurrentScore = 0;
    turnToNextHydrant = Settings.GetTurnsForNextHydrant();

    var hydrants = Random.Range(Settings.MinStartHydrantCount, Settings.MaxStartHydrantCount);
    for (int i = 0; i < hydrants; i++)
    {
      GameField.AddRandom();
      yield return new WaitForSeconds(0.2f);
    }

    var pipeItems = Random.Range(Settings.MinStartAvaliablePipesCount, Settings.MaxStartAvaliablePipesCount);
    for (int i = 0; i < pipeItems; i++)
    {
      Sidebar.AddRandom();
      yield return new WaitForSeconds(0.2f);
    }
  }

  public void EndTurn()
  {
    lockEndTurn = true;
    StartCoroutine(EndTurnCoroutine());
  }

  private IEnumerator EndTurnCoroutine()
  {
    foreach (var connection in connections)
    {
      Score.CurrentScore += connection.PipeRenderer.StreamPower;
      yield return new WaitForSeconds(0.2f);
      connection.From.ApplyConnection(connection);
      connection.ApplyEndTurn();
      yield return new WaitForSeconds(0.2f);
      connection.To.ApplyConnection(connection);
      yield return new WaitForSeconds(0.2f);
    }

    if (connections.Any(c => c.To.Capacity <= 0 || c.From.Capacity <= 0))
    {
      Game.GameOver.Show();
      yield break;
    }

    yield return new WaitForSeconds(0.2f);

    if (--turnToNextHydrant == 0)
    {
      Game.GameField.AddRandom();
      turnToNextHydrant = Game.Settings.GetTurnsForNextHydrant();
    }

    GameField.CurrentScore.Show();
    lockEndTurn = false;
  }
}
