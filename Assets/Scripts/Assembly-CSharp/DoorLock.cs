using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(InteractTrigger))]
public class DoorLock : NetworkBehaviour
{
	private InteractTrigger doorTrigger;

	public float maxTimeLeft;

	public float lockPickTimeLeft;

	public bool isLocked;

	public bool isPickingLock;

	[Space(5f)]
	public DoorLock twinDoor;

	public Transform lockPickerPosition;

	public Transform lockPickerPosition2;

	private float enemyDoorMeter;

	private bool isDoorOpened;

	private NavMeshObstacle navMeshObstacle;

	public AudioClip pickingLockSFX;

	public AudioClip unlockSFX;

	public AudioSource doorLockSFX;

	private bool displayedLockTip;

	private bool localPlayerPickingLock;

	private int playersPickingDoor;

	private float playerPickingLockProgress;

	public void Awake()
	{
	}

	public void OnHoldInteract()
	{
	}

	public void LockDoor(float timeToLockPick = 30f)
	{
	}

	public void UnlockDoor()
	{
	}

	public void UnlockDoorSyncWithServer()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void UnlockDoorServerRpc()
	{
	}

	[ClientRpc]
	public void UnlockDoorClientRpc()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	public void OpenOrCloseDoor(PlayerControllerB playerWhoTriggered)
	{
	}

	public void SetDoorAsOpen(bool isOpen)
	{
	}

	public void OpenDoorAsEnemy()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void OpenDoorAsEnemyServerRpc()
	{
	}

	[ClientRpc]
	public void OpenDoorAsEnemyClientRpc()
	{
	}

	public void TryPickingLock()
	{
	}

	public void StopPickingLock()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void PlayerStopPickingLockServerRpc()
	{
	}

	[ClientRpc]
	public void PlayerStopPickingLockClientRpc()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void PlayerPickLockServerRpc()
	{
	}

	[ClientRpc]
	public void PlayerPickLockClientRpc()
	{
	}
}
