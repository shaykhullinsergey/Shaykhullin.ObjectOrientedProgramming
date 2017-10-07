using System;
using System.Collections.Generic;
using Shaykhullin.DependencyInjection.Abstraction;

namespace Shaykhullin.DependencyInjection.App
{
	public class AppServiceBuilder : IServiceBuilder
	{
    private IDependencyContainer container = new AppDependencyContainer();

		public IService Service
    {
      get
      {
        var service = new AppService(container);

        container.Add(null, typeof(IService),
          new AppSingletonCreationalBehaviour<IService>(service));

        return service;
      }
    }

		public IServiceEntity<TRegister> Register<TRegister>()
		{
			return new AppServiceEntity<TRegister>(this, container);
		}
	}
}
