using System;
using System.Linq;
using System.Reflection;
using Shaykhullin.DependencyInjection.Abstraction;

namespace Shaykhullin.DependencyInjection.App
{
  internal class AppService : IService
  {
    private IDependencyContainer container;

    public AppService(IDependencyContainer container)
    {
      this.container = container ?? throw new ArgumentNullException(nameof(container));
    }

    public TResolve Create<TResolve>(Type type, params object[] args)
    {
      var instance = (TResolve)Activator.CreateInstance(type, args);
      ResolveInstanceRecursive(instance);
      return instance;
    }

    public TResolve Resolve<TResolve>(params object[] args)
    {
      var creator = container.TryGet(typeof(TResolve));

      if (creator == null)
      {
        throw new NotSupportedException($"Type {typeof(TResolve).Name} is not registered in container");
      }

      var instance = creator.Create<TResolve>();
      ResolveInstanceRecursive(instance);
      return instance;
    }

    private void ResolveInstanceRecursive(object instance)
    {
      var fieldsInfo = instance.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
        .Where(field => field.IsDefined(typeof(InjectAttribute)))
        .Select(field => (field, field.GetCustomAttribute<InjectAttribute>()));

      foreach (var info in fieldsInfo)
      {
        var (field, inject) = info;

        var creator = container.TryGet(field.FieldType, inject.Name);

        if (creator != null)
        {
          field.SetValue(instance, creator.Create<object>());
          ResolveInstanceRecursive(field.GetValue(instance));
        }
      }

      var propertiesInfo = instance.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
        .Where(p => p.IsDefined(typeof(InjectAttribute)))
        .Select(p => (p, p.GetCustomAttribute<InjectAttribute>()));

      foreach (var info in propertiesInfo)
      {
        var (property, inject) = info;

        var creator = container.TryGet(property.PropertyType, inject.Name);

        if (creator != null)
        {
          property.SetValue(instance, creator.Create<object>());
          ResolveInstanceRecursive(property.GetValue(instance));
        }
      }
    }
  }
}
