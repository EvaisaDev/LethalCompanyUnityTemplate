using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class HauntedMaskItem : GrabbableObject, IVisibleThreat
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public float startTime;

		public NetworkObjectReference netObjectRef;

		public NetworkObject netObject;

		public HauntedMaskItem _003C_003E4__this;

		internal bool _003CwaitForMimicEnemySpawn_003Eb__0()
		{
			return false;
		}

		internal bool _003CwaitForMimicEnemySpawn_003Eb__1()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CwaitForMimicEnemySpawn_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NetworkObjectReference netObjectRef;

		public HauntedMaskItem _003C_003E4__this;

		private _003C_003Ec__DisplayClass41_0 _003C_003E8__1;

		public bool inFactory;

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
		public _003CwaitForMimicEnemySpawn_003Ed__41(int _003C_003E1__state)
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

	private bool maskOn;

	private bool attaching;

	private bool clampedToHead;

	private float lastIntervalCheck;

	private float attachTimer;

	private bool finishedAttaching;

	public AudioSource maskAudio;

	public AudioClip maskAttachAudio;

	public AudioClip maskAttachAudioLocal;

	public Animator maskAnimator;

	public MeshRenderer maskEyesFilled;

	public GameObject headMaskPrefab;

	public Transform currentHeadMask;

	public Vector3 headPositionOffset;

	public Vector3 headRotationOffset;

	private PlayerControllerB previousPlayerHeldBy;

	public EnemyType mimicEnemy;

	private bool holdingLastFrame;

	public bool maskIsHaunted;

	public int maskTypeId;

	ThreatType IVisibleThreat.type => default(ThreatType);

	int IVisibleThreat.GetInterestLevel()
	{
		return 0;
	}

	int IVisibleThreat.GetThreatLevel(Vector3 seenByPosition)
	{
		return 0;
	}

	Transform IVisibleThreat.GetThreatLookTransform()
	{
		return null;
	}

	Transform IVisibleThreat.GetThreatTransform()
	{
		return null;
	}

	Vector3 IVisibleThreat.GetThreatVelocity()
	{
		return default(Vector3);
	}

	float IVisibleThreat.GetVisibility()
	{
		return 0f;
	}

	public override void ItemActivate(bool used, bool buttonDown = true)
	{
	}

	public override void EquipItem()
	{
	}

	public override void DiscardItem()
	{
	}

	public override void PocketItem()
	{
	}

	private void CancelAttachToPlayerOnLocalClient()
	{
	}

	public void BeginAttachment()
	{
	}

	[ServerRpc]
	public void AttachServerRpc()
	{
	}

	[ClientRpc]
	public void AttachClientRpc()
	{
	}

	private void AttachToPlayerOnLocalClient()
	{
	}

	public void MaskClampToHeadAnimationEvent()
	{
	}

	private void FinishAttaching()
	{
	}

	[ServerRpc]
	public void CreateMimicServerRpc(bool inFactory, Vector3 playerPositionAtDeath)
	{
	}

	[ClientRpc]
	public void CreateMimicClientRpc(NetworkObjectReference netObjectRef, bool inFactory)
	{
	}

	[IteratorStateMachine(typeof(_003CwaitForMimicEnemySpawn_003Ed__41))]
	private IEnumerator waitForMimicEnemySpawn(NetworkObjectReference netObjectRef, bool inFactory)
	{
		return null;
	}

	public override void Update()
	{
	}

	public override void OnDestroy()
	{
	}

	public override void LateUpdate()
	{
	}

	private void PositionHeadMaskWithOffset()
	{
	}
}
