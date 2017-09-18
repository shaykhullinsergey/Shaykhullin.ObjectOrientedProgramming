using System;
using System.Collections.Generic;
using Shaykhullin.DependencyInjection.Abstraction;

namespace Shaykhullin.DependencyInjection.App
{
	internal class AppServiceEntity<TRegister> : IServiceEntity<TRegister>
	{
		private IServiceBuilder builder;
		private Dictionary<Type, ICreationalBehaviour> dependencies;
		private TRegister returns;

		public AppServiceEntity(IServiceBuilder builder, Dictionary<Type, ICreationalBehaviour> dependencies)
		{
			this.builder = builder;
			this.dependencies = dependencies;
		}

		public ICreationalSelector<TRegister, TResolve> As<TResolve>()
		{
			return new AppCreationalSelector<TRegister, TResolve>(builder, dependencies, returns);
		}

		public IServiceEntity<TRegister> Returns(TRegister returns)
		{
			this.returns = returns;
			return this;
		}

		public IServiceBuilder AsSingleton()
		{
			return new AppCreationalSelector<TRegister, TRegister>(builder, dependencies, returns).AsSingleton();
		}

		public IServiceBuilder AsTransient()
		{
			return new AppCreationalSelector<TRegister, TRegister>(builder, dependencies, returns).AsTransient();
		}
	}
}
