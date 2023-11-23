using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class TerminalAccessibleObject : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CcountCodeAccessCooldown_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TerminalAccessibleObject _003C_003E4__this;

		private Image _003CcooldownBar_003E5__2;

		private int _003CframeNum_003E5__3;

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
		public _003CcountCodeAccessCooldown_003Ed__20(int _003C_003E1__state)
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

	public string objectCode;

	public float codeAccessCooldownTimer;

	private float currentCooldownTimer;

	private bool inCooldown;

	public InteractEvent terminalCodeEvent;

	public InteractEvent terminalCodeCooldownEvent;

	public bool setCodeRandomlyFromRoundManager;

	[Space(3f)]
	public MeshRenderer[] codeMaterials;

	public int rows;

	public int columns;

	[Space(3f)]
	public bool isBigDoor;

	private TextMeshProUGUI mapRadarText;

	private Image mapRadarBox;

	private Image mapRadarBoxSlider;

	private bool initializedValues;

	private bool playerHitDoorTrigger;

	private bool isDoorOpen;

	private bool isPoweredOn;

	public void CallFunctionFromTerminal()
	{
	}

	public void TerminalCodeCooldownReached()
	{
	}

	[IteratorStateMachine(typeof(_003CcountCodeAccessCooldown_003Ed__20))]
	private IEnumerator countCodeAccessCooldown()
	{
		return null;
	}

	public void OnPowerSwitch(bool switchedOn)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SetDoorOpenServerRpc(bool open)
	{
	}

	[ClientRpc]
	public void SetDoorOpenClientRpc(bool open)
	{
	}

	public void SetDoorToggleLocalClient()
	{
	}

	public void SetDoorLocalClient(bool open)
	{
	}

	public void SetDoorOpen(bool open)
	{
	}

	public void SetCodeTo(int codeIndex)
	{
	}

	private void Start()
	{
	}

	public void InitializeValues()
	{
	}

	public override void OnDestroy()
	{
	}

	private void SetMaterialUV(int codeIndex)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
