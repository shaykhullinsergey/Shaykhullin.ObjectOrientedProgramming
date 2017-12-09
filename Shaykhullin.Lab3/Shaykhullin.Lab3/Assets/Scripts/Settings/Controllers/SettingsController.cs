using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsController : PipeBehaviour
{
  [SerializeField] private InputField minDistanceBetweenBoilers;
  [SerializeField] private InputField maxBoilerCapacity;
  [SerializeField] private InputField maxFillBoilerSpeed;
  [SerializeField] private InputField minPipeLengthMin;
  [SerializeField] private InputField minPipeLengthMax;
  [SerializeField] private InputField maxPipeLengthMin;
  [SerializeField] private InputField maxPipeLengthMax;
  [SerializeField] private InputField minStreamPower;
  [SerializeField] private InputField maxStreamPower;
  [SerializeField] private InputField firstMiniGameTimeLimit;
  [SerializeField] private InputField secondMiniGameTimeLimit;
  [SerializeField] private InputField thirdMiniGameTimeLimit;

  public int MinDistanceBetweenBoilers => int.Parse(minDistanceBetweenBoilers.text);
  public int MaxBoilerCapacity => int.Parse(maxBoilerCapacity.text);
  public int MaxFillBoilerSpeed => int.Parse(maxFillBoilerSpeed.text);
  public int MinPipeLengthMin => int.Parse(minPipeLengthMin.text);
  public int MinPipeLengthMax => int.Parse(minPipeLengthMax.text);
  public int MaxPipeLengthMin => int.Parse(maxPipeLengthMin.text);
  public int MaxPipeLengthMax => int.Parse(maxPipeLengthMax.text);
  public int MinStreamPower => int.Parse(minStreamPower.text);
  public int MaxStreamPower => int.Parse(maxStreamPower.text);
  public int FirstMiniGameTimeLimit => int.Parse(firstMiniGameTimeLimit.text);
  public int SecondMiniGameTimeLimit => int.Parse(secondMiniGameTimeLimit.text);
  public int ThirdMiniGameTimeLimit => int.Parse(thirdMiniGameTimeLimit.text);

  private void Start()
  {
    minDistanceBetweenBoilers.text = Settings.MinDistanceBetweenBoilers.ToString();
    maxBoilerCapacity.text = Settings.MaxBoilerCapacity.ToString();
    maxFillBoilerSpeed.text = Settings.MaxFillBoilerSpeed.ToString();
    minPipeLengthMin.text = Settings.MinPipeLengthMin.ToString();
    minPipeLengthMax.text = Settings.MinPipeLengthMax.ToString();
    maxPipeLengthMin.text = Settings.MaxPipeLengthMin.ToString();
    maxPipeLengthMax.text = Settings.MaxPipeLengthMax.ToString();
    minStreamPower.text = Settings.MinStreamPower.ToString();
    maxStreamPower.text = Settings.MaxStreamPower.ToString();
    firstMiniGameTimeLimit.text = Settings.FirstMiniGameTimeLimit.ToString();
    secondMiniGameTimeLimit.text = Settings.SecondMiniGameTimeLimit.ToString();
    thirdMiniGameTimeLimit.text = Settings.ThirdMiniGameTimeLimit.ToString();
  }

  public void OnSaveButtonClicked()
  {
    Settings.ChangeSettings(this);
    OnBackButtonClicked();
  }

  public void OnBackButtonClicked()
  {
    SceneManager.LoadScene("Menu");
  }
}
