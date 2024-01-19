using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class FlowermanAI : EnemyAI
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public FlowermanAI _003C_003E4__this;

		public float startTime;

		internal bool _003CkillAnimation_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CkillAnimation_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FlowermanAI _003C_003E4__this;

		private _003C_003Ec__DisplayClass53_0 _003C_003E8__1;

		private Vector3 _003CendPosition_003E5__2;

		private Vector3 _003CstartingPosition_003E5__3;

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
		public _003CkillAnimation_003Ed__53(int _003C_003E1__state)
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

	private bool evadeModeStareDown;

	private bool stopTurningTowardsPlayers;

	public float evadeStealthTimer;

	private int stareDownChanceIncrease;

	public PlayerControllerB lookAtPlayer;

	private Transform localPlayerCamera;

	private RaycastHit rayHit;

	private Ray playerRay;

	public Transform turnCompass;

	private int roomAndEnemiesMask;

	private Vector3 agentLocalVelocity;

	public Collider thisEnemyCollider;

	private Vector3 previousPosition;

	private float velX;

	private float velZ;

	[Header("Kill animation")]
	public bool inKillAnimation;

	private Coroutine killAnimationCoroutine;

	public bool carryingPlayerBody;

	public DeadBodyInfo bodyBeingCarried;

	public Transform rightHandGrip;

	public Transform animationContainer;

	private bool wasInEvadeMode;

	public List<Transform> ignoredNodes;

	private Vector3 mainEntrancePosition;

	[Header("Anger phase")]
	public float angerMeter;

	public float angerCheckInterval;

	public bool isInAngerMode;

	public AudioSource creatureAngerVoice;

	public AudioSource crackNeckAudio;

	public AudioClip crackNeckSFX;

	public int timesThreatened;

	private Vector3 waitAroundEntrancePosition;

	private int timesFoundSneaking;

	private bool stunnedByPlayerLastFrame;

	private bool startingKillAnimationLocalClient;

	private float getPathToFavoriteNodeInterval;

	public override void Start()
	{
	}

	public override void DoAIInterval()
	{
	}

	public void AvoidClosestPlayer()
	{
	}

	public void AddToAngerMeter(float amountToAdd)
	{
	}

	[ServerRpc]
	public void EnterAngerModeServerRpc(float angerTime)
	{
	}

	[ClientRpc]
	public void EnterAngerModeClientRpc(float angerTime)
	{
	}

	public void ChooseClosestNodeToPlayer()
	{
	}

	public override void Update()
	{
	}

	[ServerRpc]
	public void DropPlayerBodyServerRpc()
	{
	}

	[ClientRpc]
	public void DropPlayerBodyClientRpc()
	{
	}

	private void DropPlayerBody()
	{
	}

	private void LookAtPlayerOfInterest()
	{
	}

	private void CalculateAnimationDirection(float maxSpeed = 1f)
	{
	}

	public override void OnCollideWithPlayer(Collider other)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void KillPlayerAnimationServerRpc(int playerObjectId)
	{
	}

	[ClientRpc]
	public void CancelKillAnimationClientRpc(int playerObjectId)
	{
	}

	[ClientRpc]
	public void KillPlayerAnimationClientRpc(int playerObjectId)
	{
	}

	[IteratorStateMachine(typeof(_003CkillAnimation_003Ed__53))]
	private IEnumerator killAnimation()
	{
		return null;
	}

	public void FinishKillAnimation(bool carryingBody = true)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void ResetFlowermanStealthTimerServerRpc(int playerObj)
	{
	}

	[ClientRpc]
	public void ResetFlowermanStealthClientRpc(int playerObj)
	{
	}

	public void LookAtFlowermanTrigger(int playerObj)
	{
	}

	public override void KillEnemy(bool destroy = false)
	{
	}

	public override void HitEnemy(int force = 1, PlayerControllerB playerWhoHit = null, bool playHitSFX = false)
	{
	}
}
