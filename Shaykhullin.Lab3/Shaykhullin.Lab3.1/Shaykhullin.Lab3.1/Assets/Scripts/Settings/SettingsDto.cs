using UnityEngine;

public class SettingsDto
{
  public int SoundVolume { get; set; }
  // Hydrant
  public int MinDistanceBetweenHydrants { get; set; }
  public int MinStartHydrantCount { get; set; }
  public int MaxStartHydrantCount { get; set; }
  public int MinHydrantCapacity { get; set; }
  public int MaxHydrantCapacity { get; set; }
  public int MinFillHydrantSpeed { get; set; }
  public int MaxFillHydrantSpeed { get; set; }
  public int MinTurnsToNextHydrant { get; set; }
  public int MaxTurnsToNextHydrant { get; set; }
  // Pipe
  public int BonusPipeChance { get; set; }
  public int MinStartAvaliablePipesCount { get; set; }
  public int MaxStartAvaliablePipesCount { get; set; }
  public int MinPipeLengthMin { get; set; }
  public int MinPipeLengthMax { get; set; }
  public int MaxPipeLengthMin { get; set; }
  public int MaxPipeLengthMax { get; set; }
  public int MinStreamPower { get; set; }
  public int MaxStreamPower { get; set; }
  // Minigame
  public int FirstMiniGameTimeLimit { get; set; }
  public int SecondMiniGameTimeLimit { get; set; }
  public int ThirdMiniGameTimeLimit { get; set; }
  // Developer
  public int PipeItemSizeDelta { get; set; }
  public string SettingsFileName { get; set; }
  public string GameResultsFileName { get; set; }
  public Color PositiveHydrantColor { get; set; }
  public Color NegativeHydrantColor { get; set; }
  public Color PipeLengthOutOfRangeColor { get; set; }
  public Color PipeLengthInRangeColor { get; set; }
  public Color PipeConnectedColor { get; set; }
  public Color PipeActivatedColor { get; set; }
}
