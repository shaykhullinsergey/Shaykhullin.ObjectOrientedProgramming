using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : PipeBehaviour
{
  [SerializeField] private InputField nicknameInputField;

  public void Show()
  {
    Sound.PlayerGameOverAppear();
    gameObject.SetActive(true);
  }

  public void OnOk()
  {
    var result = new GameResult
    {
      PlayerName = string.IsNullOrWhiteSpace(nicknameInputField.text) ? "Unknown" : nicknameInputField.text,
      Score = Score.CurrentScore,
      Hydrants = Game.GameField.Hydrants.Select(h => new HydrantResult
      {
        Id = h.Id,
        X = h.transform.position.x,
        Y = h.transform.position.y,
        Z = h.transform.position.z,
        Capacity = h.Capacity
      }).ToList(),
      Connections = Game.Connections.Select(c => new ConnectionResult
      {
        HydrantId1 = c.From.Id,
        HydrantId2 = c.To.Id,
        StreamPower = c.PipeRenderer.StreamPower
      }).ToList()
    };

    Sound.PlayButtonClicked();
    Score.SaveScore(result);
    SceneManager.LoadScene("Menu");
  }
}
