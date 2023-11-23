using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class BlobAI : EnemyAI
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public PlayerControllerB playerScript;

		public float startTime;

		internal bool _003CeatPlayerBody_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CeatPlayerBody_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private _003C_003Ec__DisplayClass40_0 _003C_003E8__1;

		public int playerKilled;

		public BlobAI _003C_003E4__this;

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
		public _003CeatPlayerBody_003Ed__40(int _003C_003E1__state)
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

	[Header("Fluid simulation")]
	public Transform centerPoint;

	public Transform[] SlimeRaycastTargets;

	public Rigidbody[] SlimeBones;

	private Vector3[] SlimeBonePositions;

	public float slimeRange;

	public float currentSlimeRange;

	private float[] maxDistanceForSlimeRays;

	private float[] distanceOfRaysLastFrame;

	private int partsMovingUpSlope;

	private Ray slimeRay;

	private RaycastHit slimeRayHit;

	private RaycastHit slimePlayerRayHit;

	private float timeSinceHittingLocalPlayer;

	[Header("Behaviors")]
	public AISearchRoutine searchForPlayers;

	private float tamedTimer;

	private float angeredTimer;

	private Material thisSlimeMaterial;

	private float slimeJiggleAmplitude;

	private float slimeJiggleDensity;

	[Header("SFX")]
	public AudioSource movableAudioSource;

	public AudioClip agitatedSFX;

	public AudioClip jiggleSFX;

	public AudioClip hitSlimeSFX;

	public AudioClip killPlayerSFX;

	public AudioClip idleSFX;

	private Collider[] ragdollColliders;

	private Coroutine eatPlayerBodyCoroutine;

	private DeadBodyInfo bodyBeingCarried;

	private int slimeMask;

	public Mesh emptySuitMesh;

	public override void Start()
	{
	}

	public override void DoAIInterval()
	{
	}

	private void SimulateSurfaceTensionInRaycasts(int i)
	{
	}

	private void FixedUpdate()
	{
	}

	public override void Update()
	{
	}

	private void MoveSlimeBoneToRaycastHit(float currentRangeOfRaycast, int i)
	{
	}

	private void RaycastCollisionWithPlayers(float maxDistance)
	{
	}

	public override void OnCollideWithPlayer(Collider other)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SlimeKillPlayerEffectServerRpc(int playerKilled)
	{
	}

	[ClientRpc]
	public void SlimeKillPlayerEffectClientRpc(int playerKilled)
	{
	}

	[IteratorStateMachine(typeof(_003CeatPlayerBody_003Ed__40))]
	private IEnumerator eatPlayerBody(int playerKilled)
	{
		return null;
	}

	public override void HitEnemy(int force = 1, PlayerControllerB playerWhoHit = null, bool playHitSFX = false)
	{
	}

	public override void DetectNoise(Vector3 noisePosition, float noiseLoudness, int timesPlayedInOneSpot = 0, int noiseID = 0)
	{
	}
}
