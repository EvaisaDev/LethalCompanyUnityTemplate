using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class GiftBoxItem : GrabbableObject
{
	[CompilerGenerated]
	private sealed class _003CSetObjectToHitGroundSFX_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GrabbableObject gObject;

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
		public _003CSetObjectToHitGroundSFX_003Ed__12(int _003C_003E1__state)
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
	private sealed class _003CwaitForGiftPresentToSpawnOnClient_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NetworkObjectReference netObjectRef;

		public GiftBoxItem _003C_003E4__this;

		public int presentValue;

		public Vector3 startFallingPos;

		private NetworkObject _003CnetObject_003E5__2;

		private float _003CstartTime_003E5__3;

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
		public _003CwaitForGiftPresentToSpawnOnClient_003Ed__15(int _003C_003E1__state)
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

	private GameObject objectInPresent;

	public ParticleSystem PoofParticle;

	public AudioSource presentAudio;

	public AudioClip openGiftAudio;

	private PlayerControllerB previousPlayerHeldBy;

	private bool hasUsedGift;

	private int objectInPresentValue;

	public override void Start()
	{
	}

	public override void EquipItem()
	{
	}

	public override void ItemActivate(bool used, bool buttonDown = true)
	{
	}

	public override void PocketItem()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void OpenGiftBoxServerRpc()
	{
	}

	[IteratorStateMachine(typeof(_003CSetObjectToHitGroundSFX_003Ed__12))]
	private IEnumerator SetObjectToHitGroundSFX(GrabbableObject gObject)
	{
		return null;
	}

	[ClientRpc]
	public void OpenGiftBoxNoPresentClientRpc()
	{
	}

	[ClientRpc]
	public void OpenGiftBoxClientRpc(NetworkObjectReference netObjectRef, int presentValue, Vector3 startFallingPos)
	{
	}

	[IteratorStateMachine(typeof(_003CwaitForGiftPresentToSpawnOnClient_003Ed__15))]
	private IEnumerator waitForGiftPresentToSpawnOnClient(NetworkObjectReference netObjectRef, int presentValue, Vector3 startFallingPos)
	{
		return null;
	}
}
