using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DunGen
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public sealed class AcceptGameObjectTypesAttribute : PropertyAttribute
	{
		public GameObjectFilter Filter
		{
			[CompilerGenerated]
			get
			{
				return default(GameObjectFilter);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public AcceptGameObjectTypesAttribute(GameObjectFilter filter)
		{
		}
	}
}
