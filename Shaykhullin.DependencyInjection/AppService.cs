using System;
using System.Collections.Generic;
using Shaykhullin.DependencyInjection.Abstraction;
using System.Linq;
using System.Reflection;

namespace Shaykhullin.DependencyInjection.App
{
	internal class AppService : IService
	{
		private Dictionary<Type, ICreationalBehaviour> dependensies = new Dictionary<Type, ICreationalBehaviour>();

		public AppService(Dictionary<Type, ICreationalBehaviour> dependensies)
		{
			this.dependensies = dependensies ?? throw new ArgumentNullException(nameof(dependensies));
		}

    public TResolve Create<TResolve>(Type type, params object[] args)
    {
      var instance = (TResolve)Activator.CreateInstance(type, args);
      ResolveFieldsRecursive(instance);
      ResolvePropertiesRecursive(instance);
      return instance;
    }

		public TResolve Resolve<TResolve>(params object[] args)
		{
			if(dependensies.TryGetValue(typeof(TResolve), out var creator))
			{
				var instance = creator.Create<TResolve>(args);
				ResolveFieldsRecursive(instance);
				ResolvePropertiesRecursive(instance);
				return instance;
			}

			throw new NotSupportedException($"Type {typeof(TResolve).Name} is not registered in container");
		}

		private void ResolveFieldsRecursive(object instance)
		{
			var fields = instance.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
				.Where(p => p.IsDefined(typeof(InjectAttribute)));

			foreach (var field in fields)
			{
				if (dependensies.TryGetValue(field.FieldType, out var fieldCreator))
				{
					field.SetValue(instance, fieldCreator.Create<object>());
				  ResolveFieldsRecursive(field.GetValue(instance));
				  ResolvePropertiesRecursive(field.GetValue(instance));
				}
			}
		}

		private void ResolvePropertiesRecursive(object instance)
		{
			var properties = instance.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
				.Where(p => p.IsDefined(typeof(InjectAttribute)));
			foreach (var property in properties)
			{
				if (dependensies.TryGetValue(property.PropertyType, out var propertyCreator))
				{
					property.SetValue(instance, propertyCreator.Create<object>());
				  ResolveFieldsRecursive(property.GetValue(instance));
				  ResolvePropertiesRecursive(property.GetValue(instance));
				}
			}
		}
	}
}
