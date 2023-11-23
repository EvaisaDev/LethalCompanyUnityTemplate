using System.Collections.Generic;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class HoarderBugAI : EnemyAI
{
	public AISearchRoutine searchForItems;

	public AISearchRoutine searchForPlayer;

	[Header("Tracking/Memory")]
	[Space(3f)]
	public Vector3 nestPosition;

	private bool choseNestPosition;

	[Space(3f)]
	public static List<HoarderBugItem> HoarderBugItems;

	public static List<GameObject> grabbableObjectsInMap;

	public float angryTimer;

	public GrabbableObject targetItem;

	public HoarderBugItem heldItem;

	[Header("Animations")]
	[Space(5f)]
	private Vector3 agentLocalVelocity;

	private Vector3 previousPosition;

	private float velX;

	private float velZ;

	public Transform turnCompass;

	private float armsHoldLayerWeight;

	[Space(5f)]
	public Transform animationContainer;

	public Transform grabTarget;

	public MultiAimConstraint headLookRig;

	public Transform headLookTarget;

	[Header("Special behaviour states")]
	private float annoyanceMeter;

	public bool watchingPlayerNearPosition;

	public PlayerControllerB watchingPlayer;

	public Transform lookTarget;

	public bool lookingAtPositionOfInterest;

	private Vector3 positionOfInterest;

	private bool isAngry;

	[Header("Misc logic")]
	private bool sendingGrabOrDropRPC;

	private float waitingAtNestTimer;

	private bool waitingAtNest;

	private float timeSinceSeeingAPlayer;

	[Header("Chase logic")]
	private bool lostPlayerInChase;

	private float noticePlayerTimer;

	public PlayerControllerB angryAtPlayer;

	private bool inChase;

	[Header("Audios")]
	public AudioClip[] chitterSFX;

	[Header("Audios")]
	public AudioClip[] angryScreechSFX;

	public AudioClip angryVoiceSFX;

	public AudioClip bugFlySFX;

	public AudioClip hitPlayerSFX;

	private float timeSinceHittingPlayer;

	private float timeSinceLookingTowardsNoise;

	private float detectPlayersInterval;

	private bool inReturnToNestMode;

	public override void Start()
	{
	}

	public static void RefreshGrabbableObjectsInMapList()
	{
	}

	private bool GrabTargetItemIfClose()
	{
		return false;
	}

	private void ChooseNestPosition()
	{
	}

	[ServerRpc]
	private void SyncNestPositionServerRpc(Vector3 newNestPosition)
	{
	}

	[ClientRpc]
	private void SyncNestPositionClientRpc(Vector3 newNestPosition)
	{
	}

	public override void DoAIInterval()
	{
	}

	private void SetGoTowardsTargetObject(GameObject foundObject)
	{
	}

	private void ExitChaseMode()
	{
	}

	private void SetReturningToNest()
	{
	}

	private void LateUpdate()
	{
	}

	private void SetArmLayerWeight()
	{
	}

	private void CalculateAnimationDirection(float maxSpeed = 1f)
	{
	}

	private void AnimateLooking()
	{
	}

	private void DetectAndLookAtPlayers()
	{
	}

	private bool IsHoarderBugAngry()
	{
		return false;
	}

	public override void Update()
	{
	}

	public override void DetectNoise(Vector3 noisePosition, float noiseLoudness, int timesPlayedInOneSpot = 0, int noiseID = 0)
	{
	}

	private void DropItemAndCallDropRPC(NetworkObject dropItemNetworkObject, bool droppedInNest = true)
	{
	}

	[ServerRpc]
	public void DropItemServerRpc(NetworkObjectReference objectRef, Vector3 targetFloorPosition, bool droppedInNest)
	{
	}

	[ClientRpc]
	public void DropItemClientRpc(NetworkObjectReference objectRef, Vector3 targetFloorPosition, bool droppedInNest)
	{
	}

	[ServerRpc]
	public void GrabItemServerRpc(NetworkObjectReference objectRef)
	{
	}

	[ClientRpc]
	public void GrabItemClientRpc(NetworkObjectReference objectRef)
	{
	}

	private void DropItem(NetworkObject item, Vector3 targetFloorPosition, bool droppingInNest = true)
	{
	}

	private void GrabItem(NetworkObject item)
	{
	}

	public override void OnCollideWithPlayer(Collider other)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void HitPlayerServerRpc()
	{
	}

	[ClientRpc]
	public void HitPlayerClientRpc()
	{
	}

	public override void HitEnemy(int force = 1, PlayerControllerB playerWhoHit = null, bool playHitSFX = false)
	{
	}

	public override void KillEnemy(bool destroy = false)
	{
	}

	public HoarderBugItem CheckLineOfSightForItem(HoarderBugItemStatus searchForItemsOfStatus = HoarderBugItemStatus.Any, float width = 45f, int range = 60, float proximityAwareness = -1f)
	{
		return null;
	}
}
