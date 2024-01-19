using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class CrawlerAI : EnemyAI
{
	[CompilerGenerated]
	private sealed class _003CEatPlayerBodyAnimation_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int playerId;

		public CrawlerAI _003C_003E4__this;

		private DeadBodyInfo _003CdeadBody_003E5__2;

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
		public _003CEatPlayerBodyAnimation_003Ed__50(int _003C_003E1__state)
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

	public AISearchRoutine searchForPlayers;

	private float checkLineOfSightInterval;

	public float maxSearchAndRoamRadius;

	[Space(5f)]
	public float noticePlayerTimer;

	private bool hasEnteredChaseMode;

	private bool lostPlayerInChase;

	private bool beginningChasingThisClient;

	private Collider[] nearPlayerColliders;

	public AudioClip shortRoar;

	public AudioClip[] hitWallSFX;

	public AudioClip bitePlayerSFX;

	private Vector3 previousPosition;

	private float previousVelocity;

	private float averageVelocity;

	private float velocityInterval;

	private float velocityAverageCount;

	private float wallCollisionSFXDebounce;

	private float timeSinceHittingPlayer;

	private bool ateTargetPlayerBody;

	private Coroutine eatPlayerBodyCoroutine;

	public Transform mouthTarget;

	public AudioClip eatPlayerSFX;

	public AudioClip[] hitCrawlerSFX;

	public AudioClip[] longRoarSFX;

	public DeadBodyInfo currentlyHeldBody;

	private bool pullingSecondLimb;

	private float agentSpeedWithNegative;

	private Vector3 lastPositionOfSeenPlayer;

	[Space(5f)]
	public float BaseAcceleration;

	public float SpeedAccelerationEffect;

	public float SpeedIncreaseRate;

	private float lastTimeHit;

	public override void Start()
	{
	}

	public override void DoAIInterval()
	{
	}

	public override void FinishedCurrentSearchRoutine()
	{
	}

	public override void Update()
	{
	}

	private void CalculateAgentSpeed()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void CollideWithWallServerRpc()
	{
	}

	[ClientRpc]
	public void CollideWithWallClientRpc()
	{
	}

	private void CheckForVeryClosePlayer()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void BeginChasingPlayerServerRpc(int playerObjectId)
	{
	}

	[ClientRpc]
	public void BeginChasingPlayerClientRpc(int playerObjectId)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void MakeScreechNoiseServerRpc()
	{
	}

	[ClientRpc]
	public void MakeScreechNoiseClientRpc()
	{
	}

	private void MakeScreech()
	{
	}

	public override void OnCollideWithPlayer(Collider other)
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

	[ServerRpc(RequireOwnership = false)]
	public void EatPlayerBodyServerRpc(int playerId)
	{
	}

	[ClientRpc]
	public void EatPlayerBodyClientRpc(int playerId)
	{
	}

	[IteratorStateMachine(typeof(_003CEatPlayerBodyAnimation_003Ed__50))]
	private IEnumerator EatPlayerBodyAnimation(int playerId)
	{
		return null;
	}

	private void DropPlayerBody()
	{
	}

	public override void KillEnemy(bool destroy = false)
	{
	}

	public override void HitEnemy(int force = 1, PlayerControllerB playerWhoHit = null, bool playHitSFX = false)
	{
	}
}
