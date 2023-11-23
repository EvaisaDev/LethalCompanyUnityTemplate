using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.VFX;

public class DocileLocustBeesAI : EnemyAI
{
	[CompilerGenerated]
	private sealed class _003CbugsLeave_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DocileLocustBeesAI _003C_003E4__this;

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
		public _003CbugsLeave_003Ed__8(int _003C_003E1__state)
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

	private int previousBehaviour;

	public AISearchRoutine bugsRoam;

	public VisualEffect bugsEffect;

	private float timeSinceReturning;

	public ScanNodeProperties scanNode;

	public override void DoAIInterval()
	{
	}

	public override void Update()
	{
	}

	public override void DaytimeEnemyLeave()
	{
	}

	[IteratorStateMachine(typeof(_003CbugsLeave_003Ed__8))]
	private IEnumerator bugsLeave()
	{
		return null;
	}
}
