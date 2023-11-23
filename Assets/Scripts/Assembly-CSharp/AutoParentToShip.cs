using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Netcode;
using UnityEngine;

public class AutoParentToShip : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSuckObjectOutOfShip_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AutoParentToShip _003C_003E4__this;

		private Vector3 _003Cdir_003E5__2;

		private Quaternion _003CrandomRotation_003E5__3;

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
		public _003CSuckObjectOutOfShip_003Ed__9(int _003C_003E1__state)
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

	public bool disableObject;

	public Vector3 positionOffset;

	public Vector3 rotationOffset;

	[HideInInspector]
	public Vector3 startingPosition;

	[HideInInspector]
	public Vector3 startingRotation;

	public bool overrideOffset;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	public void StartSuckingOutOfShip()
	{
	}

	[IteratorStateMachine(typeof(_003CSuckObjectOutOfShip_003Ed__9))]
	private IEnumerator SuckObjectOutOfShip()
	{
		return null;
	}

	public void MoveToOffset()
	{
	}
}
