using UnityEngine;

public class RandomScrapSpawn : MonoBehaviour
{
	public ItemGroup spawnableItems;

	public float itemSpawnRange;

	[Space(5f)]
	public bool spawnedItemsCopyPosition;

	public bool spawnUsed;
}
