using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public sealed class SettingsManager : Manager<SettingsManager>
{
  public override bool DestroyOnLoad => false;

  [Header("Game Settings")]
  [SerializeField] private int minDistanceBetweenBoilers;
  [SerializeField] private int minBoilerCapacity;
  [SerializeField] private int maxBoilerCapacity;
  [SerializeField] private int minFillBoilerSpeed;
  [SerializeField] private int maxFillBoilerSpeed;
  [SerializeField] private int minPipeLengthMin;
  [SerializeField] private int minPipeLengthMax;
  [SerializeField] private int maxPipeLengthMin;
  [SerializeField] private int maxPipeLengthMax;
  [SerializeField] private int minStreamPower;
  [SerializeField] private int maxStreamPower;
  [SerializeField] private int firstMiniGameTimeLimit;
  [SerializeField] private int secondMiniGameTimeLimit;
  [SerializeField] private int thirdMiniGameTimeLimit;

  public int MinDistanceBetweenBoilers => minDistanceBetweenBoilers;
  public int MinBoilerCapacity => minBoilerCapacity;
  public int MaxBoilerCapacity => maxBoilerCapacity;
  public int MinFillBoilerSpeed => minFillBoilerSpeed;
  public int MaxFillBoilerSpeed => maxFillBoilerSpeed;
  public int MinPipeLengthMin => minPipeLengthMin;

  public int MinPipeLengthMax => minPipeLengthMax;
  public int MaxPipeLengthMin => maxPipeLengthMin;
  public int MaxPipeLengthMax => maxPipeLengthMax;
  public int MinStreamPower => minStreamPower;
  public int MaxStreamPower => maxStreamPower;
  public int FirstMiniGameTimeLimit => firstMiniGameTimeLimit;
  public int SecondMiniGameTimeLimit => secondMiniGameTimeLimit;
  public int ThirdMiniGameTimeLimit => thirdMiniGameTimeLimit;

  [Header("Developer Settings")]
  [SerializeField] private int shiftForAvaliablePipeUI; // 8
  [SerializeField] private List<Sprite> pipeSprites;
  [SerializeField] private List<Sprite> hydrantSprites;
  [SerializeField] private int minStartHydrantCount;
  [SerializeField] private int maxStartHydrantCount;
  [SerializeField] private int startAvaliablePipesCount;

  public int ShiftForAvaliablePipeUI => shiftForAvaliablePipeUI;
  public Sprite GetRandomPipeSprite() => pipeSprites[Random.Range(0, pipeSprites.Count)];
  public Sprite GetRandomHydrantSprite() => hydrantSprites[Random.Range(0, hydrantSprites.Count)];
  public int MinStartHydrantCount => minStartHydrantCount;
  public int MaxStartHydrantCount => maxStartHydrantCount;
  public int StartAvaliablePipesCount => startAvaliablePipesCount;

  internal Vector3 GenerateRandomHydrantPosition() =>
    new Vector3(Random.Range(-8.525f, 6.777f),
      Random.Range(-3.661f, 5.476f), 0);

  public void ChangeSettings(SettingsController controller)
  {
    minDistanceBetweenBoilers = controller.MinDistanceBetweenBoilers;
    maxBoilerCapacity = controller.MaxBoilerCapacity;
    maxFillBoilerSpeed = controller.MaxFillBoilerSpeed;
    minPipeLengthMin = controller.MinPipeLengthMin;
    minPipeLengthMax = controller.MinPipeLengthMax;
    maxPipeLengthMin = controller.MaxPipeLengthMin;
    maxPipeLengthMax = controller.MaxPipeLengthMax;
    minStreamPower = controller.MinStreamPower;
    maxStreamPower = controller.MaxStreamPower;
    firstMiniGameTimeLimit = controller.FirstMiniGameTimeLimit;
    secondMiniGameTimeLimit = controller.SecondMiniGameTimeLimit;
    thirdMiniGameTimeLimit = controller.ThirdMiniGameTimeLimit;
  }
}