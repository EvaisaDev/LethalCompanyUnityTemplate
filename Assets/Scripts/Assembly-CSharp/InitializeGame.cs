using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class InitializeGame : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSendToNextScene_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InitializeGame _003C_003E4__this;

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
		public _003CSendToNextScene_003Ed__10(int _003C_003E1__state)
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

	public bool runBootUpScreen;

	public Animator bootUpAnimation;

	public AudioSource bootUpAudio;

	public PlayerActions playerActions;

	private bool canSkip;

	private bool hasSkipped;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Awake()
	{
	}

	public void OpenMenu_performed(InputAction.CallbackContext context)
	{
	}

	[IteratorStateMachine(typeof(_003CSendToNextScene_003Ed__10))]
	private IEnumerator SendToNextScene()
	{
		return null;
	}

	private void Start()
	{
	}
}
