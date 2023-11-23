using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipBuildModeManager : NetworkBehaviour
{
	public AudioClip beginPlacementSFX;

	public AudioClip denyPlacementSFX;

	public AudioClip cancelPlacementSFX;

	public AudioClip storeItemSFX;

	[Space(5f)]
	public bool InBuildMode;

	private bool CanConfirmPosition;

	private PlaceableShipObject placingObject;

	public Transform ghostObject;

	public MeshFilter ghostObjectMesh;

	public MeshRenderer ghostObjectRenderer;

	public MeshFilter selectionOutlineMesh;

	public MeshRenderer selectionOutlineRenderer;

	public Material ghostObjectGreen;

	public Material ghostObjectRed;

	private PlayerControllerB player;

	private int placeableShipObjectsMask;

	private int placementMask;

	private int placementMaskAndBlockers;

	private float timeSincePlacingObject;

	public PlayerActions playerActions;

	private RaycastHit rayHit;

	private Ray playerCameraRay;

	private BoxCollider currentCollider;

	private Collider[] collidersInPlacingObject;

	public static ShipBuildModeManager Instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private Vector3 OffsetObjectFromWallBasedOnDimensions(Vector3 targetPosition, RaycastHit wall)
	{
		return default(Vector3);
	}

	private void Update()
	{
	}

	private bool PlayerMeetsConditionsToBuild(bool log = true)
	{
		return false;
	}

	private void EnterBuildMode(InputAction.CallbackContext context)
	{
	}

	private void CreateGhostObjectAndHighlight()
	{
	}

	public void CancelBuildMode(bool cancelBeforePlacement = true)
	{
	}

	private void ConfirmBuildMode_performed(InputAction.CallbackContext context)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void PlaceShipObjectServerRpc(Vector3 newPosition, Vector3 newRotation, NetworkObjectReference objectRef, int playerWhoMoved)
	{
	}

	[ClientRpc]
	public void PlaceShipObjectClientRpc(Vector3 newPosition, Vector3 newRotation, NetworkObjectReference objectRef, int playerWhoMoved)
	{
	}

	private void StoreObject_performed(InputAction.CallbackContext context)
	{
	}

	public void StoreObjectLocalClient()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void StoreObjectServerRpc(NetworkObjectReference objectRef, int playerWhoStored)
	{
	}

	[ClientRpc]
	public void StoreShipObjectClientRpc(NetworkObjectReference objectRef, int playerWhoStored, int unlockableID)
	{
	}

	public void PlaceShipObject(Vector3 placementPosition, Vector3 placementRotation, PlaceableShipObject placeableObject, bool placementSFX = true)
	{
	}

	public void ResetShipObjectToDefaultPosition(PlaceableShipObject placeableObject)
	{
	}
}
