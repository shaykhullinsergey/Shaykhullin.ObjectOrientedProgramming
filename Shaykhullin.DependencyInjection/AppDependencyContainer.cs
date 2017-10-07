using System;
using System.Collections.Generic;
using Shaykhullin.DependencyInjection.Abstraction;

namespace Shaykhullin.DependencyInjection
{
  public class AppDependencyContainer : IDependencyContainer
  {
    private Dictionary<AppDependencyKey, ICreationalBehaviour> dependencies = new Dictionary<AppDependencyKey, ICreationalBehaviour>();

    public void Add(string name, Type type, ICreationalBehaviour behaviour)
    {
      dependencies.Add(new AppDependencyKey(name, type), behaviour);
    }

    public ICreationalBehaviour TryGet(Type type, string name = null)
    {
      dependencies.TryGetValue(new AppDependencyKey(name, type), out var creator);
      return creator;
    }

    public IEnumerable<ICreationalBehaviour> TryGetAll(Type type)
    {
      foreach (var dependency in dependencies)
      {
        if (dependency.Key.Type == type)
          yield return dependency.Value;
      }
    }

    private class AppDependencyKey
    {
      public string Name { get; }
      public Type Type { get; }

      public AppDependencyKey(string name, Type type)
      {
        Name = name;
        Type = type ?? throw new ArgumentNullException(nameof(type));
      }

      public override bool Equals(object obj)
      {
        var key = obj as AppDependencyKey;
        return key != null &&
               Name == key.Name &&
               EqualityComparer<Type>.Default.Equals(Type, key.Type);
      }

      public override int GetHashCode()
      {
        var hashCode = -243844509;
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
        hashCode = hashCode * -1521134295 + EqualityComparer<Type>.Default.GetHashCode(Type);
        return hashCode;
      }
    }
  }
}
