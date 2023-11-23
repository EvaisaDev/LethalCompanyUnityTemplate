using System;
using System.Collections.Generic;
using UnityEngine;

namespace DunGen
{
	[Serializable]
	public class GameObjectChanceTable
	{
		public List<GameObjectChance> Weights;

		public GameObjectChanceTable Clone()
		{
			return null;
		}

		public bool ContainsGameObject(GameObject obj)
		{
			return false;
		}

		public GameObjectChance GetRandom(RandomStream random, bool isOnMainPath, float normalizedDepth, GameObject previouslyChosen, bool allowImmediateRepeats, bool removeFromTable = false)
		{
			return null;
		}

		public static GameObject GetCombinedRandom(RandomStream random, bool isOnMainPath, float normalizedDepth, params GameObjectChanceTable[] tables)
		{
			return null;
		}

		public static GameObjectChanceTable Combine(params GameObjectChanceTable[] tables)
		{
			return null;
		}
	}
}
