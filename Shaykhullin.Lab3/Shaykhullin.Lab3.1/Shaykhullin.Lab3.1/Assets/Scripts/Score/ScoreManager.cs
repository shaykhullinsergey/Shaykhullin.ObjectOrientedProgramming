using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

public sealed class ScoreManager : Manager<ScoreManager>
{
  public override bool DestroyOnLoad => false;
  public GameResultFieldController Result => FindObjectOfType<GameResultFieldController>();
  public GameResultSidebarController Sidebar => FindObjectOfType<GameResultSidebarController>();

  public int CurrentScore { get; set; }
  public List<GameResult> GameResults => gameResults;

  [SerializeField] private List<GameResult> gameResults;

  private void Start() => LoadScore();

  public void LoadScore()
  {
    if (File.Exists(Settings.GameResultsFilePath))
    {
      using (var stream = new FileStream(Settings.GameResultsFilePath, FileMode.Open, FileAccess.Read))
      {
        gameResults = (List<GameResult>)new XmlSerializer(typeof(List<GameResult>)).Deserialize(stream);
      }
    }
    else
    {
      gameResults = new List<GameResult>();
    }
  }

  public void SaveScore(GameResult result)
  {
    gameResults.Add(result);
    
    using (var stream = new FileStream(Settings.GameResultsFilePath, FileMode.OpenOrCreate, FileAccess.Write))
    {
      new XmlSerializer(typeof(List<GameResult>)).Serialize(stream, gameResults);
    }
  }
}
