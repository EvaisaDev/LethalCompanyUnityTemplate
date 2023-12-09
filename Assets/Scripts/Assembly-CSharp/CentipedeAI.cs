using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class CentipedeAI : EnemyAI
{
	[CompilerGenerated]
	private sealed class _003CUnclingFromPlayer_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool playerDead;

		public CentipedeAI _003C_003E4__this;

		private Vector3 _003CgroundPosition_003E5__2;

		private Vector3 _003CstartPosition_003E5__3;

		private float _003CfallTime_003E5__4;

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
		public _003CUnclingFromPlayer_003Ed__51(int _003C_003E1__state)
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
	private sealed class _003CclingToCeiling_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CentipedeAI _003C_003E4__this;

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
		public _003CclingToCeiling_003Ed__59(int _003C_003E1__state)
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
	private sealed class _003CdelayedShriek_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CentipedeAI _003C_003E4__this;

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
		public _003CdelayedShriek_003Ed__69(int _003C_003E1__state)
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
	private sealed class _003CfallFromCeiling_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CentipedeAI _003C_003E4__this;

		private Vector3 _003CstartPosition_003E5__2;

		private Vector3 _003CgroundPosition_003E5__3;

		private float _003CfallTime_003E5__4;

		private float _003CdistToPlayer_003E5__5;

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
		public _003CfallFromCeiling_003Ed__57(int _003C_003E1__state)
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

	public PlayerControllerB clingingToPlayer;

	public AudioClip fallShriek;

	public AudioClip hitGroundSFX;

	public AudioClip hitCentipede;

	public AudioClip[] shriekClips;

	private int offsetNodeAmount;

	private Vector3 mainEntrancePosition;

	public AnimationCurve fallToGroundCurve;

	public Vector3 ceilingHidingPoint;

	private RaycastHit rayHit;

	public Transform tempTransform;

	private Ray ray;

	private bool clingingToCeiling;

	private Coroutine ceilingAnimationCoroutine;

	private bool startedCeilingAnimationCoroutine;

	private Coroutine killAnimationCoroutine;

	private Vector3 propelVelocity;

	private float damagePlayerInterval;

	private bool clingingToLocalClient;

	private bool clingingToDeadBody;

	private bool inDroppingOffPlayerAnim;

	private Vector3 firstKilledPlayerPosition;

	private bool pathToFirstKilledBodyIsClear;

	private bool syncedPositionInPrepForCeilingAnimation;

	public Transform modelContainer;

	private float updateOffsetPositionInterval;

	private Vector3 offsetTargetPos;

	private bool triggeredFall;

	public AudioSource clingingToPlayer2DAudio;

	public AudioClip clingToPlayer3D;

	private float chaseTimer;

	private float stuckTimer;

	private Coroutine beginClingingToCeilingCoroutine;

	private Coroutine dropFromCeilingCoroutine;

	private bool singlePlayerSecondChanceGiven;

	private bool choseHidingSpotNoPlayersNearby;

	public override void Start()
	{
	}

	public override void DoAIInterval()
	{
	}

	public void ChooseHidingSpotNearPlayer(Vector3 targetPos, bool targetingPositionOfFirstKilledPlayer = false)
	{
	}

	private void SetDestinationToNode(Transform moveTowardsNode)
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdatePositionToClingingPlayerHead()
	{
	}

	public override void Update()
	{
	}

	private void DamagePlayerOnIntervals()
	{
	}

	private void IncreaseSpeedSlowly(float increaseSpeed = 1.5f)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void StopClingingServerRpc(bool playerDead)
	{
	}

	[ClientRpc]
	public void StopClingingClientRpc(bool playerDead)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnPlayerTeleport(PlayerControllerB playerTeleported)
	{
	}

	private void StopClingingToPlayer(bool playerDead)
	{
	}

	[IteratorStateMachine(typeof(_003CUnclingFromPlayer_003Ed__51))]
	private IEnumerator UnclingFromPlayer(PlayerControllerB playerBeingKilled, bool playerDead = true)
	{
		return null;
	}

	public override void CancelSpecialAnimationWithPlayer()
	{
	}

	public override void OnCollideWithPlayer(Collider other)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void ClingToPlayerServerRpc(ulong playerObjectId)
	{
	}

	[ClientRpc]
	public void ClingToPlayerClientRpc(ulong playerObjectId)
	{
	}

	private void ClingToPlayer(PlayerControllerB playerScript)
	{
	}

	[IteratorStateMachine(typeof(_003CfallFromCeiling_003Ed__57))]
	private IEnumerator fallFromCeiling()
	{
		return null;
	}

	[ServerRpc(RequireOwnership = false)]
	public void TriggerCentipedeFallServerRpc(ulong clientId)
	{
	}

	[IteratorStateMachine(typeof(_003CclingToCeiling_003Ed__59))]
	private IEnumerator clingToCeiling()
	{
		return null;
	}

	private void RaycastToCeiling()
	{
	}

	[ServerRpc]
	public void SwitchToHidingOnCeilingServerRpc(Vector3 ceilingPoint)
	{
	}

	[ClientRpc]
	public void SwitchToHidingOnCeilingClientRpc(Vector3 ceilingPoint)
	{
	}

	public override void HitEnemy(int force = 1, PlayerControllerB playerWhoHit = null, bool playHitSFX = false)
	{
	}

	public override void SetEnemyStunned(bool setToStunned, float setToStunTime = 1f, PlayerControllerB setStunnedByPlayer = null)
	{
	}

	public void ReactBehaviourToBeingHurt()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void GetHitAndRunAwayServerRpc()
	{
	}

	[ClientRpc]
	public void GetHitAndRunAwayClientRpc()
	{
	}

	public override void KillEnemy(bool destroy = false)
	{
	}

	[IteratorStateMachine(typeof(_003CdelayedShriek_003Ed__69))]
	private IEnumerator delayedShriek()
	{
		return null;
	}
}
