using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ElevatorAnimationEvents : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CfadeAudioIn_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool fadeIn;

		public ElevatorAnimationEvents _003C_003E4__this;

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
		public _003CfadeAudioIn_003Ed__11(int _003C_003E1__state)
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

	public RoundManager roundManager;

	public AudioSource audioToPlay;

	public AudioSource audioToPlay2;

	private Coroutine fadeCoroutine;

	public void PlayAudio(AudioClip SFXclip)
	{
	}

	public void PlayAudio2(AudioClip SFXclip)
	{
	}

	public void PlayAudioOneshot(AudioClip SFXclip)
	{
	}

	public void PlayAudio2Oneshot(AudioClip SFXclip)
	{
	}

	public void StopAudio(AudioSource audio)
	{
	}

	public void FadeAudioOut(AudioSource audio)
	{
	}

	public void FadeAudioIn(AudioSource audio)
	{
	}

	[IteratorStateMachine(typeof(_003CfadeAudioIn_003Ed__11))]
	private IEnumerator fadeAudioIn(bool fadeIn)
	{
		return null;
	}

	public void LoadNewFloor()
	{
	}

	public void ElevatorFullyRunning()
	{
	}

	private void SetBodiesKinematic()
	{
	}

	public void ElevatorNoLongerRunning()
	{
	}
}
