using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Netcode;
using UnityEngine;

public class ItemCharger : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CchargeItemDelayed_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemCharger _003C_003E4__this;

		public GrabbableObject itemToCharge;

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
		public _003CchargeItemDelayed_003Ed__7(int _003C_003E1__state)
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

	public InteractTrigger triggerScript;

	public Animator chargeStationAnimator;

	private Coroutine chargeItemCoroutine;

	public AudioSource zapAudio;

	private float updateInterval;

	public void ChargeItem()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CchargeItemDelayed_003Ed__7))]
	private IEnumerator chargeItemDelayed(GrabbableObject itemToCharge)
	{
		return null;
	}

	[ServerRpc(RequireOwnership = false)]
	public void PlayChargeItemEffectServerRpc(int playerChargingItem)
	{
	}

	[ClientRpc]
	public void PlayChargeItemEffectClientRpc(int playerChargingItem)
	{
	}
}
