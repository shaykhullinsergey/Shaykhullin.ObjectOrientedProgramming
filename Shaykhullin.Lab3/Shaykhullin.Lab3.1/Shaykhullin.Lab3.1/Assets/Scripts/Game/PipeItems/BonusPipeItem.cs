using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusPipeItem : PipeItem
{
  public override void Use()
  {
    Game.MiniGame.StartRandom();
    Game.Sidebar.AddRandom();
  }
}
