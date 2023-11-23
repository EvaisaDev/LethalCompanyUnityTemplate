using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class PlaceableObjectsSurface : NetworkBehaviour
{
	public NetworkObject parentTo;

	public Collider placeableBounds;

	public InteractTrigger triggerScript;

	private float checkHoverTipInterval;

	private void Update()
	{
	}

	public void PlaceObject(PlayerControllerB playerWhoTriggered)
	{
	}

	private Vector3 itemPlacementPosition(Transform gameplayCamera, GrabbableObject heldObject)
	{
		return default(Vector3);
	}
}
