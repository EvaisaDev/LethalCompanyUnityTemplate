using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class TetraChemicalItem : GrabbableObject
{
	[CompilerGenerated]
	private sealed class _003CUseTZPAnimation_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TetraChemicalItem _003C_003E4__this;

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
		public _003CUseTZPAnimation_003Ed__13(int _003C_003E1__state)
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

	private PlayerControllerB previousPlayerHeldBy;

	private Coroutine useTZPCoroutine;

	private bool emittingGas;

	private float fuel;

	public AudioSource localHelmetSFX;

	public AudioSource thisAudioSource;

	public AudioClip twistCanSFX;

	public AudioClip releaseGasSFX;

	public AudioClip holdCanSFX;

	public AudioClip removeCanSFX;

	public AudioClip outOfGasSFX;

	private bool triedUsingWithoutFuel;

	public override void ItemActivate(bool used, bool buttonDown = true)
	{
	}

	[IteratorStateMachine(typeof(_003CUseTZPAnimation_003Ed__13))]
	private IEnumerator UseTZPAnimation()
	{
		return null;
	}

	public override void Update()
	{
	}

	public override void EquipItem()
	{
	}

	[ServerRpc]
	public void RunOutOfFuelServerRpc()
	{
	}

	[ClientRpc]
	public void RunOutOfFuelClientRpc()
	{
	}

	public override void DiscardItem()
	{
	}
}
