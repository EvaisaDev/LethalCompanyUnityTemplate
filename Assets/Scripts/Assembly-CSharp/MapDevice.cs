using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MapDevice : GrabbableObject
{
	[CompilerGenerated]
	private sealed class _003CpingMapSystem_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MapDevice _003C_003E4__this;

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
		public _003CpingMapSystem_003Ed__6(int _003C_003E1__state)
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

	public Camera mapCamera;

	public Animator mapAnimatorTransition;

	public Light mapLight;

	private Coroutine pingMapCoroutine;

	public override void Start()
	{
	}

	public override void ItemActivate(bool used, bool buttonDown = true)
	{
	}

	[IteratorStateMachine(typeof(_003CpingMapSystem_003Ed__6))]
	private IEnumerator pingMapSystem()
	{
		return null;
	}

	public override void DiscardItem()
	{
	}

	public override void EquipItem()
	{
	}
}
