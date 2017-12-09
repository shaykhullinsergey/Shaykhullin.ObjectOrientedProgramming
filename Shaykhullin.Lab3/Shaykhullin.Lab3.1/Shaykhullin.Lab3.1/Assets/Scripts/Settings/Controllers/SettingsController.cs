using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsController : PipeBehaviour
{
  [Header("Game Settings", order = 0)]
  [SerializeField] private InputField soundVolume;
  [Header("Hydrant settings", order = 1)]
  [SerializeField] private InputField minDistanceBetweenHydrants;
  [SerializeField] private InputField minStartHydrantCount;
  [SerializeField] private InputField maxStartHydrantCount;
  [SerializeField] private InputField minHydrantCapacity;
  [SerializeField] private InputField maxHydrantCapacity;
  [SerializeField] private InputField minTurnsToNextHydrant;
  [SerializeField] private InputField maxTurnsToNextHydrant;
  [SerializeField] private InputField minFillHydrantSpeed;
  [SerializeField] private InputField maxFillHydrantSpeed;
  [Header("Pipe settings")]
  [SerializeField] private InputField bonusPipeChance;
  [SerializeField] private InputField minStartAvaliablePipesCount;
  [SerializeField] private InputField maxStartAvaliablePipesCount;
  [SerializeField] private InputField minPipeLengthMin;
  [SerializeField] private InputField minPipeLengthMax;
  [SerializeField] private InputField maxPipeLengthMin;
  [SerializeField] private InputField maxPipeLengthMax;
  [SerializeField] private InputField minStreamPower;
  [SerializeField] private InputField maxStreamPower;
  [Header("Minigame settings")]
  [SerializeField] private InputField firstMiniGameTimeLimit;
  [SerializeField] private InputField secondMiniGameTimeLimit;
  [SerializeField] private InputField thirdMiniGameTimeLimit;

  private void Start()
  {
    soundVolume.text = Settings.SoundVolume.ToString();
    minDistanceBetweenHydrants.text = Settings.MinDistanceBetweenHydrants.ToString();
    minStartHydrantCount.text = Settings.MinStartHydrantCount.ToString();
    maxStartHydrantCount.text = Settings.MaxStartHydrantCount.ToString();
    minHydrantCapacity.text = Settings.MinHydrantCapacity.ToString();
    maxHydrantCapacity.text = Settings.MaxHydrantCapacity.ToString();
    minTurnsToNextHydrant.text = Settings.MinTurnsToNextHydrant.ToString();
    maxTurnsToNextHydrant.text = Settings.MaxTurnsToNextHydrant.ToString();
    minFillHydrantSpeed.text = Settings.MinFillHydrantSpeed.ToString();
    maxFillHydrantSpeed.text = Settings.MaxFillHydrantSpeed.ToString();

    bonusPipeChance.text = Settings.BonusPipeChance.ToString();
    minStartAvaliablePipesCount.text = Settings.MinStartAvaliablePipesCount.ToString();
    maxStartAvaliablePipesCount.text = Settings.MaxStartAvaliablePipesCount.ToString();
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

  public void OnSaveClicked()
  {
    Sound.PlayButtonClicked();

    var settingsDto = Settings.CreateSettingsDto();
    settingsDto.SoundVolume = int.Parse(soundVolume.text);
    settingsDto.MinDistanceBetweenHydrants = int.Parse(minDistanceBetweenHydrants.text);
    settingsDto.MinStartHydrantCount = int.Parse(minStartHydrantCount.text);
    settingsDto.MaxStartHydrantCount = int.Parse(maxStartHydrantCount.text);
    settingsDto.MinHydrantCapacity = int.Parse(minHydrantCapacity.text);
    settingsDto.MaxHydrantCapacity = int.Parse(maxHydrantCapacity.text);
    settingsDto.MinFillHydrantSpeed = int.Parse(minFillHydrantSpeed.text);
    settingsDto.MaxFillHydrantSpeed = int.Parse(maxFillHydrantSpeed.text);
    settingsDto.MinTurnsToNextHydrant = int.Parse(minTurnsToNextHydrant.text);
    settingsDto.MaxTurnsToNextHydrant = int.Parse(maxTurnsToNextHydrant.text);
    settingsDto.BonusPipeChance = int.Parse(bonusPipeChance.text);
    settingsDto.MinStartAvaliablePipesCount = int.Parse(minStartAvaliablePipesCount.text);
    settingsDto.MaxStartAvaliablePipesCount = int.Parse(maxStartAvaliablePipesCount.text);
    settingsDto.MinPipeLengthMin = int.Parse(minPipeLengthMin.text);
    settingsDto.MinPipeLengthMax = int.Parse(minPipeLengthMax.text);
    settingsDto.MaxPipeLengthMin = int.Parse(maxPipeLengthMin.text);
    settingsDto.MaxPipeLengthMax = int.Parse(maxPipeLengthMax.text);
    settingsDto.MinStreamPower = int.Parse(minStreamPower.text);
    settingsDto.MaxStreamPower = int.Parse(maxStreamPower.text);
    settingsDto.FirstMiniGameTimeLimit = int.Parse(firstMiniGameTimeLimit.text);
    settingsDto.SecondMiniGameTimeLimit = int.Parse(secondMiniGameTimeLimit.text);
    settingsDto.ThirdMiniGameTimeLimit = int.Parse(thirdMiniGameTimeLimit.text);

    if (Validate(settingsDto))
    {
      Settings.ApplySettings(settingsDto);
      SceneManager.LoadScene("Menu");
    }
  }

  public bool Validate(SettingsDto dto)
  {
    if(dto.SoundVolume < 0 || dto.SoundVolume > 100)
    {
      Notification.Show($"{nameof(dto.SoundVolume)}: Value must be in [0..100] range!");
      return false;
    }

    if (dto.MinDistanceBetweenHydrants <= 0)
    {
      Notification.Show($"{nameof(dto.MinDistanceBetweenHydrants)}: Value must be > 0!");
      return false;
    }

    if (dto.MinStartHydrantCount < 2)
    {
      Notification.Show($"{nameof(dto.MinStartHydrantCount)}: Value must be >= 2!");
      return false;
    }

    if (dto.MinStartHydrantCount > dto.MaxStartHydrantCount)
    {
      Notification.Show($"{nameof(dto.MinStartHydrantCount)}: Value must be <= {nameof(dto.MaxStartHydrantCount)}!");
      return false;
    }

    if (dto.MinHydrantCapacity <= 0)
    {
      Notification.Show($"{nameof(dto.MinHydrantCapacity)}: Value must be > 0!");
      return false;
    }

    if (dto.MinHydrantCapacity > dto.MaxHydrantCapacity)
    {
      Notification.Show($"{nameof(dto.MinHydrantCapacity)}: Value must be <= {nameof(dto.MaxHydrantCapacity)}!");
      return false;
    }

    if (dto.MinFillHydrantSpeed <= 0)
    {
      Notification.Show($"{nameof(dto.MinFillHydrantSpeed)}: Value must be > 0!");
      return false;
    }

    if (dto.MinFillHydrantSpeed > dto.MaxFillHydrantSpeed)
    {
      Notification.Show($"{nameof(dto.MinFillHydrantSpeed)}: Value must be <= {nameof(dto.MaxFillHydrantSpeed)}!");
      return false;
    }

    if (dto.MinTurnsToNextHydrant < 0)
    {
      Notification.Show($"{nameof(dto.MinTurnsToNextHydrant)}: Value must be >= 0!");
      return false;
    }

    if (dto.MinTurnsToNextHydrant > dto.MaxTurnsToNextHydrant)
    {
      Notification.Show($"{nameof(dto.MinTurnsToNextHydrant)}: Value must be <= {nameof(dto.MaxTurnsToNextHydrant)}!");
      return false;
    }

    if(dto.BonusPipeChance < 0 || dto.BonusPipeChance > 100)
    {
      Notification.Show($"{nameof(dto.BonusPipeChance)}: Value must be in [0..100] range!");
      return false;
    }

    if (dto.MinStartAvaliablePipesCount <= 0)
    {
      Notification.Show($"{nameof(dto.MinStartAvaliablePipesCount)}: Value must be > 0!");
      return false;
    }

    if (dto.MinStartAvaliablePipesCount > dto.MaxStartAvaliablePipesCount)
    {
      Notification.Show($"{nameof(dto.MinStartAvaliablePipesCount)}: Value must be <= {nameof(dto.MaxStartAvaliablePipesCount)}!");
      return false;
    }

    if(dto.MinPipeLengthMin <= 0)
    {
      Notification.Show($"{nameof(dto.MinPipeLengthMin)}: Value must be > 0!");
      return false;
    }

    if (dto.MinPipeLengthMin > dto.MinPipeLengthMax)
    {
      Notification.Show($"{nameof(dto.MinPipeLengthMin)}: Value must be <= {nameof(dto.MinPipeLengthMax)}!");
      return false;
    }

    if(dto.MinPipeLengthMax > dto.MaxPipeLengthMin)
    {
      Notification.Show($"{nameof(dto.MinPipeLengthMax)}: Value must be <= {nameof(dto.MaxPipeLengthMin)}!");
      return false;
    }

    if (dto.MaxPipeLengthMin > dto.MaxPipeLengthMax)
    {
      Notification.Show($"{nameof(dto.MaxPipeLengthMin)}: Value must be <= {nameof(dto.MaxPipeLengthMax)}!");
      return false;
    }

    if(dto.MinStreamPower <= 0)
    {
      Notification.Show($"{nameof(dto.MinStreamPower)}: Value must be > 0!");
      return false;
    }

    if (dto.MinStreamPower > dto.MaxStreamPower)
    {
      Notification.Show($"{nameof(dto.MinStreamPower)}: Value must be <= {nameof(dto.MaxStreamPower)}!");
      return false;
    }

    if(dto.FirstMiniGameTimeLimit < 10 || dto.FirstMiniGameTimeLimit > 100)
    {
      Notification.Show($"{nameof(dto.FirstMiniGameTimeLimit)}: Value must be in [10..100] range!");
      return false;
    }

    if (dto.SecondMiniGameTimeLimit < 10 || dto.SecondMiniGameTimeLimit > 100)
    {
      Notification.Show($"{nameof(dto.SecondMiniGameTimeLimit)}: Value must be in [10..100] range!");
      return false;
    }

    if (dto.ThirdMiniGameTimeLimit < 10 || dto.ThirdMiniGameTimeLimit > 100)
    {
      Notification.Show($"{nameof(dto.ThirdMiniGameTimeLimit)}: Value must be in [10..100] range!");
      return false;
    }

    return true;
  }
}
