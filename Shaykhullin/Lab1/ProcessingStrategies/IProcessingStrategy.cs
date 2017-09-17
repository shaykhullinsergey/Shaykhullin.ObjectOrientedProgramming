namespace Shaykhullin.Shared.Lab1.ProcessingStrategies
{
  public interface IProcessingStrategy<TOut>
  {
    TOut Process();
  }

  public interface IStateProcessingStrategy<TOut, TProp> : IProcessingStrategy<TOut>
  {
    TProp State { get; set; }
  }

  public interface IStateValueProcessingStrategy<TOut, TProp1, TProp2> 
    : IStateProcessingStrategy<TOut, TProp1>
  {
    TProp2 Value { get; set; }
  }
}
