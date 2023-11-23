using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	[RequireComponent(typeof(AudioSource))]
	public class LightningWhipScript : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CWhipForward_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LightningWhipScript _003C_003E4__this;

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
			public _003CWhipForward_003Ed__10(int _003C_003E1__state)
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

		public AudioClip WhipCrack;

		public AudioClip WhipCrackThunder;

		private AudioSource audioSource;

		private GameObject whipStart;

		private GameObject whipEndStrike;

		private GameObject whipHandle;

		private GameObject whipSpring;

		private Vector2 prevDrag;

		private bool dragging;

		private bool canWhip;

		[IteratorStateMachine(typeof(_003CWhipForward_003Ed__10))]
		private IEnumerator WhipForward()
		{
			return null;
		}

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
