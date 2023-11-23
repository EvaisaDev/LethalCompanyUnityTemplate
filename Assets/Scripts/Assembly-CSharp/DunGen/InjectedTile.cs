using UnityEngine;

namespace DunGen
{
	public sealed class InjectedTile
	{
		public TileSet TileSet;

		public float NormalizedPathDepth;

		public float NormalizedBranchDepth;

		public bool IsOnMainPath;

		public bool IsRequired;

		public bool IsLocked;

		public int LockID;

		public GameObject LockedDoorPrefab;

		public InjectedTile(TileSet tileSet, bool isOnMainPath, float normalizedPathDepth, float normalizedBranchDepth, bool isRequired = false)
		{
		}

		public InjectedTile(TileInjectionRule rule, bool isOnMainPath, RandomStream randomStream)
		{
		}

		public bool ShouldInjectTileAtPoint(bool isOnMainPath, float pathDepth, float branchDepth)
		{
			return false;
		}
	}
}
