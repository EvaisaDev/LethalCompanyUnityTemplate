using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class DoublewingAI : EnemyAI
{
	[CompilerGenerated]
	private sealed class _003CflyAwayThenDespawn_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DoublewingAI _003C_003E4__this;

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
		public _003CflyAwayThenDespawn_003Ed__32(int _003C_003E1__state)
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

	public Animator bodyAnimator;

	private int behaviourStateLastFrame;

	public AudioSource flappingAudio;

	public AudioClip[] birdScreechSFX;

	public AudioClip birdHitGroundSFX;

	public AISearchRoutine roamGlide;

	private bool alertingBird;

	private float glideTime;

	private float currentGlideTime;

	private RaycastHit hit;

	private bool flyingToOtherBirdLanding;

	private float avoidingPlayer;

	public Transform Body;

	private Vector3 previousPosition;

	private float flyLayerWeight;

	[Space(5f)]
	public float maxSpeed;

	[Space(5f)]
	public float speedElevationMultiplier;

	private float randomYRot;

	private int velocityAverageCount;

	private float averageVelocity;

	private float lerpedElevation;

	private float timeSinceEnteringFlight;

	private float randomHeightOffset;

	private bool birdStunned;

	private bool oddInterval;

	private int birdNoisiness;

	private float timeSinceSquawking;

	private float velocityInterval;

	public Rigidbody birdRigidbody;

	private int timesSyncingPosition;

	public override void Start()
	{
	}

	public override void DaytimeEnemyLeave()
	{
	}

	[IteratorStateMachine(typeof(_003CflyAwayThenDespawn_003Ed__32))]
	private IEnumerator flyAwayThenDespawn()
	{
		return null;
	}

	public override void DetectNoise(Vector3 noisePosition, float noiseLoudness, int timesPlayedInOneSpot = 0, int noiseID = 0)
	{
	}

	public void StunBird()
	{
	}

	public void UnstunBird()
	{
	}

	public override void DoAIInterval()
	{
	}

	public bool TryLanding()
	{
		return false;
	}

	[ServerRpc(RequireOwnership = false)]
	public void AlertBirdServerRpc()
	{
	}

	[ClientRpc]
	public void AlertBirdClientRpc()
	{
	}

	public void AlertBird()
	{
	}

	public void AlertBirdByOther()
	{
	}

	public override void Update()
	{
	}

	private void BirdScreech()
	{
	}

	public void SetFlyDirection()
	{
	}

	public override void HitEnemy(int force = 1, PlayerControllerB playerWhoHit = null, bool playHitSFX = false)
	{
	}

	public override void KillEnemy(bool destroy = false)
	{
	}

	public override void AnimationEventA()
	{
	}

	[ClientRpc(Delivery = RpcDelivery.Unreliable)]
	public void BirdScreechClientRpc()
	{
	}

	public override void AnimationEventB()
	{
	}
}
