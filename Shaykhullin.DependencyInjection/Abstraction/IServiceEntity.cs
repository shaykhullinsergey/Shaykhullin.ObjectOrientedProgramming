using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaykhullin.DependencyInjection.Abstraction
{
	public interface IServiceEntity<TRegister> : ICreationalSelector<TRegister, TRegister>
	{
		ICreationalSelector<TRegister, TResolve> As<TResolve>();
		IServiceEntity<TRegister> Returns(TRegister register);
	}
}
