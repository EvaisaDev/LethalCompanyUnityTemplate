using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class InteractTrigger : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CisSpecialAnimationPlayingTimer_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int playerNum;

		public InteractTrigger _003C_003E4__this;

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
		public _003CisSpecialAnimationPlayingTimer_003Ed__65(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CladderClimbAnimation_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InteractTrigger _003C_003E4__this;

		public PlayerControllerB playerController;

		private float _003Ctimer_003E5__2;

		private int _003CfinishClimbingLadder_003E5__3;

		private float _003CshorterWaitTime_003E5__4;

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
		public _003CladderClimbAnimation_003Ed__57(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CspecialInteractAnimation_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InteractTrigger _003C_003E4__this;

		public PlayerControllerB playerController;

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
		public _003CspecialInteractAnimation_003Ed__61(int _003C_003E1__state)
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

	[Header("Aesthetics")]
	public Sprite hoverIcon;

	public string hoverTip;

	[Space(5f)]
	public Sprite disabledHoverIcon;

	public string disabledHoverTip;

	[Header("Interaction")]
	public bool interactable;

	public bool oneHandedItemAllowed;

	public bool twoHandedItemAllowed;

	[Space(5f)]
	public bool holdInteraction;

	public float timeToHold;

	public float timeToHoldSpeedMultiplier;

	public string holdTip;

	public bool isBeingHeldByPlayer;

	public InteractEventFloat holdingInteractEvent;

	private float timeHeld;

	private bool isHoldingThisFrame;

	[Space(5f)]
	public bool touchTrigger;

	public bool triggerOnce;

	private bool hasTriggered;

	[Header("Misc")]
	public bool interactCooldown;

	public float cooldownTime;

	[HideInInspector]
	public float currentCooldownValue;

	public bool disableTriggerMesh;

	[Space(5f)]
	public bool RandomChanceTrigger;

	public int randomChancePercentage;

	[Header("Events")]
	public InteractEvent onInteract;

	public InteractEvent onInteractEarly;

	public InteractEvent onStopInteract;

	public InteractEvent onCancelAnimation;

	[Header("Special Animation")]
	public bool specialCharacterAnimation;

	public bool stopAnimationManually;

	public string stopAnimationString;

	public bool hidePlayerItem;

	public bool isPlayingSpecialAnimation;

	public float animationWaitTime;

	public string animationString;

	[Space(5f)]
	public bool lockPlayerPosition;

	public Transform playerPositionNode;

	private Transform lockedPlayer;

	private bool usedByOtherClient;

	private StartOfRound playersManager;

	private float updateInterval;

	[Header("Ladders")]
	public bool isLadder;

	public Transform topOfLadderPosition;

	public bool useRaycastToGetTopPosition;

	public Transform bottomOfLadderPosition;

	public Transform ladderHorizontalPosition;

	[Space(5f)]
	public Transform ladderPlayerPositionNode;

	public bool usingLadder;

	private bool atBottomOfLadder;

	private Vector3 moveVelocity;

	private PlayerControllerB playerScriptInSpecialAnimation;

	private Coroutine useLadderCoroutine;

	private int playerUsingId;

	public void StopInteraction()
	{
	}

	public void HoldInteractNotFilled()
	{
	}

	public void Interact(Transform playerTransform)
	{
	}

	private bool LadderPositionObstructed(PlayerControllerB playerController)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CladderClimbAnimation_003Ed__57))]
	private IEnumerator ladderClimbAnimation(PlayerControllerB playerController)
	{
		return null;
	}

	public void CancelAnimationExternally()
	{
	}

	public void CancelLadderAnimation()
	{
	}

	private void SetUsingLadderOnLocalClient(bool isUsing)
	{
	}

	[IteratorStateMachine(typeof(_003CspecialInteractAnimation_003Ed__61))]
	private IEnumerator specialInteractAnimation(PlayerControllerB playerController)
	{
		return null;
	}

	public void StopSpecialAnimation()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void UpdateUsedByPlayerServerRpc(int playerNum)
	{
	}

	[ClientRpc]
	private void UpdateUsedByPlayerClientRpc(int playerNum)
	{
	}

	[IteratorStateMachine(typeof(_003CisSpecialAnimationPlayingTimer_003Ed__65))]
	private IEnumerator isSpecialAnimationPlayingTimer(int playerNum)
	{
		return null;
	}

	[ServerRpc(RequireOwnership = false)]
	private void StopUsingServerRpc(int playerUsing)
	{
	}

	[ClientRpc]
	private void StopUsingClientRpc(int playerUsing)
	{
	}

	public void SetInteractTriggerNotInAnimation(int playerUsing = -1)
	{
	}

	private void LateUpdate()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void Start()
	{
	}

	public void SetInteractionToHold(bool mustHold)
	{
	}

	public void SetInteractionToHoldOpposite(bool mustHold)
	{
	}

	public void SetRandomTimeToHold(float min, float max)
	{
	}
}
