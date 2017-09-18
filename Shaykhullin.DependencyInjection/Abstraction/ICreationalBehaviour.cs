using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaykhullin.DependencyInjection.Abstraction
{
	public interface ICreationalBehaviour
	{
		TResolve Create<TResolve>(params object[] args);
	}
}
