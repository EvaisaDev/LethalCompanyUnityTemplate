using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ExtensionLadderItem : GrabbableObject
{
	[CompilerGenerated]
	private sealed class _003CLadderAnimation_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ExtensionLadderItem _003C_003E4__this;

		private float _003CladderExtendAmountNormalized_003E5__2;

		private float _003CladderRotateAmountNormalized_003E5__3;

		private float _003CcurrentNormalizedTime_003E5__4;

		private float _003CspeedMultiplier_003E5__5;

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
		public _003CLadderAnimation_003Ed__30(int _003C_003E1__state)
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

	private bool ladderActivated;

	private bool ladderAnimationBegun;

	private Coroutine ladderAnimationCoroutine;

	public Animator ladderAnimator;

	public Animator ladderRotateAnimator;

	public Transform baseNode;

	public Transform topNode;

	public Transform moveableNode;

	private RaycastHit hit;

	private int layerMask;

	public AudioClip hitRoof;

	public AudioClip fullExtend;

	public AudioClip hitWall;

	public AudioClip ladderExtendSFX;

	public AudioClip ladderFallSFX;

	public AudioClip ladderShrinkSFX;

	public AudioClip blinkWarningSFX;

	public AudioClip lidOpenSFX;

	public AudioSource ladderAudio;

	public InteractTrigger ladderScript;

	private float rotateAmount;

	private float extendAmount;

	private float ladderTimer;

	private bool ladderBlinkWarning;

	private bool ladderShrunkAutomatically;

	public Collider interactCollider;

	public Collider bridgeCollider;

	public Collider killTrigger;

	public override void Update()
	{
	}

	private void StartLadderAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CLadderAnimation_003Ed__30))]
	private IEnumerator LadderAnimation()
	{
		return null;
	}

	private float GetLadderExtensionDistance()
	{
		return 0f;
	}

	private float GetLadderRotationDegrees(float topOfLadder)
	{
		return 0f;
	}

	public override void DiscardItem()
	{
	}

	public override void EquipItem()
	{
	}

	public override void DiscardItemFromEnemy()
	{
	}

	public override void ItemActivate(bool used, bool buttonDown = true)
	{
	}
}
