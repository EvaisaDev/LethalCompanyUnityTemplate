using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class ShotgunItem : GrabbableObject
{
	[CompilerGenerated]
	private sealed class _003CdelayedEarsRinging_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float effectSeverity;

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
		public _003CdelayedEarsRinging_003Ed__41(int _003C_003E1__state)
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
	private sealed class _003CreloadGunAnimation_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShotgunItem _003C_003E4__this;

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
		public _003CreloadGunAnimation_003Ed__48(int _003C_003E1__state)
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

	public int gunCompatibleAmmoID;

	public bool isReloading;

	public int shellsLoaded;

	public Animator gunAnimator;

	public AudioSource gunAudio;

	public AudioSource gunShootAudio;

	public AudioSource gunBulletsRicochetAudio;

	private Coroutine gunCoroutine;

	public AudioClip[] gunShootSFX;

	public AudioClip gunReloadSFX;

	public AudioClip gunReloadFinishSFX;

	public AudioClip noAmmoSFX;

	public AudioClip gunSafetySFX;

	public AudioClip switchSafetyOnSFX;

	public AudioClip switchSafetyOffSFX;

	public bool safetyOn;

	private float misfireTimer;

	private bool hasHitGroundWithSafetyOff;

	private int ammoSlotToUse;

	private bool localClientSendingShootGunRPC;

	private PlayerControllerB previousPlayerHeldBy;

	public ParticleSystem gunShootParticle;

	public Transform shotgunRayPoint;

	public MeshRenderer shotgunShellLeft;

	public MeshRenderer shotgunShellRight;

	public MeshRenderer shotgunShellInHand;

	public Transform shotgunShellInHandTransform;

	private RaycastHit[] enemyColliders;

	private EnemyAI heldByEnemy;

	public override void Start()
	{
	}

	public override int GetItemDataToSave()
	{
		return 0;
	}

	public override void LoadItemSaveData(int saveData)
	{
	}

	public override void Update()
	{
	}

	public override void EquipItem()
	{
	}

	public override void GrabItemFromEnemy(EnemyAI enemy)
	{
	}

	public override void DiscardItemFromEnemy()
	{
	}

	public override void ItemActivate(bool used, bool buttonDown = true)
	{
	}

	public void ShootGunAndSync(bool heldByPlayer)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void ShootGunServerRpc(Vector3 shotgunPosition, Vector3 shotgunForward)
	{
	}

	[ClientRpc]
	public void ShootGunClientRpc(Vector3 shotgunPosition, Vector3 shotgunForward)
	{
	}

	public void ShootGun(Vector3 shotgunPosition, Vector3 shotgunForward)
	{
	}

	[IteratorStateMachine(typeof(_003CdelayedEarsRinging_003Ed__41))]
	private IEnumerator delayedEarsRinging(float effectSeverity)
	{
		return null;
	}

	public override void ItemInteractLeftRight(bool right)
	{
	}

	public override void SetControlTipsForItem()
	{
	}

	private void SetSafetyControlTip()
	{
	}

	private void StartReloadGun()
	{
	}

	[ServerRpc]
	public void ReloadGunEffectsServerRpc(bool start = true)
	{
	}

	[ClientRpc]
	public void ReloadGunEffectsClientRpc(bool start = true)
	{
	}

	[IteratorStateMachine(typeof(_003CreloadGunAnimation_003Ed__48))]
	private IEnumerator reloadGunAnimation()
	{
		return null;
	}

	private bool ReloadedGun()
	{
		return false;
	}

	private int FindAmmoInInventory()
	{
		return 0;
	}

	public override void PocketItem()
	{
	}

	public override void DiscardItem()
	{
	}

	private void StopUsingGun()
	{
	}
}
