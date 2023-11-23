using System;
using UnityEngine;

[Serializable]
public class SpawnableMapObject
{
	public GameObject prefabToSpawn;

	public bool spawnFacingAwayFromWall;

	[Tooltip("Y Axis is the amount to be spawned; X axis should be from 0 to 1 and is randomly picked from.")]
	public AnimationCurve numberToSpawn;
}
