using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class BaboonBirdAI : EnemyAI
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public float startTime;

		public PlayerControllerB killedPlayer;

		internal bool _003CkillPlayerAnimation_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CkillPlayerAnimation_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int playerObject;

		public BaboonBirdAI _003C_003E4__this;

		private _003C_003Ec__DisplayClass79_0 _003C_003E8__1;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CkillPlayerAnimation_003Ed__79(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public Dictionary<Transform, Threat> threats;

	public Transform focusedThreatTransform;

	public Threat focusedThreat;

	public bool focusingOnThreat;

	public bool focusedThreatIsInView;

	private int focusLevel;

	private float fearLevel;

	private float fearLevelNoDistComparison;

	private Vector3 agentLocalVelocity;

	private float velX;

	private float velZ;

	private Vector3 previousPosition;

	public Transform animationContainer;

	public MultiAimConstraint headLookRig;

	public Transform headLookTarget;

	private Ray lookRay;

	public float fov;

	public float visionDistance;

	private int visibleThreatsMask;

	private int scrapMask;

	private int leadershipLevel;

	private int previousBehaviourState;

	public BaboonHawkGroup scoutingGroup;

	private float miscAnimationTimer;

	private int currentMiscAnimation;

	private Vector3 lookTarget;

	private Vector3 peekTarget;

	private float peekTimer;

	public AISearchRoutine scoutingSearchRoutine;

	public static Vector3 baboonCampPosition;

	public float scoutTimer;

	public float timeToScout;

	private float timeSinceRestWhileScouting;

	private float restingDuringScouting;

	private bool eyesClosed;

	private bool restingAtCamp;

	private float restAtCampTimer;

	private float chosenDistanceToCamp;

	private float timeSincePingingBirdInterest;

	private float timeSinceLastMiscAnimation;

	private int aggressiveMode;

	private int previousAggressiveMode;

	private float fightTimer;

	public AudioSource aggressionAudio;

	private Vector3 debugSphere;

	public Collider ownCollider;

	private float timeSinceAggressiveDisplay;

	private float timeSpentFocusingOnThreat;

	private float timeSinceFighting;

	private bool doingKillAnimation;

	private Coroutine killAnimCoroutine;

	private float timeSinceHitting;

	public Transform deadBodyPoint;

	public AudioClip[] cawScreamSFX;

	public AudioClip[] cawLaughSFX;

	private float noiseTimer;

	private float noiseInterval;

	public GrabbableObject focusedScrap;

	public GrabbableObject heldScrap;

	public bool movingToScrap;

	public Transform grabTarget;

	public TwoBoneIKConstraint leftArmRig;

	public TwoBoneIKConstraint rightArmRig;

	private bool oddAIInterval;

	private DeadBodyInfo killAnimationBody;

	private float timeSinceBeingAttackedByPlayer;

	private float timeSinceJoiningOrLeavingScoutingGroup;

	private BaboonBirdAI biggestBaboon;

	public override void Start()
	{
	}

	[ServerRpc]
	public void SyncInitialValuesServerRpc(int syncLeadershipLevel, Vector3 campPosition)
	{
	}

	[ClientRpc]
	public void SyncInitialValuesClientRpc(int syncLeadershipLevel, Vector3 campPosition)
	{
	}

	public void LateUpdate()
	{
	}

	public override void OnCollideWithPlayer(Collider other)
	{
	}

	public override void OnCollideWithEnemy(Collider other, EnemyAI enemyScript = null)
	{
	}

	public override void HitEnemy(int force = 1, PlayerControllerB playerWhoHit = null, bool playHitSFX = false)
	{
	}

	public override void KillEnemy(bool destroy = false)
	{
	}

	public void StopKillAnimation()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void StabPlayerDeathAnimServerRpc(int playerObject)
	{
	}

	[ClientRpc]
	public void StabPlayerDeathAnimClientRpc(int playerObject)
	{
	}

	[IteratorStateMachine(typeof(_003CkillPlayerAnimation_003Ed__79))]
	private IEnumerator killPlayerAnimation(int playerObject)
	{
		return null;
	}

	private void InteractWithScrap()
	{
	}

	private bool CanGrabScrap(GrabbableObject scrap)
	{
		return false;
	}

	private void DropHeldItemAndSync()
	{
	}

	[ServerRpc]
	public void DropScrapServerRpc(NetworkObjectReference item, Vector3 targetFloorPosition, int clientWhoSentRPC)
	{
	}

	[ClientRpc]
	public void DropScrapClientRpc(NetworkObjectReference item, Vector3 targetFloorPosition, int clientWhoSentRPC)
	{
	}

	private void DropScrap(NetworkObject item, Vector3 targetFloorPosition)
	{
	}

	private void GrabItemAndSync(NetworkObject item)
	{
	}

	[ServerRpc]
	public void GrabScrapServerRpc(NetworkObjectReference item, int clientWhoSentRPC)
	{
	}

	[ClientRpc]
	public void GrabScrapClientRpc(NetworkObjectReference item, int clientWhoSentRPC)
	{
	}

	private void GrabScrap(NetworkObject item)
	{
	}

	public override void ReachedNodeInSearch()
	{
	}

	public override void DoAIInterval()
	{
	}

	private void StopFocusingThreat()
	{
	}

	[ServerRpc]
	public void StopFocusingThreatServerRpc(bool enterScoutingMode)
	{
	}

	[ClientRpc]
	public void StopFocusingThreatClientRpc(bool enterScoutingMode)
	{
	}

	private void SetAggressiveMode(int mode)
	{
	}

	[ServerRpc]
	public void SetAggressiveModeServerRpc(int mode)
	{
	}

	[ClientRpc]
	public void SetAggressiveModeClientRpc(int mode)
	{
	}

	private void SetThreatInView(bool inView)
	{
	}

	[ServerRpc]
	public void SetThreatInViewServerRpc(bool inView)
	{
	}

	[ClientRpc]
	public void SetThreatInViewClientRpc(bool inView)
	{
	}

	[ServerRpc]
	public void EnemyEnterRestModeServerRpc(bool sleep, bool atCamp)
	{
	}

	[ClientRpc]
	public void EnemyEnterRestModeClientRpc(bool sleep, bool atCamp)
	{
	}

	[ServerRpc]
	public void EnemyGetUpServerRpc()
	{
	}

	[ClientRpc]
	public void EnemyGetUpClientRpc()
	{
	}

	public override void OnDrawGizmos()
	{
	}

	public override void DetectNoise(Vector3 noisePosition, float noiseLoudness, int timesPlayedInOneSpot = 0, int noiseID = 0)
	{
	}

	private void AnimateLooking(Vector3 lookAtPosition)
	{
	}

	public override void Update()
	{
	}

	private float GetComfortableDistanceToThreat(Threat focusedThreat)
	{
		return 0f;
	}

	private void ReactToThreat(Threat closestThreat)
	{
	}

	[ServerRpc]
	public void StartFocusOnThreatServerRpc(NetworkObjectReference netObject)
	{
	}

	[ClientRpc]
	public void StartFocusOnThreatClientRpc(NetworkObjectReference netObject)
	{
	}

	private float ReactToOtherBaboonSighted(BaboonBirdAI otherBaboon)
	{
		return 0f;
	}

	private void DoLOSCheck()
	{
	}

	public void PingBaboonInterest(Vector3 interestPosition, int pingImportance)
	{
	}

	[ServerRpc]
	public void PingBirdInterestServerRpc(Vector3 lookPosition, float timeToPeek)
	{
	}

	[ClientRpc]
	public void PingBirdInterestClientRpc(Vector3 lookPosition, float timeToPeek)
	{
	}

	private void JoinScoutingGroup(BaboonBirdAI otherBaboon)
	{
	}

	public void StartScoutingGroup(BaboonBirdAI firstMember, bool syncWithClients)
	{
	}

	private void LeaveCurrentScoutingGroup(bool sync)
	{
	}

	[ServerRpc]
	public void LeaveScoutingGroupServerRpc()
	{
	}

	[ClientRpc]
	public void LeaveScoutingGroupClientRpc()
	{
	}

	[ServerRpc]
	public void StartScoutingGroupServerRpc(NetworkObjectReference leaderNetworkObject)
	{
	}

	[ClientRpc]
	public void StartScoutingGroupClientRpc(NetworkObjectReference leaderNetworkObject)
	{
	}

	[ServerRpc]
	public void JoinScoutingGroupServerRpc(NetworkObjectReference otherBaboonNetworkObject)
	{
	}

	[ClientRpc]
	public void JoinScoutingGroupClientRpc(NetworkObjectReference otherBaboonNetworkObject)
	{
	}

	public void CallToOtherBaboon(BaboonBirdAI otherBaboon)
	{
	}

	private void StartMiscAnimation(int anim)
	{
	}

	[ServerRpc]
	public void StartMiscAnimationServerRpc(int miscAnimationId)
	{
	}

	[ClientRpc]
	public void StartMiscAnimationClientRpc(int miscAnimationId)
	{
	}

	private void CalculateAnimationDirection(float maxSpeed = 1f)
	{
	}
}
