using System;
using System.Collections.Generic;

namespace Shaykhullin.DependencyInjection.Abstraction
{
  internal interface IDependencyContainer
  {
    void Add(string name, Type type, ICreationalBehaviour behaviour);
    ICreationalBehaviour TryGet(Type type, string name = null);
    IEnumerable<ICreationalBehaviour> TryGetAll(Type type);
  }
}
