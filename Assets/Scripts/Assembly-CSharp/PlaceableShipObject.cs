using UnityEngine;

public class PlaceableShipObject : MonoBehaviour
{
	public int unlockableID;

	public AudioClip placeObjectSFX;

	public AutoParentToShip parentObject;

	public Transform parentObjectSecondary;

	[Space(3f)]
	public MeshFilter mainMesh;

	public Transform mainTransform;

	public Collider placeObjectCollider;

	public float yOffset;

	[Space(3f)]
	public bool overrideWallOffset;

	public float wallOffset;

	public Vector3 collisionPointCheck;

	public bool doCollisionPointCheck;

	[Space(5f)]
	public bool AllowPlacementOnWalls;

	public bool AllowPlacementOnCounters;

	[Space(3f)]
	public bool inUse;
}
