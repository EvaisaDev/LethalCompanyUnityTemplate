using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class NutcrackerEnemyAI : EnemyAI
{
	[CompilerGenerated]
	private sealed class _003CAimGun_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NutcrackerEnemyAI _003C_003E4__this;

		public Vector3 enemyPos;

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
		public _003CAimGun_003Ed__76(int _003C_003E1__state)
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
	private sealed class _003CInspectionTurn_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NutcrackerEnemyAI _003C_003E4__this;

		private int _003Cdegrees_003E5__2;

		private int _003CturnTime_003E5__3;

		private int _003Ci_003E5__4;

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
		public _003CInspectionTurn_003Ed__64(int _003C_003E1__state)
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
	private sealed class _003CReloadGun_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NutcrackerEnemyAI _003C_003E4__this;

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
		public _003CReloadGun_003Ed__72(int _003C_003E1__state)
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
	private sealed class _003CspawnShotgunShellsOnDelay_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NutcrackerEnemyAI _003C_003E4__this;

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
		public _003CspawnShotgunShellsOnDelay_003Ed__93(int _003C_003E1__state)
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
	private sealed class _003CwaitToFireGun_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NutcrackerEnemyAI _003C_003E4__this;

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
		public _003CwaitToFireGun_003Ed__79(int _003C_003E1__state)
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

	private int previousBehaviourState;

	private int previousBehaviourStateAIInterval;

	public static float timeAtNextInspection;

	private bool inspectingLocalPlayer;

	private float localPlayerTurnDistance;

	private bool isInspecting;

	private bool hasGun;

	private int randomSeedNumber;

	public GameObject gunPrefab;

	public ShotgunItem gun;

	public Transform gunPoint;

	private NetworkObjectReference gunObjectRef;

	public AISearchRoutine patrol;

	public AISearchRoutine attackSearch;

	public Transform torsoContainer;

	public float currentTorsoRotation;

	public int targetTorsoDegrees;

	public float torsoTurnSpeed;

	public AudioSource torsoTurnAudio;

	public AudioSource longRangeAudio;

	public AudioClip[] torsoFinishTurningClips;

	public AudioClip aimSFX;

	public AudioClip kickSFX;

	public GameObject shotgunShellPrefab;

	private bool torsoTurning;

	private System.Random NutcrackerRandom;

	private int timesDoingInspection;

	private Coroutine inspectionCoroutine;

	public int lastPlayerSeenMoving;

	private float timeSinceSeeingTarget;

	private float timeSinceInspecting;

	private float timeSinceFiringGun;

	private bool aimingGun;

	private bool reloadingGun;

	private Vector3 lastSeenPlayerPos;

	private RaycastHit rayHit;

	private Coroutine gunCoroutine;

	private bool isLeaderScript;

	private Vector3 positionLastCheck;

	private Vector3 strafePosition;

	private bool reachedStrafePosition;

	private bool lostPlayerInChase;

	private float timeSinceHittingPlayer;

	private Coroutine waitToFireGunCoroutine;

	private float walkCheckInterval;

	private int setShotgunScrapValue;

	private int timesSeeingSamePlayer;

	private int previousPlayerSeenWhenAiming;

	private float speedWhileAiming;

	public override void Start()
	{
	}

	[ServerRpc]
	public void InitializeNutcrackerValuesServerRpc()
	{
	}

	[ClientRpc]
	public void InitializeNutcrackerValuesClientRpc(int randomSeed, NetworkObjectReference gunObject, int setShotgunValue)
	{
	}

	private void GrabGun(GameObject gunObject)
	{
	}

	private void DropGun(Vector3 dropPosition)
	{
	}

	private void SpawnShotgunShells()
	{
	}

	[ServerRpc]
	public void DropGunServerRpc(Vector3 dropPosition)
	{
	}

	[ClientRpc]
	public void DropGunClientRpc(Vector3 dropPosition)
	{
	}

	public override void DoAIInterval()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SetLostPlayerInChaseServerRpc(bool lostPlayer)
	{
	}

	[ClientRpc]
	public void SetLostPlayerInChaseClientRpc(bool lostPlayer)
	{
	}

	private bool GrabGunIfNotHolding()
	{
		return false;
	}

	public void TurnTorsoToTargetDegrees()
	{
	}

	private void SetTargetDegreesToPosition(Vector3 pos)
	{
	}

	private void StartInspectionTurn()
	{
	}

	[IteratorStateMachine(typeof(_003CInspectionTurn_003Ed__64))]
	private IEnumerator InspectionTurn()
	{
		return null;
	}

	public void StopInspection()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SeeMovingThreatServerRpc(int playerId, bool enterAttackFromPatrolMode = false)
	{
	}

	[ClientRpc]
	public void SeeMovingThreatClientRpc(int playerId, bool enterAttackFromPatrolMode = false)
	{
	}

	private void GlobalNutcrackerClock()
	{
	}

	public override void Update()
	{
	}

	[ServerRpc]
	public void ReloadGunServerRpc()
	{
	}

	[ClientRpc]
	public void ReloadGunClientRpc()
	{
	}

	[IteratorStateMachine(typeof(_003CReloadGun_003Ed__72))]
	private IEnumerator ReloadGun()
	{
		return null;
	}

	private void StopReloading()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void AimGunServerRpc(Vector3 enemyPos)
	{
	}

	[ClientRpc]
	public void AimGunClientRpc(Vector3 enemyPos)
	{
	}

	[IteratorStateMachine(typeof(_003CAimGun_003Ed__76))]
	private IEnumerator AimGun(Vector3 enemyPos)
	{
		return null;
	}

	[ServerRpc]
	public void FireGunServerRpc()
	{
	}

	[ClientRpc]
	public void FireGunClientRpc()
	{
	}

	[IteratorStateMachine(typeof(_003CwaitToFireGun_003Ed__79))]
	private IEnumerator waitToFireGun()
	{
		return null;
	}

	private void StopAimingGun()
	{
	}

	private void FireGun(Vector3 gunPosition, Vector3 gunForward)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SwitchTargetServerRpc(int playerId)
	{
	}

	[ClientRpc]
	public void SwitchTargetClientRpc(int playerId)
	{
	}

	private void SwitchTargetToPlayer(int playerId)
	{
	}

	public bool CheckLineOfSightForLocalPlayer(float width = 45f, int range = 60, int proximityAwareness = -1)
	{
		return false;
	}

	private bool IsLocalPlayerMoving()
	{
		return false;
	}

	public override void OnCollideWithPlayer(Collider other)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void LegKickPlayerServerRpc(int playerId)
	{
	}

	[ClientRpc]
	public void LegKickPlayerClientRpc(int playerId)
	{
	}

	private void LegKickPlayer(int playerId)
	{
	}

	public override void HitEnemy(int force = 1, PlayerControllerB playerWhoHit = null, bool playHitSFX = false)
	{
	}

	public override void KillEnemy(bool destroy = false)
	{
	}

	[IteratorStateMachine(typeof(_003CspawnShotgunShellsOnDelay_003Ed__93))]
	private IEnumerator spawnShotgunShellsOnDelay()
	{
		return null;
	}
}
