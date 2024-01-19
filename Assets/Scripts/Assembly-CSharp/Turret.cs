using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class Turret : NetworkBehaviour, IHittable
{
	[CompilerGenerated]
	private sealed class _003CFadeBulletAudio_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Turret _003C_003E4__this;

		private float _003CinitialVolume_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CFadeBulletAudio_003Ed__46(int _003C_003E1__state)
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

	[Header("Effects")]
	public AudioSource mainAudio;

	[Header("Effects")]
	public AudioSource bulletCollisionAudio;

	[Header("Effects")]
	public AudioSource farAudio;

	public AudioClip firingSFX;

	public AudioClip chargingSFX;

	public AudioClip detectPlayerSFX;

	public AudioClip firingFarSFX;

	public AudioClip bulletsHitWallSFX;

	public AudioClip turretActivate;

	public AudioClip turretDeactivate;

	public ParticleSystem bulletParticles;

	public Animator turretAnimator;

	[Header("Variables")]
	public bool turretActive;

	[Space(5f)]
	public TurretMode turretMode;

	private TurretMode turretModeLastFrame;

	public Transform turretRod;

	public float targetRotation;

	public float rotationSpeed;

	public Transform turnTowardsObjectCompass;

	public Transform forwardFacingPos;

	public Transform aimPoint;

	public Transform centerPoint;

	public PlayerControllerB targetPlayerWithRotation;

	public Transform targetTransform;

	private bool targetingDeadPlayer;

	public float rotationRange;

	public float currentRotation;

	public bool rotatingOnInterval;

	private bool rotatingRight;

	private float switchRotationTimer;

	private bool hasLineOfSight;

	private float lostLOSTimer;

	private bool wasTargetingPlayerLastFrame;

	private RaycastHit hit;

	private int wallAndPlayerMask;

	private float turretInterval;

	private string previousHitLog;

	private bool rotatingSmoothly;

	private Ray shootRay;

	private Coroutine fadeBulletAudioCoroutine;

	public Transform tempTransform;

	private bool rotatingClockwise;

	private float berserkTimer;

	public AudioSource berserkAudio;

	private bool enteringBerserkMode;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CFadeBulletAudio_003Ed__46))]
	private IEnumerator FadeBulletAudio()
	{
		return null;
	}

	private void Update()
	{
	}

	private void SetTargetToPlayerBody()
	{
	}

	private void TurnTowardsTargetIfHasLOS()
	{
	}

	public PlayerControllerB CheckForPlayersInLineOfSight(float radius = 2f, bool angleRangeCheck = false)
	{
		return null;
	}

	[ClientRpc]
	public void SwitchRotationClientRpc(bool setRotateRight)
	{
	}

	public void SwitchRotationOnInterval(bool setRotateRight)
	{
	}

	[ClientRpc]
	public void SwitchTargetedPlayerClientRpc(int playerId, bool setModeToCharging = false)
	{
	}

	[ClientRpc]
	public void RemoveTargetedPlayerClientRpc()
	{
	}

	[ClientRpc]
	public void SetToModeClientRpc(int mode)
	{
	}

	private void SwitchTurretMode(int mode)
	{
	}

	public void ToggleTurretEnabled(bool enabled)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void ToggleTurretServerRpc(bool enabled)
	{
	}

	[ClientRpc]
	public void ToggleTurretClientRpc(bool enabled)
	{
	}

	private void ToggleTurretEnabledLocalClient(bool enabled)
	{
	}

	bool IHittable.Hit(int force, Vector3 hitDirection, PlayerControllerB playerWhoHit, bool playHitSFX)
	{
		return false;
	}

	[ServerRpc(RequireOwnership = false)]
	public void EnterBerserkModeServerRpc(int playerWhoTriggered)
	{
	}

	[ClientRpc]
	public void EnterBerserkModeClientRpc(int playerWhoTriggered)
	{
	}
}
