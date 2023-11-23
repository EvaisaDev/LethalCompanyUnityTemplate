using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

public class ToggleFogTrigger : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CfadeOutFog_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ToggleFogTrigger _003C_003E4__this;

		private float _003Cfog1StartingValue_003E5__2;

		private float _003Cfog2StartingValue_003E5__3;

		private int _003Ci_003E5__4;

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
		public _003CfadeOutFog_003Ed__9(int _003C_003E1__state)
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

	public LocalVolumetricFog fog1;

	public float fog1EnabledAmount;

	public LocalVolumetricFog fog2;

	public float fog2EnabledAmount;

	private Coroutine fadeOutFogCoroutine;

	private bool fadingInFog;

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	[IteratorStateMachine(typeof(_003CfadeOutFog_003Ed__9))]
	private IEnumerator fadeOutFog()
	{
		return null;
	}
}
