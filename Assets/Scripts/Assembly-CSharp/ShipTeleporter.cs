using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class ShipTeleporter : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public int playerObj;

		public float startTime;

		internal bool _003CteleportBodyOut_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CbeamOutPlayer_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShipTeleporter _003C_003E4__this;

		private int _003Cb_003E5__2;

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
		public _003CbeamOutPlayer_003Ed__30(int _003C_003E1__state)
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
	private sealed class _003CbeamUpPlayer_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShipTeleporter _003C_003E4__this;

		private PlayerControllerB _003CplayerToBeamUp_003E5__2;

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
		public _003CbeamUpPlayer_003Ed__37(int _003C_003E1__state)
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
	private sealed class _003CteleportBodyOut_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int playerObj;

		private _003C_003Ec__DisplayClass36_0 _003C_003E8__1;

		public ShipTeleporter _003C_003E4__this;

		public Vector3 teleportPosition;

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
		public _003CteleportBodyOut_003Ed__36(int _003C_003E1__state)
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

	public bool isInverseTeleporter;

	public Transform teleportOutPosition;

	[Space(5f)]
	public Transform teleporterPosition;

	public Animator teleporterAnimator;

	public Animator buttonAnimator;

	public AudioSource buttonAudio;

	public AudioSource shipTeleporterAudio;

	public AudioClip buttonPressSFX;

	public AudioClip teleporterSpinSFX;

	public AudioClip teleporterBeamUpSFX;

	public AudioClip beamUpPlayerBodySFX;

	private Coroutine beamUpPlayerCoroutine;

	public int teleporterId;

	private int[] playersBeingTeleported;

	private float cooldownTime;

	public float cooldownAmount;

	public InteractTrigger buttonTrigger;

	public static bool hasBeenSpawnedThisSession;

	public static bool hasBeenSpawnedThisSessionInverse;

	private System.Random shipTeleporterSeed;

	public void SetRandomSeed()
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	public void PressTeleportButtonOnLocalClient()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void PressTeleportButtonServerRpc()
	{
	}

	[ClientRpc]
	public void PressTeleportButtonClientRpc()
	{
	}

	private void PressButtonEffects()
	{
	}

	private bool CanUseInverseTeleporter()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CbeamOutPlayer_003Ed__30))]
	private IEnumerator beamOutPlayer()
	{
		return null;
	}

	[ServerRpc(RequireOwnership = false)]
	public void TeleportPlayerOutServerRpc(int playerObj, Vector3 teleportPos)
	{
	}

	[ClientRpc]
	public void TeleportPlayerOutClientRpc(int playerObj, Vector3 teleportPos)
	{
	}

	private void TeleportPlayerOutWithInverseTeleporter(int playerObj, Vector3 teleportPos)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void TeleportPlayerBodyOutServerRpc(int playerObj, Vector3 teleportPos)
	{
	}

	[ClientRpc]
	public void TeleportPlayerBodyOutClientRpc(int playerObj, Vector3 teleportPos)
	{
	}

	[IteratorStateMachine(typeof(_003CteleportBodyOut_003Ed__36))]
	private IEnumerator teleportBodyOut(int playerObj, Vector3 teleportPosition)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CbeamUpPlayer_003Ed__37))]
	private IEnumerator beamUpPlayer()
	{
		return null;
	}

	private void SetPlayerTeleporterId(PlayerControllerB playerScript, int teleporterId)
	{
	}
}
