using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class JesterAI : EnemyAI
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public PlayerControllerB playerScript;

		public float startTime;

		internal bool _003CkillPlayerAnimation_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CkillPlayerAnimation_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public JesterAI _003C_003E4__this;

		public int playerId;

		private _003C_003Ec__DisplayClass29_0 _003C_003E8__1;

		private DeadBodyInfo _003Cbody_003E5__2;

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
		public _003CkillPlayerAnimation_003Ed__29(int _003C_003E1__state)
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

	public AudioSource farAudio;

	public AISearchRoutine roamMap;

	private Vector3 spawnPosition;

	public float popUpTimer;

	public float beginCrankingTimer;

	private int previousState;

	public AudioClip popGoesTheWeaselTheme;

	public AudioClip popUpSFX;

	public AudioClip screamingSFX;

	public AudioClip killPlayerSFX;

	private Vector3 previousPosition;

	public float maxAnimSpeed;

	private float noPlayersToChaseTimer;

	private bool targetingPlayer;

	public Transform headRigTarget;

	public Transform lookForwardTarget;

	public Collider mainCollider;

	private bool inKillAnimation;

	private Coroutine killPlayerAnimCoroutine;

	public Transform grabBodyPoint;

	public override void Start()
	{
	}

	public override void DoAIInterval()
	{
	}

	private void CalculateAnimationSpeed(float maxSpeed = 1f)
	{
	}

	private void SetJesterInitialValues()
	{
	}

	public override void Update()
	{
	}

	public override void OnCollideWithPlayer(Collider other)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void KillPlayerServerRpc(int playerId)
	{
	}

	[ClientRpc]
	public void CancelKillPlayerClientRpc()
	{
	}

	[ClientRpc]
	public void KillPlayerClientRpc(int playerId)
	{
	}

	[IteratorStateMachine(typeof(_003CkillPlayerAnimation_003Ed__29))]
	private IEnumerator killPlayerAnimation(int playerId)
	{
		return null;
	}
}
