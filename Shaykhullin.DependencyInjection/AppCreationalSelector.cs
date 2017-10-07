using System;
using System.Collections.Generic;
using Shaykhullin.DependencyInjection.Abstraction;

namespace Shaykhullin.DependencyInjection.App
{
	internal class AppCreationalSelector<TRegister, TResolve> : ICreationalSelector<TRegister, TResolve>
	{
		private IServiceBuilder builder;
    private IDependencyContainer container;
		private TRegister returns;
    private string named;

		public AppCreationalSelector(IServiceBuilder builder, IDependencyContainer container, TRegister returns, string named)
		{
			this.builder = builder;
			this.container = container;
			this.returns = returns;
		}

		public IServiceBuilder AsSingleton()
		{
			container.Add(named, typeof(TResolve), new AppSingletonCreationalBehaviour<TRegister>(returns));
			return builder;
		}

		public IServiceBuilder AsTransient()
		{
			container.Add(named, typeof(TResolve), new AppTransientCreationalBehaviour<TRegister>(returns));
			return builder;
		}
	}
}
