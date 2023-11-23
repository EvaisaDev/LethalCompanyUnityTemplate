using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningWhipSpell : LightningSpellScript
	{
		[CompilerGenerated]
		private sealed class _003CWhipForward_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LightningWhipSpell _003C_003E4__this;

			private Vector3 _003CwhipPositionForwards_003E5__2;

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
			public _003CWhipForward_003Ed__7(int _003C_003E1__state)
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

		[Header("Whip")]
		[Tooltip("Attach the whip to what object")]
		public GameObject AttachTo;

		[Tooltip("Rotate the whip with this object")]
		public GameObject RotateWith;

		[Tooltip("Whip handle")]
		public GameObject WhipHandle;

		[Tooltip("Whip start")]
		public GameObject WhipStart;

		[Tooltip("Whip spring")]
		public GameObject WhipSpring;

		[Tooltip("Whip crack audio source")]
		public AudioSource WhipCrackAudioSource;

		[HideInInspector]
		public Action<Vector3> CollisionCallback;

		[IteratorStateMachine(typeof(_003CWhipForward_003Ed__7))]
		private IEnumerator WhipForward()
		{
			return null;
		}

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		protected override void OnCastSpell()
		{
		}

		protected override void OnStopSpell()
		{
		}

		protected override void OnActivated()
		{
		}

		protected override void OnDeactivated()
		{
		}
	}
}
