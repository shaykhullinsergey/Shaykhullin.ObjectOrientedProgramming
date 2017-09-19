using System;
using System.Collections.Generic;
using Shaykhullin.DependencyInjection.Abstraction;

namespace Shaykhullin.DependencyInjection.App
{
	public class AppServiceBuilder : IServiceBuilder
	{
		private Dictionary<Type, ICreationalBehaviour> dependensies = new Dictionary<Type, ICreationalBehaviour>();
		public IService Service
    {
      get
      {
        var service = new AppService(dependensies);
        dependensies.Add(typeof(IService), new AppSingletonCreationalBehaviour<IService>(service));
        return service;
      }
    }

		public IServiceEntity<TRegister> Register<TRegister>()
		{
			return new AppServiceEntity<TRegister>(this, dependensies);
		}
	}
}
