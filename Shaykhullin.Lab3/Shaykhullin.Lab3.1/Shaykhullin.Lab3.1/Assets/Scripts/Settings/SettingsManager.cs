using UnityEngine;
using System.Collections.Generic;
using System;
using Random = UnityEngine.Random;
using System.IO;
using System.Xml.Serialization;

public sealed class SettingsManager : Manager<SettingsManager>
{
  public override bool DestroyOnLoad => false;

  [Header("Game Settings")]
  [SerializeField]
  private int soundVolume;
  [Header("Hydrant settings")]
  [SerializeField]
  private int minDistanceBetweenHydrants;
  [SerializeField] private int minStartHydrantCount;
  [SerializeField] private int maxStartHydrantCount;
  [SerializeField] private int minHydrantCapacity;
  [SerializeField] private int maxHydrantCapacity;
  [SerializeField] private int minTurnsToNextHydrant;
  [SerializeField] private int maxTurnsToNextHydrant;
  [SerializeField] private int minFillHydrantSpeed;
  [SerializeField] private int maxFillHydrantSpeed;
  [Header("Pipe settings")]
  [SerializeField]
  private int bonusPipeChance;
  [SerializeField] private int minStartAvaliablePipesCount;
  [SerializeField] private int maxStartAvaliablePipesCount;
  [SerializeField] private int minPipeLengthMin;
  [SerializeField] private int minPipeLengthMax;
  [SerializeField] private int maxPipeLengthMin;
  [SerializeField] private int maxPipeLengthMax;
  [SerializeField] private int minStreamPower;
  [SerializeField] private int maxStreamPower;
  [Header("Minigame settings")]
  [SerializeField]
  private int firstMiniGameTimeLimit;
  [SerializeField] private int secondMiniGameTimeLimit;
  [SerializeField] private int thirdMiniGameTimeLimit;
  [Header("Developer Settings")]
  [SerializeField]
  private int pipeItemSizeDelta = 78;
  [SerializeField] private string settingsFileName;
  [SerializeField] private string gameResultsFileName;
  [SerializeField] private List<Sprite> pipeSprites;
  [SerializeField] private List<Sprite> hydrantSprites;
  [SerializeField] private Color positiveHydrantColor;
  [SerializeField] private Color negativeHydrantColor;
  [SerializeField] private Color pipeLengthOutOfRangeColor;
  [SerializeField] private Color pipeLengthInRangeColor;
  [SerializeField] private Color pipeConnectedColor;
  [SerializeField] private Color pipeActivatedColor;

  public int SoundVolume => soundVolume;
  // Hydrant
  public int MinDistanceBetweenHydrants => minDistanceBetweenHydrants;
  public int MinStartHydrantCount => minStartHydrantCount;
  public int MaxStartHydrantCount => maxStartHydrantCount;
  public int MinHydrantCapacity => minHydrantCapacity;
  public int MaxHydrantCapacity => maxHydrantCapacity;
  public int MinFillHydrantSpeed => minFillHydrantSpeed;
  public int MaxFillHydrantSpeed => maxFillHydrantSpeed;
  public int MinTurnsToNextHydrant => minTurnsToNextHydrant;
  public int MaxTurnsToNextHydrant => maxTurnsToNextHydrant;
  // Pipe
  public int BonusPipeChance => bonusPipeChance;
  public int MinStartAvaliablePipesCount => minStartAvaliablePipesCount;
  public int MaxStartAvaliablePipesCount => maxStartAvaliablePipesCount;
  public int MinPipeLengthMin => minPipeLengthMin;
  public int MinPipeLengthMax => minPipeLengthMax;
  public int MaxPipeLengthMin => maxPipeLengthMin;
  public int MaxPipeLengthMax => maxPipeLengthMax;
  public int MinStreamPower => minStreamPower;
  public int MaxStreamPower => maxStreamPower;
  // Minigame
  public int FirstMiniGameTimeLimit => firstMiniGameTimeLimit;
  public int SecondMiniGameTimeLimit => secondMiniGameTimeLimit;
  public int ThirdMiniGameTimeLimit => thirdMiniGameTimeLimit;
  // Developer
  public int PipeItemSizeDelta => pipeItemSizeDelta;
  public string GameResultsFilePath => Path.Combine(Environment.CurrentDirectory, gameResultsFileName);
  public string SettingsFilePath => Path.Combine(Environment.CurrentDirectory, settingsFileName);
  public Color PositiveHydrantColor => positiveHydrantColor;
  public Color NegativeHydrantColor => negativeHydrantColor;
  public Color PipeLengthOutOfRangeColor => pipeLengthOutOfRangeColor;
  public Color PipeLengthInRangeColor => pipeLengthInRangeColor;
  public Color PipeConnectedColor => pipeConnectedColor;
  public Color PipeActivatedColor => pipeActivatedColor;
  public Sprite GetRandomPipeSprite() => pipeSprites[Random.Range(0, pipeSprites.Count)];
  public Sprite GetRandomHydrantSprite() => hydrantSprites[Random.Range(0, hydrantSprites.Count)];
  public Vector3 GetRandomHydrantPosition() => new Vector3(Random.Range(-8.4f, 6.77f), Random.Range(-4.15f, 4.15f), 0);
  public int GetRandomHydrantCapacity() => Random.Range(minHydrantCapacity, maxHydrantCapacity);
  public int GetTurnsForNextHydrant() => Random.Range(minTurnsToNextHydrant, maxTurnsToNextHydrant);

