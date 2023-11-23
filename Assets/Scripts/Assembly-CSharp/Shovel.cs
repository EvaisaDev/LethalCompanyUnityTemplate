using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class Shovel : GrabbableObject
{
	[CompilerGenerated]
	private sealed class _003CreelUpShovel_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Shovel _003C_003E4__this;

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
		public _003CreelUpShovel_003Ed__14(int _003C_003E1__state)
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

	public int shovelHitForce;

	public bool reelingUp;

	public bool isHoldingButton;

	private RaycastHit rayHit;

	private Coroutine reelingUpCoroutine;

	private RaycastHit[] objectsHitByShovel;

	private List<RaycastHit> objectsHitByShovelList;

	public AudioClip reelUp;

	public AudioClip swing;

	public AudioClip[] hitSFX;

	public AudioSource shovelAudio;

	private PlayerControllerB previousPlayerHeldBy;

	private int shovelMask;

	public override void ItemActivate(bool used, bool buttonDown = true)
	{
	}

	[IteratorStateMachine(typeof(_003CreelUpShovel_003Ed__14))]
	private IEnumerator reelUpShovel()
	{
		return null;
	}

	[ServerRpc]
	public void ReelUpSFXServerRpc()
	{
	}

	[ClientRpc]
	public void ReelUpSFXClientRpc()
	{
	}

	public override void DiscardItem()
	{
	}

	public void SwingShovel(bool cancel = false)
	{
	}

	public void HitShovel(bool cancel = false)
	{
	}

	[ServerRpc]
	public void HitShovelServerRpc(int hitSurfaceID)
	{
	}

	[ClientRpc]
	public void HitShovelClientRpc(int hitSurfaceID)
	{
	}

	private void HitSurfaceWithShovel(int hitSurfaceID)
	{
	}
}
