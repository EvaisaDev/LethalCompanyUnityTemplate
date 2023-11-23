using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BoomboxItem : GrabbableObject
{
	[CompilerGenerated]
	private sealed class _003CmusicPitchDown_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BoomboxItem _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CmusicPitchDown_003Ed__12(int _003C_003E1__state)
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

	public AudioSource boomboxAudio;

	public AudioClip[] musicAudios;

	public AudioClip[] stopAudios;

	public System.Random musicRandomizer;

	private StartOfRound playersManager;

	private RoundManager roundManager;

	public bool isPlayingMusic;

	private float noiseInterval;

	private int timesPlayedWithoutTurningOff;

	public override void Start()
	{
	}

	public override void ItemActivate(bool used, bool buttonDown = true)
	{
	}

	private void StartMusic(bool startMusic, bool pitchDown = false)
	{
	}

	[IteratorStateMachine(typeof(_003CmusicPitchDown_003Ed__12))]
	private IEnumerator musicPitchDown()
	{
		return null;
	}

	public override void UseUpBatteries()
	{
	}

	public override void PocketItem()
	{
	}

	public override void Update()
	{
	}
}