  private void Start() => LoadSettings();

  public void ApplySettings(SettingsDto settingsDto)
  {
    // Game
    soundVolume = settingsDto.SoundVolume;
    minDistanceBetweenHydrants = settingsDto.MinDistanceBetweenHydrants;
    minStartHydrantCount = settingsDto.MinStartHydrantCount;
    maxStartHydrantCount = settingsDto.MaxStartHydrantCount;
    minHydrantCapacity = settingsDto.MinHydrantCapacity;
    maxHydrantCapacity = settingsDto.MaxHydrantCapacity;
    minTurnsToNextHydrant = settingsDto.MinTurnsToNextHydrant;
    maxTurnsToNextHydrant = settingsDto.MaxTurnsToNextHydrant;
    minFillHydrantSpeed = settingsDto.MinFillHydrantSpeed;
    maxFillHydrantSpeed = settingsDto.MaxFillHydrantSpeed;
    bonusPipeChance = settingsDto.BonusPipeChance;
    minStartAvaliablePipesCount = settingsDto.MinStartAvaliablePipesCount;
    maxStartAvaliablePipesCount = settingsDto.MaxStartAvaliablePipesCount;
    minPipeLengthMin = settingsDto.MinPipeLengthMin;
    minPipeLengthMax = settingsDto.MinPipeLengthMax;
    maxPipeLengthMin = settingsDto.MaxPipeLengthMin;
    maxPipeLengthMax = settingsDto.MaxPipeLengthMax;
    minStreamPower = settingsDto.MinStreamPower;
    maxStreamPower = settingsDto.MaxStreamPower;
    firstMiniGameTimeLimit = settingsDto.FirstMiniGameTimeLimit;
    secondMiniGameTimeLimit = settingsDto.SecondMiniGameTimeLimit;
    thirdMiniGameTimeLimit = settingsDto.ThirdMiniGameTimeLimit;

    // Developer
    pipeItemSizeDelta = settingsDto.PipeItemSizeDelta;
    settingsFileName = settingsDto.SettingsFileName;
    gameResultsFileName = settingsDto.GameResultsFileName;
    positiveHydrantColor = settingsDto.PositiveHydrantColor;
    negativeHydrantColor = settingsDto.NegativeHydrantColor;
    pipeLengthOutOfRangeColor = settingsDto.PipeLengthOutOfRangeColor;
    pipeLengthInRangeColor = settingsDto.PipeLengthInRangeColor;
    pipeConnectedColor = settingsDto.PipeConnectedColor;
    pipeActivatedColor = settingsDto.PipeActivatedColor;

    SaveSettings(settingsDto);
    Sound.UpdateVolumeSettings();
  }

  public SettingsDto CreateSettingsDto()
  {
    return new SettingsDto
    {
      PipeItemSizeDelta = pipeItemSizeDelta,
      SettingsFileName = settingsFileName,
      GameResultsFileName = gameResultsFileName,
      PositiveHydrantColor = positiveHydrantColor,
      NegativeHydrantColor = negativeHydrantColor,
      PipeLengthOutOfRangeColor = pipeLengthOutOfRangeColor,
      PipeLengthInRangeColor = pipeLengthInRangeColor,
      PipeConnectedColor = pipeConnectedColor,
      PipeActivatedColor = pipeActivatedColor
    };
  }

  private void SaveSettings(SettingsDto settingsDto)
  {
    using (var stream = new FileStream(Settings.SettingsFilePath, FileMode.OpenOrCreate, FileAccess.Write))
    {
      new XmlSerializer(typeof(SettingsDto)).Serialize(stream, settingsDto);
    }
  }

  private void LoadSettings()
  {
    if (!File.Exists(Settings.SettingsFilePath))
    {
      return;
    }

    SettingsDto settingsDto;
    using (var stream = new FileStream(Settings.SettingsFilePath, FileMode.Open, FileAccess.Read))
    {
      settingsDto = (SettingsDto)new XmlSerializer(typeof(SettingsDto)).Deserialize(stream);
    }
    ApplySettings(settingsDto);
  }
}
