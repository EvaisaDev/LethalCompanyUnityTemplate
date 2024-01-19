using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.AI;

public abstract class EnemyAI : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CChooseNextNodeInSearchRoutine_003Ed__90 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyAI _003C_003E4__this;

		private float _003CclosestDist_003E5__2;

		private bool _003CgotNode_003E5__3;

		private GameObject _003CchosenNode_003E5__4;

		private int _003Ci_003E5__5;

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
		public _003CChooseNextNodeInSearchRoutine_003Ed__90(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CCurrentSearchCoroutine_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyAI _003C_003E4__this;

		private int _003CtimeSpent_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CCurrentSearchCoroutine_003Ed__88(int _003C_003E1__state)
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

	public EnemyType enemyType;

	[Space(5f)]
	public SkinnedMeshRenderer[] skinnedMeshRenderers;

	public MeshRenderer[] meshRenderers;

	public Animator creatureAnimator;

	public AudioSource creatureVoice;

	public AudioSource creatureSFX;

	public Transform eye;

	public AudioClip dieSFX;

	[Space(3f)]
	public EnemyBehaviourState[] enemyBehaviourStates;

	public EnemyBehaviourState currentBehaviourState;

	public int currentBehaviourStateIndex;

	public int previousBehaviourStateIndex;

	private int currentOwnershipOnThisClient;

	public bool isInsidePlayerShip;

	[Header("AI Calculation / Netcode")]
	public float AIIntervalTime;

	public bool inSpecialAnimation;

	public PlayerControllerB inSpecialAnimationWithPlayer;

	[HideInInspector]
	public Vector3 serverPosition;

	[HideInInspector]
	public Vector3 serverRotation;

	private float previousYRotation;

	private float targetYRotation;

	public NavMeshAgent agent;

	[HideInInspector]
	public NavMeshPath path1;

	public GameObject[] allAINodes;

	public Transform targetNode;

	public Transform favoriteSpot;

	[HideInInspector]
	public float tempDist;

	[HideInInspector]
	public float mostOptimalDistance;

	[HideInInspector]
	public float pathDistance;

	[HideInInspector]
	public NetworkObject thisNetworkObject;

	public int thisEnemyIndex;

	public bool isClientCalculatingAI;

	public float updatePositionThreshold;

	private Vector3 tempVelocity;

	public PlayerControllerB targetPlayer;

	public bool movingTowardsTargetPlayer;

	public bool moveTowardsDestination;

	public Vector3 destination;

	public float addPlayerVelocityToDestination;

	private float updateDestinationInterval;

	public float syncMovementSpeed;

	public float timeSinceSpawn;

	public float exitVentAnimationTime;

	public bool ventAnimationFinished;

	[Space(5f)]
	public bool isEnemyDead;

	public bool daytimeEnemyLeaving;

	public int enemyHP;

	private GameObject[] nodesTempArray;

	public float openDoorSpeedMultiplier;

	public bool useSecondaryAudiosOnAnimatedObjects;

	public AISearchRoutine currentSearch;

	public Coroutine searchCoroutine;

	public Coroutine chooseTargetNodeCoroutine;

	private RaycastHit raycastHit;

	private Ray LOSRay;

	public bool DebugEnemy;

	public int stunnedIndefinitely;

	public float stunNormalizedTimer;

	public float postStunInvincibilityTimer;

	public PlayerControllerB stunnedByPlayer;

	private float setDestinationToPlayerInterval;

	public bool debugEnemyAI;

	private bool removedPowerLevel;

	public bool isOutside;

	private System.Random searchRoutineRandom;

	public virtual void SetEnemyStunned(bool setToStunned, float setToStunTime = 1f, PlayerControllerB setStunnedByPlayer = null)
	{
	}

	public virtual void Start()
	{
	}

	public PlayerControllerB MeetsStandardPlayerCollisionConditions(Collider other, bool inKillAnimation = false, bool overrideIsInsideFactoryCheck = false)
	{
		return null;
	}

	public virtual void OnCollideWithPlayer(Collider other)
	{
	}

	public virtual void OnCollideWithEnemy(Collider other, EnemyAI collidedEnemy = null)
	{
	}

	public void SwitchToBehaviourState(int stateIndex)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SwitchToBehaviourServerRpc(int stateIndex)
	{
	}

	[ClientRpc]
	public void SwitchToBehaviourClientRpc(int stateIndex)
	{
	}

	public void SwitchToBehaviourStateOnLocalClient(int stateIndex)
	{
	}

	public void PlayAnimationOfCurrentState()
	{
	}

	public void PlayAudioOfCurrentState()
	{
	}

	public void SetMovingTowardsTargetPlayer(PlayerControllerB playerScript)
	{
	}

	public bool SetDestinationToPosition(Vector3 position, bool checkForPath = false)
	{
		return false;
	}

	public virtual void DoAIInterval()
	{
	}

	public void SyncPositionToClients()
	{
	}

	public PlayerControllerB CheckLineOfSightForPlayer(float width = 45f, int range = 60, int proximityAwareness = -1)
	{
		return null;
	}

	public PlayerControllerB CheckLineOfSightForClosestPlayer(float width = 45f, int range = 60, int proximityAwareness = -1, float bufferDistance = 0f)
	{
		return null;
	}

	public PlayerControllerB[] GetAllPlayersInLineOfSight(float width = 45f, int range = 60, Transform eyeObject = null, float proximityCheck = -1f, int layerMask = -1)
	{
		return null;
	}

	public GameObject CheckLineOfSight(List<GameObject> objectsToLookFor, float width = 45f, int range = 60, float proximityAwareness = -1f)
	{
		return null;
	}

	public bool HasLineOfSightToPosition(Vector3 pos, float width = 45f, int range = 60, float proximityAwareness = -1f)
	{
		return false;
	}

	public void StartSearch(Vector3 startOfSearch, AISearchRoutine newSearch = null)
	{
	}

	private int RoundUpToNearestFive(float x)
	{
		return 0;
	}

	public void StopSearch(AISearchRoutine search, bool clear = true)
	{
	}

	[IteratorStateMachine(typeof(_003CCurrentSearchCoroutine_003Ed__88))]
	private IEnumerator CurrentSearchCoroutine()
	{
		return null;
	}

	private void StartCalculatingNextTargetNode()
	{
	}

	[IteratorStateMachine(typeof(_003CChooseNextNodeInSearchRoutine_003Ed__90))]
	private IEnumerator ChooseNextNodeInSearchRoutine()
	{
		return null;
	}

	public virtual void ReachedNodeInSearch()
	{
	}

	private void EliminateNodeFromSearch(GameObject node)
	{
	}

	private void EliminateNodeFromSearch(int index)
	{
	}

	public virtual void FinishedCurrentSearchRoutine()
	{
	}

	public bool TargetClosestPlayer(float bufferDistance = 1.5f, bool requireLineOfSight = false, float viewWidth = 70f)
	{
		return false;
	}

	public PlayerControllerB GetClosestPlayer(bool requireLineOfSight = false, bool cannotBeInShip = false, bool cannotBeNearShip = false)
	{
		return null;
	}

	public bool PlayerIsTargetable(PlayerControllerB playerScript, bool cannotBeInShip = false, bool overrideInsideFactoryCheck = false)
	{
		return false;
	}

	public Transform ChooseFarthestNodeFromPosition(Vector3 pos, bool avoidLineOfSight = false, int offset = 0, bool log = false)
	{
		return null;
	}

	public Transform ChooseClosestNodeToPosition(Vector3 pos, bool avoidLineOfSight = false, int offset = 0)
	{
		return null;
	}

	public bool PathIsIntersectedByLineOfSight(Vector3 targetPos, bool calculatePathDistance = false, bool avoidLineOfSight = true)
	{
		return false;
	}

	public virtual void Update()
	{
	}

	public void KillEnemyOnOwnerClient(bool overrideDestroy = false)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void KillEnemyServerRpc(bool destroy)
	{
	}

	[ClientRpc]
	public void KillEnemyClientRpc(bool destroy)
	{
	}

	public virtual void KillEnemy(bool destroy = false)
	{
	}

	public virtual void CancelSpecialAnimationWithPlayer()
	{
	}

	public override void OnDestroy()
	{
	}

	private void SubtractFromPowerLevel()
	{
	}

	[ServerRpc]
	private void UpdateEnemyRotationServerRpc(short rotationY)
	{
	}

	[ClientRpc]
	private void UpdateEnemyRotationClientRpc(short rotationY)
	{
	}

	[ServerRpc]
	private void UpdateEnemyPositionServerRpc(Vector3 newPos)
	{
	}

	[ClientRpc]
	private void UpdateEnemyPositionClientRpc(Vector3 newPos)
	{
	}

	public virtual void OnSyncPositionFromServer(Vector3 newPos)
	{
	}

	public virtual void OnDrawGizmos()
	{
	}

	public void ChangeOwnershipOfEnemy(ulong newOwnerClientId)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void ChangeEnemyOwnerServerRpc(ulong clientId)
	{
	}

	[ClientRpc]
	public void ChangeEnemyOwnerClientRpc(int playerVal)
	{
	}

	public void SetClientCalculatingAI(bool enable)
	{
	}

	public virtual void EnableEnemyMesh(bool enable, bool overrideDoNotSet = false)
	{
	}

	public virtual void DetectNoise(Vector3 noisePosition, float noiseLoudness, int timesPlayedInOneSpot = 0, int noiseID = 0)
	{
	}

	public void HitEnemyOnLocalClient(int force = 1, Vector3 hitDirection = default(Vector3), PlayerControllerB playerWhoHit = null, bool playHitSFX = false)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void HitEnemyServerRpc(int force, int playerWhoHit, bool playHitSFX)
	{
	}

	[ClientRpc]
	public void HitEnemyClientRpc(int force, int playerWhoHit, bool playHitSFX)
	{
	}

	public virtual void HitEnemy(int force = 1, PlayerControllerB playerWhoHit = null, bool playHitSFX = false)
	{
	}

	private void CheckTimeOfDayToLeave()
	{
	}

	public virtual void DaytimeEnemyLeave()
	{
	}

	public void LogEnemyError(string error)
	{
	}

	public virtual void AnimationEventA()
	{
	}

	public virtual void AnimationEventB()
	{
	}

	public virtual void ShipTeleportEnemy()
	{
	}
}
