namespace Shaykhullin.DependencyInjection.Abstraction
{
  public interface IServiceBuilder
	{
		IService Service { get; }
		IServiceEntity<TRegister> Register<TRegister>();
	}
}
