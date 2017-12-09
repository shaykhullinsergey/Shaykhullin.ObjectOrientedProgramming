using UnityEngine;

public class PipeBehaviour : MonoBehaviour
{
  public string HydrantTag => "Hydrant";

  public GameManager Game => GameManager.Instance;
  public SoundManager Sound => SoundManager.Instance;
  public ScoreManager Score => ScoreManager.Instance;
  public SettingsManager Settings => SettingsManager.Instance;
  public MenuManager Menu => MenuManager.Instance;
}