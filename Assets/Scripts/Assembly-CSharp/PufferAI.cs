using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class PufferAI : EnemyAI
{
	[CompilerGenerated]
	private sealed class _003CshakeTailAnimation_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PufferAI _003C_003E4__this;

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
		public _003CshakeTailAnimation_003Ed__45(int _003C_003E1__state)
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
	private sealed class _003CstompAnimation_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PufferAI _003C_003E4__this;

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
		public _003CstompAnimation_003Ed__44(int _003C_003E1__state)
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

	private PlayerControllerB closestSeenPlayer;

	public AISearchRoutine roamMap;

	private float avoidPlayersTimer;

	private float fearTimer;

	private int previousBehaviourState;

	public Transform lookAtPlayersCompass;

	private Coroutine shakeTailCoroutine;

	private bool inPuffingAnimation;

	private Vector3 agentLocalVelocity;

	private Vector3 previousPosition;

	public Transform animationContainer;

	private float velX;

	private float velZ;

	private float unclampedSpeed;

	private Vector3 lookAtNoise;

	private float timeSinceLookingAtNoise;

	private bool playerIsInLOS;

	private bool didStompAnimation;

	private bool inStompingAnimation;

	public AudioClip[] footstepsSFX;

	public AudioClip[] frightenSFX;

	public AudioClip stomp;

	public AudioClip angry;

	public AudioClip puff;

	public AudioClip nervousMumbling;

	public AudioClip rattleTail;

	public AudioClip bitePlayerSFX;

	[Space(5f)]
	public Transform tailPosition;

	public GameObject smokePrefab;

	private bool startedMovingAfterAlert;

	private float timeSinceAlert;

	private bool didPuffAnimation;

	private float timeSinceHittingPlayer;

	public override void Start()
	{
	}

	public override void DoAIInterval()
	{
	}

	private void LookAtPosition(Vector3 look, bool lookInstantly = false)
	{
	}

	private void CalculateAnimationDirection(float maxSpeed = 1.7f)
	{
	}

	public void AvoidClosestPlayer()
	{
	}

	public override void DetectNoise(Vector3 noisePosition, float noiseLoudness, int timesPlayedInOneSpot = 0, int noiseID = 0)
	{
	}

	public override void Update()
	{
	}

	[ServerRpc]
	public void StompServerRpc()
	{
	}

	[ClientRpc]
	public void StompClientRpc()
	{
	}

	[ServerRpc]
	public void ShakeTailServerRpc()
	{
	}

	[ClientRpc]
	public void ShakeTailClientRpc()
	{
	}

	[IteratorStateMachine(typeof(_003CstompAnimation_003Ed__44))]
	private IEnumerator stompAnimation()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CshakeTailAnimation_003Ed__45))]
	private IEnumerator shakeTailAnimation()
	{
		return null;
	}

	public override void OnCollideWithPlayer(Collider other)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void BitePlayerServerRpc(int playerBit)
	{
	}

	[ClientRpc]
	public void BitePlayerClientRpc(int playerBit)
	{
	}

	public override void KillEnemy(bool destroy = false)
	{
	}
}
