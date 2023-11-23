using UnityEngine;

namespace DunGen
{
	[AddComponentMenu("DunGen/Random Props/Random Prefab")]
	public class RandomPrefab : RandomProp
	{
		[AcceptGameObjectTypes(GameObjectFilter.Asset)]
		public GameObjectChanceTable Props;

		public bool ZeroPosition;

		public bool ZeroRotation;

		public override void Process(RandomStream randomStream, Tile tile)
		{
		}
	}
}
