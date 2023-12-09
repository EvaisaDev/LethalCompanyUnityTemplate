using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.Rendering.HighDefinition;

public class ForestGiantAI : EnemyAI, IVisibleThreat
{
	[CompilerGenerated]
	private sealed class _003CEatPlayerAnimation_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ForestGiantAI _003C_003E4__this;

		public PlayerControllerB playerBeingEaten;

		public Vector3 enemyPosition;

		public int enemyYRot;

		private Vector3 _003CstartPosition_003E5__2;

		private Quaternion _003CstartRotation_003E5__3;

		private int _003Ci_003E5__4;

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
		public _003CEatPlayerAnimation_003Ed__65(int _003C_003E1__state)
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

	private Coroutine eatPlayerCoroutine;

	private bool inEatingPlayerAnimation;

	public Transform holdPlayerPoint;

	public AISearchRoutine roamPlanet;

	public AISearchRoutine searchForPlayers;

	private float velX;

	private float velZ;

	private Vector3 previousPosition;

	private Vector3 agentLocalVelocity;

	public Transform animationContainer;

	public TwoBoneIKConstraint reachForPlayerRig;

	public Transform reachForPlayerTarget;

	private float stopAndLookInterval;

	private float stopAndLookTimer;

	private float targetYRot;

	public float scrutiny;

	public float[] playerStealthMeters;

	public float timeSpentStaring;

	public bool investigating;

	private bool hasBegunInvestigating;

	public Vector3 investigatePosition;

	public PlayerControllerB chasingPlayer;

	private bool lostPlayerInChase;

	private float noticePlayerTimer;

	private bool lookingAtTarget;

	public Transform turnCompass;

	public Transform lookTarget;

	private bool chasingPlayerInLOS;

	private float timeSinceChangingTarget;

	private bool hasLostPlayerInChaseDebounce;

	private bool triggerChaseByTouchingDebounce;

	public AudioSource farWideSFX;

	public DecalProjector bloodOnFaceDecal;

	private Vector3 lastSeenPlayerPositionInChase;

	private float timeSinceDetectingVoice;

	public Transform centerPosition;

	public Transform handBone;

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

	public override void Start()
	{
	}

	public override void DoAIInterval()
	{
	}

	public override void FinishedCurrentSearchRoutine()
	{
	}

	public override void ReachedNodeInSearch()
	{
	}

	private void LateUpdate()
	{
	}

	private void GiantSeePlayerEffect()
	{
	}

	public override void Update()
	{
	}

	private void ReachForPlayerIfClose()
	{
	}

	private void LookAtTarget()
	{
	}

	private void LookForPlayers()
	{
	}

	public void FindAndTargetNewPlayerOnLocalClient(PlayerControllerB newPlayer)
	{
	}

	[ServerRpc]
	private void BeginChasingNewPlayerServerRpc(int playerId)
	{
	}

	[ClientRpc]
	private void BeginChasingNewPlayerClientRpc(int playerId)
	{
	}

	[ClientRpc]
	private void HasLostPlayerInChaseClientRpc()
	{
	}

	[ClientRpc]
	private void HasFoundPlayerInChaseClientRpc()
	{
	}

	private void CalculateAnimationDirection(float maxSpeed = 1f)
	{
	}

	public override void OnCollideWithPlayer(Collider other)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void GrabPlayerServerRpc(int playerId)
	{
	}

	[ClientRpc]
	public void GrabPlayerClientRpc(int playerId, Vector3 enemyPosition, int enemyYRot)
	{
	}

	private void BeginEatPlayer(PlayerControllerB playerBeingEaten, Vector3 enemyPosition, int enemyYRot)
	{
	}

	[IteratorStateMachine(typeof(_003CEatPlayerAnimation_003Ed__65))]
	private IEnumerator EatPlayerAnimation(PlayerControllerB playerBeingEaten, Vector3 enemyPosition, int enemyYRot)
	{
		return null;
	}

	private void DropPlayerBody()
	{
	}

	private void StopKillAnimation()
	{
	}

	private void ReactToNoise(float distanceToNoise, Vector3 noisePosition)
	{
	}

	[ServerRpc]
	public void DetectPlayerVoiceServerRpc(Vector3 noisePosition)
	{
	}

	public override void KillEnemy(bool destroy = false)
	{
	}
}
