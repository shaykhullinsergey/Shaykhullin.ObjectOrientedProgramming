using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaykhullin.DependencyInjection.Abstraction
{
	public interface IService
	{
		TResolve Resolve<TResolve>(params object[] args);
	}
}
