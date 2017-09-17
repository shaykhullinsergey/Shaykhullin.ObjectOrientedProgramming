using Shaykhullin.Builders;
using Shaykhullin.Shared.Lab1;
using System;
using System.Collections.Generic;
using System.Text;
using static Shaykhullin.Shared.Lab1.Quaternion;

namespace Shaykhullin.Extensions
{
  public static class QuaternionExtensions
  {
    public static QuaternionBuilder AsSeparate(this QuaternionFactory factory)
    {
      return new QuaternionBuilder();
    }
  }
}
