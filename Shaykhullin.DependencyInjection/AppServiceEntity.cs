using System;
using System.Collections.Generic;
using Shaykhullin.DependencyInjection.Abstraction;

namespace Shaykhullin.DependencyInjection.App
{
	internal class AppServiceEntity<TRegister> : IServiceEntity<TRegister>
	{
		private IServiceBuilder builder;
		private IDependencyContainer container;
		private TRegister returns;
    private string named;

		public AppServiceEntity(IServiceBuilder builder, IDependencyContainer container)
		{
			this.builder = builder;
			this.container = container;
		}

		public ICreationalSelector<TRegister, TResolve> As<TResolve>()
		{
			return new AppCreationalSelector<TRegister, TResolve>(builder, container, returns, named);
		}

		public IServiceEntity<TRegister> Returns(TRegister returns)
		{
			this.returns = returns;
			return this;
		}

    public IServiceEntity<TRegister> Named(string named)
    {
      this.named = named;
      return this;
    }

		public IServiceBuilder AsSingleton()
		{
			return new AppCreationalSelector<TRegister, TRegister>(builder, container, returns, named).AsSingleton();
		}

		public IServiceBuilder AsTransient()
		{
			return new AppCreationalSelector<TRegister, TRegister>(builder, container, returns, named).AsTransient();
		}
	}
}
