using System.Collections.Generic;
using UnityEngine;

namespace DunGen
{
	public static class DungeonUtil
	{
		public static void AddAndSetupDoorComponent(Dungeon dungeon, GameObject doorPrefab, Doorway doorway)
		{
		}

		public static bool HasAnyViableEntries(this List<GameObjectWeight> weights)
		{
			return false;
		}

		public static GameObject GetRandom(this List<GameObjectWeight> weights, RandomStream randomStream)
		{
			return null;
		}
	}
}
