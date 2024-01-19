using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class Landmine : NetworkBehaviour, IHittable
{
	[CompilerGenerated]
	private sealed class _003CStartIdleAnimation_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Landmine _003C_003E4__this;

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
		public _003CStartIdleAnimation_003Ed__22(int _003C_003E1__state)
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
	private sealed class _003CTriggerOtherMineDelayed_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Landmine mine;

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
		public _003CTriggerOtherMineDelayed_003Ed__31(int _003C_003E1__state)
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

	private bool mineActivated;

	public bool hasExploded;

	public ParticleSystem explosionParticle;

	public Animator mineAnimator;

	public AudioSource mineAudio;

	public AudioSource mineFarAudio;

	public AudioClip mineDetonate;

	public AudioClip mineTrigger;

	public AudioClip mineDetonateFar;

	public AudioClip mineDeactivate;

	public AudioClip minePress;

	private bool sendingExplosionRPC;

	private RaycastHit hit;

	private RoundManager roundManager;

	private float pressMineDebounceTimer;

	private bool localPlayerOnMine;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ToggleMine(bool enabled)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void ToggleMineServerRpc(bool enable)
	{
	}

	[ClientRpc]
	public void ToggleMineClientRpc(bool enable)
	{
	}

	public void ToggleMineEnabledLocalClient(bool enabled)
	{
	}

	[IteratorStateMachine(typeof(_003CStartIdleAnimation_003Ed__22))]
	private IEnumerator StartIdleAnimation()
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void PressMineServerRpc()
	{
	}

	[ClientRpc]
	public void PressMineClientRpc()
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void TriggerMineOnLocalClientByExiting()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void ExplodeMineServerRpc()
	{
	}

	[ClientRpc]
	public void ExplodeMineClientRpc()
	{
	}

	public void SetOffMineAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CTriggerOtherMineDelayed_003Ed__31))]
	private IEnumerator TriggerOtherMineDelayed(Landmine mine)
	{
		return null;
	}

	public void Detonate()
	{
	}

	public static void SpawnExplosion(Vector3 explosionPosition, bool spawnExplosionEffect = false, float killRange = 1f, float damageRange = 1f)
	{
	}

	public bool MineHasLineOfSight(Vector3 pos)
	{
		return false;
	}

	bool IHittable.Hit(int force, Vector3 hitDirection, PlayerControllerB playerWhoHit = null, bool playHitSFX = false)
	{
		return false;
	}
}
