using System;
using System.Collections.Generic;
using Shaykhullin.DependencyInjection.Abstraction;

namespace Shaykhullin.DependencyInjection.App
{
	internal class AppCreationalSelector<TRegister, TResolve> : ICreationalSelector<TRegister, TResolve>
	{
		private IServiceBuilder builder;
		private Dictionary<Type, ICreationalBehaviour> dependencies;
		private TRegister returns;

		public AppCreationalSelector(IServiceBuilder builder, Dictionary<Type, ICreationalBehaviour> dependencies, TRegister returns)
		{
			this.builder = builder;
			this.dependencies = dependencies;
			this.returns = returns;
		}

		public IServiceBuilder AsSingleton()
		{
			dependencies.Add(typeof(TResolve), new AppSingletonCreationalBehaviour<TRegister>(returns));
			return builder;
		}

		public IServiceBuilder AsTransient()
		{
			dependencies.Add(typeof(TResolve), new AppTransientCreationalBehaviour<TRegister>(returns));
			return builder;
		}
	}
}
