namespace Shaykhullin.Extensions
{
  public static class IntExtensions
  {
    public static bool IsInRange(this int number, int start, int end)
    {
      return number >= start && number <= end;
    }

    public static bool And(this bool last, int number, int start, int end)
    {
      return last && number.IsInRange(start, end);
    }
  }
}
