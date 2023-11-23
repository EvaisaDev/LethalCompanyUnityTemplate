using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class MouthDogAI : EnemyAI, INoiseListener, IVisibleThreat
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public PlayerControllerB killPlayer;

		public float startTime;

		internal bool _003CKillPlayer_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CKillPlayer_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MouthDogAI _003C_003E4__this;

		public int playerId;

		private _003C_003Ec__DisplayClass60_0 _003C_003E8__1;

		private Quaternion _003CrotateTo_003E5__2;

		private Quaternion _003CrotateFrom_003E5__3;

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
		public _003CKillPlayer_003Ed__60(int _003C_003E1__state)
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
	private sealed class _003CenterChaseMode_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MouthDogAI _003C_003E4__this;

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
		public _003CenterChaseMode_003Ed__45(int _003C_003E1__state)
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

	public float noiseApproximation;

	public int suspicionLevel;

	private Vector3 previousPosition;

	public DampedTransform neckDampedTransform;

	private RoundManager roundManager;

	private float AITimer;

	private List<GameObject> allAINodesWithinRange;

	private bool hasEnteredChaseModeFully;

	private bool startedChaseModeCoroutine;

	public AudioClip screamSFX;

	public AudioClip breathingSFX;

	public AudioClip killPlayerSFX;

	private float hearNoiseCooldown;

	private bool inLunge;

	private float lungeCooldown;

	private bool inKillAnimation;

	public Transform mouthGrip;

	public bool endingLunge;

	private Ray ray;

	private RaycastHit rayHit;

	private Vector3 lastHeardNoisePosition;

	private Vector3 noisePositionGuess;

	private float lastHeardNoiseDistanceWhenHeard;

	private bool heardOtherHowl;

	private DeadBodyInfo carryingBody;

	private System.Random enemyRandom;

	private Coroutine killPlayerCoroutine;

	private const int suspicionThreshold = 5;

	private const int alertThreshold = 9;

	private const int maxSuspicionLevel = 11;

	public AISearchRoutine roamPlanet;

	private Collider debugCollider;

	private float timeSinceHittingOtherEnemy;

	ThreatType IVisibleThreat.type => default(ThreatType);

	int IVisibleThreat.GetThreatLevel(Vector3 seenByPosition)
	{
		return 0;
	}

	int IVisibleThreat.GetInterestLevel()
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

	public override void DoAIInterval()
	{
	}

	public override void Start()
	{
	}

	public override void Update()
	{
	}

	private void SearchForPreviouslyHeardSound()
	{
	}

	[IteratorStateMachine(typeof(_003CenterChaseMode_003Ed__45))]
	private IEnumerator enterChaseMode()
	{
		return null;
	}

	private void CallAllDogsWithHowl()
	{
	}

	public void ReactToOtherDogHowl(Vector3 howlPosition)
	{
	}

	public override void DetectNoise(Vector3 noisePosition, float noiseLoudness, int timesNoisePlayedInOneSpot = 0, int noiseID = 0)
	{
	}

	private void EnrageDogOnLocalClient(Vector3 targetPosition, float distanceToNoise, bool approximatePosition = true, bool fullyEnrage = false)
	{
	}

	private void EnterLunge()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void EndLungeServerRpc()
	{
	}

	[ClientRpc]
	public void EndLungeClientRpc()
	{
	}

	private void ChaseLocalPlayer()
	{
	}

	public override void HitEnemy(int force = 1, PlayerControllerB playerWhoHit = null, bool playHitSFX = false)
	{
	}

	public override void OnCollideWithEnemy(Collider other, EnemyAI collidedEnemy = null)
	{
	}

	public override void OnCollideWithPlayer(Collider other)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void KillPlayerServerRpc(int playerId)
	{
	}

	[ClientRpc]
	public void CancelKillAnimationWithPlayerClientRpc(int playerObjectId)
	{
	}

	[ClientRpc]
	public void KillPlayerClientRpc(int playerId)
	{
	}

	[IteratorStateMachine(typeof(_003CKillPlayer_003Ed__60))]
	private IEnumerator KillPlayer(int playerId)
	{
		return null;
	}

	private void StopKillAnimation()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void StopKillAnimationServerRpc()
	{
	}

	[ClientRpc]
	public void StopKillAnimationClientRpc()
	{
	}

	private void TakeBodyInMouth(DeadBodyInfo body)
	{
	}

	private void DropCarriedBody()
	{
	}

	public override void KillEnemy(bool destroy = false)
	{
	}

	public override void EnableEnemyMesh(bool enable, bool overrideDoNotSet = false)
	{
	}

	public override void OnDrawGizmos()
	{
	}
}
