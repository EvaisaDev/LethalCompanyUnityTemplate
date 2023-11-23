using System;
using UnityEngine;

namespace DunGen
{
	[Serializable]
	public sealed class GameObjectChance
	{
		public GameObject Value;

		public float MainPathWeight;

		public float BranchPathWeight;

		public AnimationCurve DepthWeightScale;

		public TileSet TileSet;

		public GameObjectChance()
		{
		}

		public GameObjectChance(GameObject value)
		{
		}

		public GameObjectChance(GameObject value, float mainPathWeight, float branchPathWeight, TileSet tileSet)
		{
		}

		public float GetWeight(bool isOnMainPath, float normalizedDepth)
		{
			return 0f;
		}
	}
}
