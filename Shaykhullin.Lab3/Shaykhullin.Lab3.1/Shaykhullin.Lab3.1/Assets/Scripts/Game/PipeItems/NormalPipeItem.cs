public class NormalPipeItem : PipeItem
{
  public override void Use()
  {
    Game.Sidebar.AddRandom();
    Game.EndTurn();
  }
}
