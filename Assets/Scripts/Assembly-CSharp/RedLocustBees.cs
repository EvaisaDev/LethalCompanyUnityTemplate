using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DigitalRuby.ThunderAndLightning;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.VFX;

public class RedLocustBees : EnemyAI
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public PlayerControllerB killedPlayer;

		public float timeAtStart;

		internal bool _003CBeesKillPlayer_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CBeesKillPlayer_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerControllerB killedPlayer;

		private _003C_003Ec__DisplayClass51_0 _003C_003E8__1;

		public RedLocustBees _003C_003E4__this;

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
		public _003CBeesKillPlayer_003Ed__51(int _003C_003E1__state)
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
	private sealed class _003CbugsLeave_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RedLocustBees _003C_003E4__this;

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
		public _003CbugsLeave_003Ed__60(int _003C_003E1__state)
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

	public int defenseDistance;

	[Space(5f)]
	public GameObject hivePrefab;

	public GrabbableObject hive;

	public Vector3 lastKnownHivePosition;

	private int previousState;

	public VisualEffect beeParticles;

	public Transform beeParticlesTarget;

	public AudioSource beesIdle;

	public AudioSource beesDefensive;

	public AudioSource beesAngry;

	public AISearchRoutine searchForHive;

	private int chasePriority;

	private Vector3 lastSeenPlayerPos;

	private float lostLOSTimer;

	private bool wasInChase;

	private bool hasFoundHiveAfterChasing;

	private bool hasSpawnedHive;

	private float beesZapCurrentTimer;

	private float beesZapTimer;

	public LightningBoltPathScript lightningComponent;

	public Transform[] lightningPoints;

	private int beesZappingMode;

	private int timesChangingZapModes;

	private System.Random beeZapRandom;

	public AudioSource beeZapAudio;

	private float timeSinceHittingPlayer;

	private float attackZapModeTimer;

	private bool overrideBeeParticleTarget;

	private int beeParticleState;

	private PlayerControllerB killingPlayer;

	private Coroutine killingPlayerCoroutine;

	private bool syncedLastKnownHivePosition;

	public override void Start()
	{
	}

	private void SpawnHiveNearEnemy()
	{
	}

	[ClientRpc]
	public void SpawnHiveClientRpc(NetworkObjectReference hiveObject, int hiveScrapValue, Vector3 hivePosition)
	{
	}

	public override void DoAIInterval()
	{
	}

	private bool SwitchOwnershipOfBeesToClient(PlayerControllerB player)
	{
		return false;
	}

	[ServerRpc(RequireOwnership = false)]
	public void SyncLastKnownHivePositionServerRpc(Vector3 hivePosition)
	{
	}

	[ClientRpc]
	public void SyncLastKnownHivePositionClientRpc(Vector3 hivePosition)
	{
	}

	private PlayerControllerB ChaseWithPriorities()
	{
		return null;
	}

	private bool IsHiveMissing()
	{
		return false;
	}

	private bool IsHivePlacedAndInLOS()
	{
		return false;
	}

	public override void Update()
	{
	}

	private void ResetBeeZapTimer()
	{
	}

	private void BeesZapOnTimer()
	{
	}

	private void SetBeeParticleMode(int newState)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void EnterAttackZapModeServerRpc(int clientWhoSent)
	{
	}

	[ClientRpc]
	public void EnterAttackZapModeClientRpc(int clientWhoSent)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void BeeKillPlayerServerRpc(int playerId)
	{
	}

	[ClientRpc]
	public void BeeKillPlayerClientRpc(int playerId)
	{
	}

	private void BeeKillPlayerOnLocalClient(int playerId)
	{
	}

	[IteratorStateMachine(typeof(_003CBeesKillPlayer_003Ed__51))]
	private IEnumerator BeesKillPlayer(PlayerControllerB killedPlayer)
	{
		return null;
	}

	private void OnPlayerTeleported(PlayerControllerB playerTeleported)
	{
	}

	public override void OnCollideWithPlayer(Collider other)
	{
	}

	public void BeesZap()
	{
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	private void OnCameraSwitch()
	{
	}

	public override void EnableEnemyMesh(bool enable, bool overrideDoNotSet = false)
	{
	}

	public override void DaytimeEnemyLeave()
	{
	}

	[IteratorStateMachine(typeof(_003CbugsLeave_003Ed__60))]
	private IEnumerator bugsLeave()
	{
		return null;
	}
}
