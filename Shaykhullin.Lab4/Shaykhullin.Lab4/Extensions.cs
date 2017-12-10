using System;
using System.Collections.Generic;
using System.Text;

namespace Shaykhullin
{
  public static class Extensions
  {
    public static int CalculateBaseClasses(this Type type)
    {
      int baseTypes = 0;
      while ((type = type.BaseType) != typeof(object))
      {
        baseTypes++;
      }
      return baseTypes;
    }
  }
}
