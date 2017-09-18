using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaykhullin.DependencyInjection.Abstraction
{
	public interface IServiceBuilder
	{
		IService Service { get; }
		IServiceEntity<TRegister> Register<TRegister>() where TRegister : new();
	}
}
