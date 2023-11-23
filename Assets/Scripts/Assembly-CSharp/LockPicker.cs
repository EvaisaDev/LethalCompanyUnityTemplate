using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Netcode;
using UnityEngine;

public class LockPicker : GrabbableObject
{
	[CompilerGenerated]
	private sealed class _003CsetRotationOnDoor_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LockPicker _003C_003E4__this;

		public bool lockPicker1;

		public DoorLock doorScript;

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
		public _003CsetRotationOnDoor_003Ed__18(int _003C_003E1__state)
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

	public AudioClip[] placeLockPickerClips;

	public AudioClip[] finishPickingLockClips;

	public Animator armsAnimator;

	private Ray ray;

	private RaycastHit hit;

	public bool isPickingLock;

	public bool isOnDoor;

	public DoorLock currentlyPickingDoor;

	private bool placeOnLockPicker1;

	private AudioSource lockPickerAudio;

	private Coroutine setRotationCoroutine;

	public override void EquipItem()
	{
	}

	public override void Start()
	{
	}

	public override void ItemActivate(bool used, bool buttonDown = true)
	{
	}

	private Vector3 GetLockPickerDoorPosition(DoorLock doorScript)
	{
		return default(Vector3);
	}

	[ServerRpc(RequireOwnership = false)]
	public void PlaceLockPickerServerRpc(NetworkObjectReference doorObject, bool lockPicker1)
	{
	}

	[ClientRpc]
	public void PlaceLockPickerClientRpc(NetworkObjectReference doorObject, bool lockPicker1)
	{
	}

	public void PlaceOnDoor(DoorLock doorScript, bool lockPicker1)
	{
	}

	[IteratorStateMachine(typeof(_003CsetRotationOnDoor_003Ed__18))]
	private IEnumerator setRotationOnDoor(DoorLock doorScript, bool lockPicker1)
	{
		return null;
	}

	private void FinishPickingLock()
	{
	}

	private void RetractClaws()
	{
	}

	public override void Update()
	{
	}

	[ClientRpc]
	public void FinishPickingClientRpc()
	{
	}
}
