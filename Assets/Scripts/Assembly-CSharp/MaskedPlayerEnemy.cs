using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class MaskedPlayerEnemy : EnemyAI
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass104_0
	{
		public float startTime;

		public NetworkObjectReference netObjectRef;

		public NetworkObject netObject;

		public PlayerControllerB player;

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
	private sealed class _003CkillAnimation_003Ed__102 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MaskedPlayerEnemy _003C_003E4__this;

		private Vector3 _003CendPosition_003E5__2;

		private Quaternion _003CstartingPlayerRot_003E5__3;

		private Quaternion _003CtargetRot_003E5__4;

		private Vector3 _003CstartingPosition_003E5__5;

		private int _003Ci_003E5__6;

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
		public _003CkillAnimation_003Ed__102(int _003C_003E1__state)
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
	private sealed class _003CteleportMasked_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MaskedPlayerEnemy _003C_003E4__this;

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
		public _003CteleportMasked_003Ed__93(int _003C_003E1__state)
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
	private sealed class _003CwaitForMimicEnemySpawn_003Ed__104 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NetworkObjectReference netObjectRef;

		public int playerKilled;

		private _003C_003Ec__DisplayClass104_0 _003C_003E8__1;

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
		public _003CwaitForMimicEnemySpawn_003Ed__104(int _003C_003E1__state)
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

	public SkinnedMeshRenderer rendererLOD0;

	public SkinnedMeshRenderer rendererLOD1;

	public SkinnedMeshRenderer rendererLOD2;

	private Ray enemyRay;

	private RaycastHit enemyRayHit;

	private int currentFootstepSurfaceIndex;

	private int previousFootstepClip;

	public AudioSource movementAudio;

	private bool sprinting;

	private int previousBehaviourState;

	public float walkCheckInterval;

	private Vector3 positionLastCheck;

	private Coroutine teleportCoroutine;

	public ParticleSystem teleportParticle;

	public AISearchRoutine searchForPlayers;

	private Vector3 agentLocalVelocity;

	private Vector3 previousPosition;

	private float velX;

	private float velZ;

	public Transform animationContainer;

	private Vector3 currentRandomLookDirection;

	private Vector3 focusOnPosition;

	private float verticalLookAngle;

	private float currentLookAngle;

	public Transform headTiltTarget;

	private float lookAtPositionTimer;

	private float randomLookTimer;

	private bool lostPlayerInChase;

	private float lostLOSTimer;

	private bool running;

	private bool crouching;

	[Space(3f)]
	public PlayerControllerB mimickingPlayer;

	public bool allowSpawningWithoutPlayer;

	[Space(3f)]
	public Transform lerpTarget;

	public float turnSpeedMultiplier;

	public MultiRotationConstraint lookRig1;

	public MultiRotationConstraint lookRig2;

	private float stopAndStareTimer;

	public Transform stareAtTransform;

	private bool handsOut;

	private bool inKillAnimation;

	public bool startingKillAnimationLocalClient;

	private Coroutine killAnimationCoroutine;

	private Ray playerRay;

	public MeshRenderer[] maskEyesGlow;

	public Light maskEyesGlowLight;

	public ParticleSystem maskFloodParticle;

	private PlayerControllerB lastPlayerKilled;

	private float timeLookingAtLastNoise;

	private Vector3 shipHidingSpot;

	private float staminaTimer;

	private bool runningRandomly;

	private bool enemyEnabled;

	public GameObject[] maskTypes;

	public int maskTypeIndex;

	private Vector3 mainEntrancePosition;

	private float timeAtLastUsingEntrance;

	private float interestInShipCooldown;

	private List<int> playersKilled;

	public override void Start()
	{
	}

	[ServerRpc]
	public void SetEnemyAsHavingNoPlayerServerRpc()
	{
	}

	[ClientRpc]
	public void SetEnemyAsHavingNoPlayerClientRpc()
	{
	}

	private void Awake()
	{
	}

	private void LookAndRunRandomly(bool canStartRunning = false, bool onlySetRunning = false)
	{
	}

	private void TeleportMaskedEnemyAndSync(Vector3 pos, bool setOutside)
	{
	}

	[ServerRpc]
	public void TeleportMaskedEnemyServerRpc(Vector3 pos, bool setOutside)
	{
	}

	[ClientRpc]
	public void TeleportMaskedEnemyClientRpc(Vector3 pos, bool setOutside)
	{
	}

	private void TeleportMaskedEnemy(Vector3 pos, bool setOutside)
	{
	}

	public override void DoAIInterval()
	{
	}

	[ServerRpc]
	public void LookAtDirectionServerRpc(Vector3 dir, float time, float vertLookAngle)
	{
	}

	[ClientRpc]
	public void LookAtDirectionClientRpc(Vector3 dir, float time, float vertLookAngle)
	{
	}

	[ServerRpc]
	public void LookAtPositionServerRpc(Vector3 pos, float time)
	{
	}

	[ClientRpc]
	public void LookAtPositionClientRpc(Vector3 pos, float time)
	{
	}

	[ServerRpc]
	public void LookAtPlayerServerRpc(int playerId)
	{
	}

	[ClientRpc]
	public void LookAtPlayerClientRpc(int playerId)
	{
	}

	[ServerRpc]
	public void StopLookingAtTransformServerRpc()
	{
	}

	[ClientRpc]
	public void StopLookingAtTransformClientRpc()
	{
	}

	[ServerRpc]
	public void SetHandsOutServerRpc(bool setOut)
	{
	}

	[ClientRpc]
	public void SetHandsOutClientRpc(bool setOut)
	{
	}

	[ServerRpc]
	public void SetCrouchingServerRpc(bool setOut)
	{
	}

	[ClientRpc]
	public void SetCrouchingClientRpc(bool setCrouch)
	{
	}

	public void LookAtFocusedPosition()
	{
	}

	public void LookAtDirection(Vector3 direction, float lookAtTime = 1f, float vertLookAngle = 0f)
	{
	}

	public void LookAtPosition(Vector3 pos, float lookAtTime = 1f)
	{
	}

	[ServerRpc]
	public void SetRunningServerRpc(bool running)
	{
	}

	[ClientRpc]
	public void SetRunningClientRpc(bool setRunning)
	{
	}

	private void CalculateAnimationDirection(float maxSpeed = 1f)
	{
	}

	public override void DetectNoise(Vector3 noisePosition, float noiseLoudness, int timesPlayedInOneSpot = 0, int noiseID = 0)
	{
	}

	public void LateUpdate()
	{
	}

	public void SetVisibilityOfMaskedEnemy()
	{
	}

	public override void Update()
	{
	}

	private void ChooseShipHidingSpot()
	{
	}

	public override void ShipTeleportEnemy()
	{
	}

	[IteratorStateMachine(typeof(_003CteleportMasked_003Ed__93))]
	private IEnumerator teleportMasked()
	{
		return null;
	}

	public void SetEnemyOutside(bool outside = false)
	{
	}

	public override void OnDestroy()
	{
	}

	public override void KillEnemy(bool destroy = false)
	{
	}

	public override void HitEnemy(int force = 1, PlayerControllerB playerWhoHit = null, bool playHitSFX = false)
	{
	}

	public override void OnCollideWithPlayer(Collider other)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void KillPlayerAnimationServerRpc(int playerObjectId)
	{
	}

	[ClientRpc]
	public void CancelKillAnimationClientRpc(int playerObjectId)
	{
	}

	[ClientRpc]
	public void KillPlayerAnimationClientRpc(int playerObjectId)
	{
	}

	[IteratorStateMachine(typeof(_003CkillAnimation_003Ed__102))]
	private IEnumerator killAnimation()
	{
		return null;
	}

	[ClientRpc]
	public void CreateMimicClientRpc(NetworkObjectReference netObjectRef, bool inFactory, int playerKilled)
	{
	}

	[IteratorStateMachine(typeof(_003CwaitForMimicEnemySpawn_003Ed__104))]
	private IEnumerator waitForMimicEnemySpawn(NetworkObjectReference netObjectRef, bool inFactory, int playerKilled)
	{
		return null;
	}

	public override void CancelSpecialAnimationWithPlayer()
	{
	}

	public void FinishKillAnimation(bool killedPlayer = false)
	{
	}

	private Vector3 GetGroundPosition(Vector3 startingPos)
	{
		return default(Vector3);
	}

	public void SetSuit(int suitId)
	{
	}

	public void SetMaskType(int maskType)
	{
	}

	public void GetMaterialStandingOn()
	{
	}

	public void PlayFootstepSound()
	{
	}

	public override void AnimationEventA()
	{
	}

	public void SetMaskGlow(bool enable)
	{
	}
}
