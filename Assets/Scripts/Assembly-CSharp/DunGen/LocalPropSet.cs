using System.Collections.Generic;
using UnityEngine;

namespace DunGen
{
	[AddComponentMenu("DunGen/Random Props/Local Prop Set")]
	public class LocalPropSet : RandomProp
	{
		private static readonly Dictionary<LocalPropSetCountMode, GetPropCountDelegate> GetCountMethods;

		[AcceptGameObjectTypes(GameObjectFilter.Scene)]
		public GameObjectChanceTable Props;

		public IntRange PropCount;

		public LocalPropSetCountMode CountMode;

		public AnimationCurve CountDepthCurve;

		public override void Process(RandomStream randomStream, Tile tile)
		{
		}

		static LocalPropSet()
		{
		}

		private static int GetCountRandom(LocalPropSet propSet, RandomStream randomStream, Tile tile)
		{
			return 0;
		}

		private static int GetCountDepthBased(LocalPropSet propSet, RandomStream randomStream, Tile tile)
		{
			return 0;
		}

		private static int GetCountDepthMultiply(LocalPropSet propSet, RandomStream randomStream, Tile tile)
		{
			return 0;
		}
	}
}
