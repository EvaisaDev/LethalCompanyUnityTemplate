using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.AI;

public class SandSpiderAI : EnemyAI
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public int playerId;

		public float timeAtStartOfWait;

		internal bool _003CWaitForBodyToGrab_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CWaitForBodyToGrab_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int playerId;

		private _003C_003Ec__DisplayClass79_0 _003C_003E8__1;

		public SandSpiderAI _003C_003E4__this;

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
		public _003CWaitForBodyToGrab_003Ed__79(int _003C_003E1__state)
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
	private sealed class _003CturnBodyIntoWeb_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SandSpiderAI _003C_003E4__this;

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
		public _003CturnBodyIntoWeb_003Ed__69(int _003C_003E1__state)
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

	private float[] legDistances;

	public Vector3[] legPositions;

	public Transform[] legDefaultPositions;

	public Transform[] legTargets;

	public Transform abdomen;

	public Transform mouthTarget;

	public bool burrowing;

	public Transform turnCompass;

	public Vector3 wallPosition;

	public Vector3 wallNormal;

	public Vector3 floorPosition;

	private bool onWall;

	private RaycastHit rayHit;

	private Ray ray;

	public bool lookingForWallPosition;

	private bool gotWallPositionInLOS;

	private float tryWallPositionInterval;

	private bool reachedWallPosition;

	public Transform meshContainer;

	public Vector3 meshContainerPosition;

	public Vector3 meshContainerTarget;

	private Quaternion meshContainerTargetRotation;

	public float spiderSpeed;

	public float calculatePathToAgentInterval;

	public bool navigateMeshTowardsPosition;

	public Vector3 navigateToPositionTarget;

	public NavMeshHit navHit;

	public List<SandSpiderWebTrap> webTraps;

	public GameObject webTrapPrefab;

	public int maxWebTrapsToPlace;

	private float timeSincePlacingWebTrap;

	public Vector3 meshContainerServerPosition;

	public Vector3 meshContainerServerRotation;

	private Vector3 refVel;

	public Transform homeNode;

	public AISearchRoutine patrolHomeBase;

	private bool setDestinationToHomeBase;

	private float chaseTimer;

	private bool overrideSpiderLookRotation;

	private bool watchFromDistance;

	public float overrideAnimation;

	private float overrideAnimationWeight;

	private float timeSinceHittingPlayer;

	private DeadBodyInfo currentlyHeldBody;

	public Mesh playerBodyWebMesh;

	public Material playerBodyWebMat;

	private bool spooledPlayerBody;

	private bool spoolingPlayerBody;

	private Coroutine turnBodyIntoWebCoroutine;

	private bool decidedChanceToHangBodyEarly;

	public GameObject hangBodyPhysicsPrefab;

	private Coroutine grabBodyCoroutine;

	private float waitOnWallTimer;

	public AudioClip[] footstepSFX;

	public AudioSource footstepAudio;

	public AudioClip hitWebSFX;

	public AudioClip attackSFX;

	public AudioClip spoolPlayerSFX;

	public AudioClip hangPlayerSFX;

	public AudioClip breakWebSFX;

	public AudioClip hitSpiderSFX;

	private float lookAtPlayerInterval;

	public Rigidbody meshContainerRigidbody;

	private RaycastHit rayHitB;

	public MeshRenderer spiderSafeModeMesh;

	public SkinnedMeshRenderer spiderNormalMesh;

	private bool spiderSafeEnabled;

	public override void Start()
	{
	}

	public override void DoAIInterval()
	{
	}

	[IteratorStateMachine(typeof(_003CturnBodyIntoWeb_003Ed__69))]
	private IEnumerator turnBodyIntoWeb()
	{
		return null;
	}

	private void CancelSpoolingBody()
	{
	}

	[ServerRpc]
	public void SpiderTurnBodyIntoWebServerRpc()
	{
	}

	[ClientRpc]
	public void SpiderTurnBodyIntoWebClientRpc()
	{
	}

	[ServerRpc]
	public void SpiderHangBodyServerRpc()
	{
	}

	[ClientRpc]
	public void SpiderHangBodyClientRpc()
	{
	}

	private void HangBodyFromCeiling()
	{
	}

	[ServerRpc]
	public void GrabBodyServerRpc(int playerId)
	{
	}

	[ClientRpc]
	public void GrabBodyClientRpc(int playerId)
	{
	}

	private void GrabBody(DeadBodyInfo body)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForBodyToGrab_003Ed__79))]
	private IEnumerator WaitForBodyToGrab(int playerId)
	{
		return null;
	}

	private void CalculateSpiderPathToPosition()
	{
	}

	public override void Update()
	{
	}

	private void StopChasing(bool moveTowardsDeadPlayerBody = false)
	{
	}

	private void CalculateMeshMovement()
	{
	}

	private void SetSpiderLookAtPosition(Vector3 lookAt)
	{
	}

	private bool GetWallPositionForSpiderMesh()
	{
		return false;
	}

	public void LateUpdate()
	{
	}

	public void MoveLegsProcedurally()
	{
	}

	[ServerRpc]
	public void SyncMeshContainerPositionServerRpc(Vector3 syncPosition, Vector3 syncRotation)
	{
	}

	[ClientRpc]
	public void SyncMeshContainerPositionClientRpc(Vector3 syncPosition, Vector3 syncRotation)
	{
	}

	public void SyncMeshContainerPositionToClients()
	{
	}

	private bool AttemptPlaceWebTrap()
	{
		return false;
	}

	[ServerRpc]
	public void SpawnWebTrapServerRpc(Vector3 startPosition, Vector3 endPosition)
	{
	}

	[ClientRpc]
	public void SpawnWebTrapClientRpc(Vector3 startPosition, Vector3 endPosition)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void PlayerTripWebServerRpc(int trapID, int playerNum)
	{
	}

	[ClientRpc]
	public void PlayerTripWebClientRpc(int trapID, int playerNum)
	{
	}

	private void ChasePlayer(PlayerControllerB player)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void BreakWebServerRpc(int trapID, int playerWhoHit)
	{
	}

	[ClientRpc]
	public void BreakWebClientRpc(Vector3 webPosition, int trapID)
	{
	}

	private void RemoveWeb(int trapID)
	{
	}

	public void TriggerChaseWithPlayer(PlayerControllerB playerScript)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void PlayerLeaveWebServerRpc(int trapID, int playerNum)
	{
	}

	[ClientRpc]
	public void PlayerLeaveWebClientRpc(int trapID, int playerNum)
	{
	}

	public override void OnCollideWithPlayer(Collider other)
	{
	}

	public override void HitEnemy(int force = 1, PlayerControllerB playerWhoHit = null, bool playHitSFX = false)
	{
	}

	public override void KillEnemy(bool destroy = false)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void HitPlayerServerRpc(int playerId)
	{
	}

	[ClientRpc]
	public void HitPlayerClientRpc(int playerId)
	{
	}
}
