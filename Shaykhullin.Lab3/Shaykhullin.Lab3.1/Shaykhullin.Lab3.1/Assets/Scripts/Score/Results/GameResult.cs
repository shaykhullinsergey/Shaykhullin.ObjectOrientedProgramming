using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameResult
{
  public string PlayerName { get; set; }
  public int Score { get; set; }
  public List<HydrantResult> Hydrants { get; set; }
  public List<ConnectionResult> Connections { get; set; }
}