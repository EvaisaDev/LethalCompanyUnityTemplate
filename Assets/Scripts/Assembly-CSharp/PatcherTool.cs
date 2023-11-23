using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DigitalRuby.ThunderAndLightning;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class PatcherTool : GrabbableObject
{
	[CompilerGenerated]
	private sealed class _003CScanGun_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PatcherTool _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CScanGun_003Ed__76(int _003C_003E1__state)
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
	private sealed class _003CbeginShockGame_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IShockableWithGun shockableScript;

		public PatcherTool _003C_003E4__this;

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
		public _003CbeginShockGame_003Ed__78(int _003C_003E1__state)
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
	private sealed class _003CstopShocking_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PatcherTool _003C_003E4__this;

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
		public _003CstopShocking_003Ed__82(int _003C_003E1__state)
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
	private sealed class _003CwaitForStartOfRoundInstance_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PatcherTool _003C_003E4__this;

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
		public _003CwaitForStartOfRoundInstance_003Ed__73(int _003C_003E1__state)
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

	[Space(15f)]
	public float gunAnomalyDamage;

	public bool isShocking;

	public IShockableWithGun shockedTargetScript;

	[Space(15f)]
	public Light flashlightBulb;

	public Light flashlightBulbGlow;

	public AudioSource mainAudio;

	public AudioSource shockAudio;

	public AudioSource gunAudio;

	public AudioClip[] activateClips;

	public AudioClip[] beginShockClips;

	public AudioClip[] overheatClips;

	public AudioClip[] finishShockClips;

	public AudioClip outOfBatteriesClip;

	public AudioClip detectAnomaly;

	public AudioClip scanAnomaly;

	public Material bulbLight;

	public Material bulbDark;

	public Animator effectAnimator;

	public Animator gunAnimator;

	public ParticleSystem overheatParticle;

	private Coroutine scanGunCoroutine;

	private Coroutine beginShockCoroutine;

	public Transform aimDirection;

	private int anomalyMask;

	private int roomMask;

	private RaycastHit hit;

	private Ray ray;

	public GameObject lightningObject;

	public Transform lightningDest;

	public Transform lightningBend1;

	public Transform lightningBend2;

	private Vector3 shockVectorMidpoint;

	[Header("Shock difficulty variables")]
	public float bendStrengthCap;

	public float endStrengthCap;

	private float currentEndStrengthCap;

	public float bendChangeSpeedMultiplier;

	public float endChangeSpeedMultiplier;

	private float currentEndChangeSpeedMultiplier;

	public float pullStrength;

	public float endPullStrength;

	private float currentEndPullStrength;

	public float maxChangePerFrame;

	public float endChangePerFrame;

	private float currentEndChangePerFrame;

	[HideInInspector]
	public float bendMultiplier;

	[HideInInspector]
	private float bendRandomizerShift;

	[HideInInspector]
	private Vector3 bendVector;

	public float gunOverheat;

	[HideInInspector]
	private bool sentStopShockingRPC;

	[HideInInspector]
	private bool wasShockingPreviousFrame;

	private LightningSplineScript lightningScript;

	private System.Random gunRandom;

	private int timesUsed;

	private bool lightningVisible;

	private float minigameChecksInterval;

	private float timeSpentShocking;

	private float makeAudibleNoiseTimer;

	public static int finishedShockMinigame;

	private RaycastHit[] raycastEnemies;

	private bool isScanning;

	private float currentDifficultyMultiplier;

	private PlayerControllerB previousPlayerHeldBy;

	public override void Start()
	{
	}

	public override void OnDestroy()
	{
	}

	public override void ItemActivate(bool used, bool buttonDown = true)
	{
	}

	private void PlayRandomAudio(AudioSource audioSource, AudioClip[] audioClips)
	{
	}

	private bool GunMeetsConditionsToShock(PlayerControllerB playerUsingGun, Vector3 targetPosition, float maxAngle = 80f)
	{
		return false;
	}

	public override void LateUpdate()
	{
	}

	private void AdjustDifficultyValues()
	{
	}

	private void InitialDifficultyValues()
	{
	}

	private float SetCurrentDifficultyValue(float max, float min)
	{
		return 0f;
	}

	public void ShiftBendRandomizer()
	{
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CwaitForStartOfRoundInstance_003Ed__73))]
	private IEnumerator waitForStartOfRoundInstance()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	private void OnSwitchCamera()
	{
	}

	[IteratorStateMachine(typeof(_003CScanGun_003Ed__76))]
	private IEnumerator ScanGun()
	{
		return null;
	}

	public void BeginShockingAnomalyOnClient(IShockableWithGun shockableScript)
	{
	}

	[IteratorStateMachine(typeof(_003CbeginShockGame_003Ed__78))]
	private IEnumerator beginShockGame(IShockableWithGun shockableScript)
	{
		return null;
	}

	private void StartShockAudios()
	{
	}

	public void StopShockingAnomalyOnClient(bool failed = false)
	{
	}

	private void SetFinishedShockMinigameTutorial()
	{
	}

	[IteratorStateMachine(typeof(_003CstopShocking_003Ed__82))]
	private IEnumerator stopShocking(PlayerControllerB playerController)
	{
		return null;
	}

	[ServerRpc(RequireOwnership = false)]
	public void ShockPatcherToolServerRpc(NetworkObjectReference netObject)
	{
	}

	[ClientRpc]
	public void ShockPatcherToolClientRpc(NetworkObjectReference netObject)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void StopShockingServerRpc()
	{
	}

	[ClientRpc]
	public void StopShockingClientRpc()
	{
	}

	public override void UseUpBatteries()
	{
	}

	public override void PocketItem()
	{
	}

	public override void DiscardItem()
	{
	}

	private void DisablePatcherGun()
	{
	}

	public override void EquipItem()
	{
	}

	public void SwitchFlashlight(bool on)
	{
	}

	private float RandomFloatInRange(System.Random rand, float min, float max)
	{
		return 0f;
	}
}
