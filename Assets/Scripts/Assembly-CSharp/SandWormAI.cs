using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.AI;

public class SandWormAI : EnemyAI
{
	[CompilerGenerated]
	private sealed class _003CEmergeFromGround_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SandWormAI _003C_003E4__this;

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
		public _003CEmergeFromGround_003Ed__28(int _003C_003E1__state)
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

	public AudioSource groundAudio;

	public ParticleSystem emergeFromGroundParticle1;

	public ParticleSystem emergeFromGroundParticle2;

	public ParticleSystem hitGroundParticle;

	public AudioClip[] groundRumbleSFX;

	public AudioClip[] ambientRumbleSFX;

	public AudioClip hitGroundSFX;

	public AudioClip emergeFromGroundSFX;

	public AudioClip[] roarSFX;

	public bool inEmergingState;

	public bool emerged;

	private int timesEmerging;

	public bool hitGroundInAnimation;

	public Transform endingPosition;

	public Transform[] airPathNodes;

	public Vector3 endOfFlightPathPosition;

	private Coroutine emergingFromGroundCoroutine;

	public AISearchRoutine roamMap;

	public float chaseTimer;

	private int stateLastFrame;

	private NavMeshHit navHit;

	private System.Random sandWormRandom;

	public override void Start()
	{
	}

	public override void DoAIInterval()
	{
	}

	public override void Update()
	{
	}

	public void StartEmergeAnimation()
	{
	}

	[ServerRpc]
	public void EmergeServerRpc(int yRot)
	{
	}

	[ClientRpc]
	public void EmergeClientRpc(int yRot)
	{
	}

	[IteratorStateMachine(typeof(_003CEmergeFromGround_003Ed__28))]
	private IEnumerator EmergeFromGround(int rot)
	{
		return null;
	}

	private void ShakePlayerCameraInProximity(Vector3 pos)
	{
	}

	public void HitGroundInAnimation()
	{
	}

	public void SetInGround()
	{
	}

	public override void OnCollideWithPlayer(Collider other)
	{
	}

	public void EatPlayer(PlayerControllerB playerScript)
	{
	}

	public override void OnCollideWithEnemy(Collider other, EnemyAI enemyScript = null)
	{
	}
}
