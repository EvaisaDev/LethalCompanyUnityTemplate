using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public abstract class GrabbableObject : NetworkBehaviour
{
	public bool grabbable;

	public bool isHeld;

	public bool isHeldByEnemy;

	public bool deactivated;

	[Space(3f)]
	public Transform parentObject;

	public Vector3 targetFloorPosition;

	public Vector3 startFallingPosition;

	public int floorYRot;

	public float fallTime;

	public bool hasHitGround;

	[Space(5f)]
	public int scrapValue;

	public bool itemUsedUp;

	public PlayerControllerB playerHeldBy;

	public bool isPocketed;

	public bool isBeingUsed;

	public bool isInElevator;

	public bool isInShipRoom;

	public bool isInFactory;

	[Space(10f)]
	public float useCooldown;

	public float currentUseCooldown;

	[Space(10f)]
	public Item itemProperties;

	public Battery insertedBattery;

	public string customGrabTooltip;

	[HideInInspector]
	public Rigidbody propBody;

	[HideInInspector]
	public Collider[] propColliders;

	[HideInInspector]
	public Vector3 originalScale;

	public bool wasOwnerLastFrame;

	public MeshRenderer mainObjectRenderer;

	private int isSendingItemRPC;

	public bool scrapPersistedThroughRounds;

	public bool heldByPlayerOnServer;

	[HideInInspector]
	public Transform radarIcon;

	public bool reachedFloorTarget;

	[Space(3f)]
	public bool grabbableToEnemies;

	private bool hasBeenHeld;

	public virtual int GetItemDataToSave()
	{
		return 0;
	}

	public virtual void LoadItemSaveData(int saveData)
	{
	}

	public virtual void Start()
	{
	}

	public void FallToGround(bool randomizePosition = false)
	{
	}

	public void EnablePhysics(bool enable)
	{
	}

	public virtual void InspectItem()
	{
	}

	public virtual void InteractItem()
	{
	}

	public void GrabItemOnClient()
	{
	}

	public virtual void SetControlTipsForItem()
	{
	}

	public virtual void GrabItem()
	{
	}

	public void UseItemOnClient(bool buttonDown = true)
	{
	}

	public bool UseItemBatteries()
	{
		return false;
	}

	public virtual void ItemActivate(bool used, bool buttonDown = true)
	{
	}

	public void ItemInteractLeftRightOnClient(bool right)
	{
	}

	public virtual void ItemInteractLeftRight(bool right)
	{
	}

	public virtual void UseUpBatteries()
	{
	}

	public virtual void GrabItemFromEnemy(EnemyAI enemy)
	{
	}

	public virtual void DiscardItemFromEnemy()
	{
	}

	public virtual void ChargeBatteries()
	{
	}

	public virtual void DestroyObjectInHand(PlayerControllerB playerHolding)
	{
	}

	public virtual void EquipItem()
	{
	}

	public virtual void PocketItem()
	{
	}

	public void DiscardItemOnClient()
	{
	}

	[ServerRpc]
	public void SyncBatteryServerRpc(int charge)
	{
	}

	[ClientRpc]
	public void SyncBatteryClientRpc(int charge)
	{
	}

	public virtual void DiscardItem()
	{
	}

	public virtual void LateUpdate()
	{
	}

	public virtual void FallWithCurve()
	{
	}

	public virtual void OnPlaceObject()
	{
	}

	public virtual void OnBroughtToShip()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void OnHitGround()
	{
	}

	private void PlayDropSFX()
	{
	}

	public void SetScrapValue(int setValueTo)
	{
	}

	public bool RequireCooldown()
	{
		return false;
	}

	[ServerRpc(RequireOwnership = false)]
	private void InteractLeftRightServerRpc(bool right)
	{
	}

	[ClientRpc]
	private void InteractLeftRightClientRpc(bool right)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void GrabServerRpc()
	{
	}

	[ClientRpc]
	private void GrabClientRpc()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void ActivateItemServerRpc(bool onOff, bool buttonDown)
	{
	}

	[ClientRpc]
	private void ActivateItemClientRpc(bool onOff, bool buttonDown)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void DiscardItemServerRpc()
	{
	}

	[ClientRpc]
	private void DiscardItemClientRpc()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void UseUpItemBatteriesServerRpc()
	{
	}

	[ClientRpc]
	private void UseUpItemBatteriesClientRpc()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void EquipItemServerRpc()
	{
	}

	[ClientRpc]
	private void EquipItemClientRpc()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void PocketItemServerRpc()
	{
	}

	[ClientRpc]
	private void PocketItemClientRpc()
	{
	}

	public void ChangeOwnershipOfProp(ulong clientId)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void ChangeOwnershipOfPropServerRpc(ulong NewOwner)
	{
	}

	public void EnableItemMeshes(bool enable)
	{
	}

	public Vector3 GetItemFloorPosition(Vector3 startPosition = default(Vector3))
	{
		return default(Vector3);
	}
}
