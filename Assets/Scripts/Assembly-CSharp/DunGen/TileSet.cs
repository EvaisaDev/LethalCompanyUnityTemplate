using System;
using System.Collections.Generic;
using UnityEngine;

namespace DunGen
{
	[Serializable]
	[CreateAssetMenu(menuName = "DunGen/Tile Set", order = 700)]
	public sealed class TileSet : ScriptableObject
	{
		public GameObjectChanceTable TileWeights;

		public List<LockedDoorwayAssociation> LockPrefabs;

		public void AddTile(GameObject tilePrefab, float mainPathWeight, float branchPathWeight)
		{
		}

		public void AddTiles(IEnumerable<GameObject> tilePrefab, float mainPathWeight, float branchPathWeight)
		{
		}
	}
}
