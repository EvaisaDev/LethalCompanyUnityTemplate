using GameNetcodeStuff;
using Unity.Netcode;

public class RagdollGrabbableObject : GrabbableObject
{
	public NetworkVariable<int> bodyID;

	public DeadBodyInfo ragdoll;

	private bool foundRagdollObject;

	private bool bodySetToHold;

	public bool testBody;

	private bool setBodyInElevator;

	private PlayerControllerB previousPlayerHeldBy;

	private bool hasBeenPlaced;

	public bool heldByEnemy;

	private bool heldByEnemyThisFrame;

	public override void Start()
	{
	}

	public override void EquipItem()
	{
	}

	public override void OnPlaceObject()
	{
	}

	public override void OnDestroy()
	{
	}

	public override void Update()
	{
	}

	public override void GrabItemFromEnemy(EnemyAI enemy)
	{
	}

	public override void DiscardItemFromEnemy()
	{
	}

	private void SetRagdollParentToMatchHoldingPlayer()
	{
	}
}
