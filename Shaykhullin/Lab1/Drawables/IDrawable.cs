namespace Shaykhullin.Shared.Lab1.Drawables
{
  public interface IDrawable<TInput, TResult>
  {
    TInput Draw(TResult draw);
  }
}
