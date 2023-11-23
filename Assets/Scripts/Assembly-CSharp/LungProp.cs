using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LungProp : GrabbableObject
{
	[CompilerGenerated]
	private sealed class _003CDisconnectFromMachinery_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LungProp _003C_003E4__this;

		private GameObject _003CnewSparkParticle_003E5__2;

		private AudioSource _003CthisAudio_003E5__3;

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
		public _003CDisconnectFromMachinery_003Ed__13(int _003C_003E1__state)
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

	public bool isLungPowered;

	public bool isLungDocked;

	public bool isLungDockedInElevator;

	public RoundManager roundManager;

	public GameObject sparkParticle;

	private Coroutine disconnectAnimation;

	public AudioClip connectSFX;

	public AudioClip disconnectSFX;

	public AudioClip removeFromMachineSFX;

	public float lungDeviceLightIntensity;

	public MeshRenderer lungDeviceMesh;

	private Color emissiveColor;

	public override void EquipItem()
	{
	}

	[IteratorStateMachine(typeof(_003CDisconnectFromMachinery_003Ed__13))]
	private IEnumerator DisconnectFromMachinery()
	{
		return null;
	}

	public override void Start()
	{
	}
}
