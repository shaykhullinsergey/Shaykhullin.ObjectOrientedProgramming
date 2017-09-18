using System;

namespace Shaykhullin.DependencyInjection
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class InjectAttribute : Attribute
	{
	}
}