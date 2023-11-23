using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.AI;

public class DressGirlAI : EnemyAI
{
	[CompilerGenerated]
	private sealed class _003CdisappearOnDelay_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DressGirlAI _003C_003E4__this;

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
		public _003CdisappearOnDelay_003Ed__44(int _003C_003E1__state)
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
	private sealed class _003CsetSwitchingHauntingPlayer_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DressGirlAI _003C_003E4__this;

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
		public _003CsetSwitchingHauntingPlayer_003Ed__33(int _003C_003E1__state)
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

	public PlayerControllerB hauntingPlayer;

	public bool hauntingLocalPlayer;

	public float timer;

	public float hauntInterval;

	private bool couldNotStareLastAttempt;

	public float staringTimer;

	public bool staringInHaunt;

	private int timesSeenByPlayer;

	private int timesStared;

	private bool seenByPlayerThisTime;

	private bool playerApproachedThisTime;

	public bool disappearingFromStare;

	private bool disappearByVanishing;

	private bool choseDisappearingPosition;

	private int timesChased;

	private float chaseTimer;

	public GameObject[] outsideNodes;

	public NavMeshHit navHit;

	private Coroutine disappearOnDelayCoroutine;

	public Transform turnCompass;

	public AudioClip[] appearStaringSFX;

	public AudioClip skipWalkSFX;

	public AudioClip breathingSFX;

	public float SFXVolumeLerpTo;

	public AudioSource heartbeatMusic;

	private bool enemyMeshEnabled;

	private System.Random ghostGirlRandom;

	private bool initializedRandomSeed;

	private bool switchedHauntingPlayer;

	private Coroutine switchHauntedPlayerCoroutine;

	private int timesChoosingAPlayer;

	public override void Start()
	{
	}

	private void ChoosePlayerToHaunt()
	{
	}

	[IteratorStateMachine(typeof(_003CsetSwitchingHauntingPlayer_003Ed__33))]
	private IEnumerator setSwitchingHauntingPlayer()
	{
		return null;
	}

	[ClientRpc]
	private void ChooseNewHauntingPlayerClientRpc()
	{
	}

	public override void DoAIInterval()
	{
	}

	public override void Update()
	{
	}

	[ServerRpc]
	private void MessWithLightsServerRpc()
	{
	}

	[ClientRpc]
	private void MessWithLightsClientRpc()
	{
	}

	[ServerRpc]
	private void FlipLightsBreakerServerRpc()
	{
	}

	[ClientRpc]
	private void FlipLightsBreakerClientRpc()
	{
	}

	private void BeginChasing()
	{
	}

	private void StopChasing()
	{
	}

	private void TryTeleportingAroundPlayer()
	{
	}

	[IteratorStateMachine(typeof(_003CdisappearOnDelay_003Ed__44))]
	private IEnumerator disappearOnDelay()
	{
		return null;
	}

	private void DisappearDuringHaunt()
	{
	}

	private Vector3 FindPositionOutOfLOS()
	{
		return default(Vector3);
	}

	private Vector3 TryFindingHauntPosition(bool staringMode = true, bool mustBeInLOS = true)
	{
		return default(Vector3);
	}

	private void SetHauntStarePosition(Vector3 newPosition, float timeToStare = 15f)
	{
	}

	public override void OnCollideWithPlayer(Collider other)
	{
	}
}
