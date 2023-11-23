using System;
using UnityEngine;

[Serializable]
public class SpawnableOutsideMapObject
{
	public GameObject prefabToSpawn;

	public bool spawnFacingAwayFromWall;

	[Tooltip("Y Axis is the amount to be spawned; X axis should be from 0 to 1 and is randomly picked from.")]
	public AnimationCurve numberToSpawn;

	[Tooltip("This is used to determine how close this object can spawn to edges of the nav mesh.")]
	public int objectWidth;

	public string spawnableFloorTag;

	public Vector3 rotationOffset;
}
