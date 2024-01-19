using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DunGen;
using DunGen.Graph;
using TMPro;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.AI;

public class RoundManager : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDetectElevatorRunning_003Ed__130 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoundManager _003C_003E4__this;

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
		public _003CDetectElevatorRunning_003Ed__130(int _003C_003E1__state)
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
	private sealed class _003CFlickerPoweredLights_003Ed__154 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool flickerFlashlights;

		public bool disableFlashlights;

		public RoundManager _003C_003E4__this;

		private int _003CloopCount_003E5__2;

		private int _003Cb_003E5__3;

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
		public _003CFlickerPoweredLights_003Ed__154(int _003C_003E1__state)
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
	private sealed class _003CLoadNewLevelWait_003Ed__115 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoundManager _003C_003E4__this;

		public int randomSeed;

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
		public _003CLoadNewLevelWait_003Ed__115(int _003C_003E1__state)
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
	private sealed class _003CturnOnLights_003Ed__152 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool turnOn;

		public RoundManager _003C_003E4__this;

		private int _003Cb_003E5__2;

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
		public _003CturnOnLights_003Ed__152(int _003C_003E1__state)
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
	private sealed class _003CwaitForMainEntranceTeleportToSpawn_003Ed__166 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoundManager _003C_003E4__this;

		private float _003CstartTime_003E5__2;

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
		public _003CwaitForMainEntranceTeleportToSpawn_003Ed__166(int _003C_003E1__state)
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
	private sealed class _003CwaitForScrapToSpawnToSync_003Ed__104 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoundManager _003C_003E4__this;

		public NetworkObjectReference[] spawnedScrap;

		public int[] scrapValues;

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
		public _003CwaitForScrapToSpawnToSync_003Ed__104(int _003C_003E1__state)
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

	public StartOfRound playersManager;

	public Transform syncedPropsContainer;

	public Transform itemPooledObjectsContainer;

	[Header("Global Game Variables / Balancing")]
	public float scrapValueMultiplier;

	public float scrapAmountMultiplier;

	public float mapSizeMultiplier;

	[Space(3f)]
	public int increasedInsideEnemySpawnRateIndex;

	public int increasedOutsideEnemySpawnRateIndex;

	public int increasedMapPropSpawnRateIndex;

	public int increasedScrapSpawnRateIndex;

	public int increasedMapHazardSpawnRateIndex;

	[Space(5f)]
	[Space(5f)]
	public int currentMaxInsidePower;

	public int currentMaxOutsidePower;

	public int currentEnemyPower;

	public int currentOutsideEnemyPower;

	public int currentDaytimeEnemyPower;

	public TimeOfDay timeScript;

	private int currentHour;

	public float currentHourTime;

	[Header("Gameplay events")]
	public List<int> enemySpawnTimes;

	public int currentEnemySpawnIndex;

	public bool isSpawningEnemies;

	public bool begunSpawningEnemies;

	[Header("Elevator Properties")]
	public bool ElevatorCharging;

	public float elevatorCharge;

	public bool ElevatorPowered;

	public bool elevatorUp;

	public bool ElevatorLowering;

	public bool ElevatorRunning;

	public bool ReturnToSurface;

	[Header("Elevator Variables")]
	public Animator ElevatorAnimator;

	public Animator ElevatorLightAnimator;

	public AudioSource elevatorMotorAudio;

	public AudioClip startMotor;

	public Animator PanelButtons;

	public Animator PanelLights;

	public AudioSource elevatorButtonsAudio;

	public AudioClip PressButtonSFX1;

	public AudioClip PressButtonSFX2;

	public TextMeshProUGUI PanelScreenText;

	public Canvas PanelScreen;

	public NetworkObject lungPlacePosition;

	public InteractTrigger elevatorSocketTrigger;

	private Coroutine loadLevelCoroutine;

	private Coroutine flickerLightsCoroutine;

	private Coroutine powerLightsCoroutine;

	[Header("Enemies")]
	public EnemyVent[] allEnemyVents;

	public List<Anomaly> SpawnedAnomalies;

	public List<EnemyAI> SpawnedEnemies;

	private List<int> SpawnProbabilities;

	public int hourTimeBetweenEnemySpawnBatches;

	public int numberOfEnemiesInScene;

	public int minEnemiesToSpawn;

	public int minOutsideEnemiesToSpawn;

	[Header("Hazards")]
	public SpawnableMapObject[] spawnableMapObjects;

	public GameObject mapPropsContainer;

	public Transform[] shipSpawnPathPoints;

	public GameObject[] spawnDenialPoints;

	public string[] possibleCodesForBigDoors;

	public GameObject quicksandPrefab;

	public GameObject keyPrefab;

	[Space(5f)]
	public GameObject[] outsideAINodes;

	public GameObject[] insideAINodes;

	[Header("Dungeon generation")]
	public DungeonFlow[] dungeonFlowTypes;

	public RuntimeDungeon dungeonGenerator;

	public bool dungeonCompletedGenerating;

	public bool dungeonFinishedGeneratingForAllPlayers;

	public AudioClip[] firstTimeDungeonAudios;

	[Header("Scrap-collection")]
	public Transform spawnedScrapContainer;

	public int scrapCollectedInLevel;

	public float totalScrapValueInLevel;

	public int valueOfFoundScrapItems;

	public List<GrabbableObject> scrapCollectedThisRound;

	public SelectableLevel currentLevel;

	public System.Random LevelRandom;

	public System.Random AnomalyRandom;

	public System.Random EnemySpawnRandom;

	public System.Random BreakerBoxRandom;

	public System.Random ScrapValuesRandom;

	public System.Random ChallengeMoonRandom;

	public bool powerOffPermanently;

	public bool hasInitializedLevelRandomSeed;

	public List<ulong> playersFinishedGeneratingFloor;

	public PowerSwitchEvent onPowerSwitch;

	public List<Animator> allPoweredLightsAnimators;

	public List<Light> allPoweredLights;

	public List<GameObject> spawnedSyncedObjects;

	public float stabilityMeter;

	private Coroutine elevatorRunningCoroutine;

	public int collisionsMask;

	public bool cannotSpawnMoreInsideEnemies;

	public Collider[] tempColliderResults;

	public Transform tempTransform;

	public bool GotNavMeshPositionResult;

	public NavMeshHit navHit;

	private bool firstTimeSpawningEnemies;

	private bool firstTimeSpawningOutsideEnemies;

	private bool firstTimeSpawningDaytimeEnemies;

	public static RoundManager Instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void Awake()
	{
	}

	public void SpawnScrapInLevel()
	{
	}

	[IteratorStateMachine(typeof(_003CwaitForScrapToSpawnToSync_003Ed__104))]
	private IEnumerator waitForScrapToSpawnToSync(NetworkObjectReference[] spawnedScrap, int[] scrapValues)
	{
		return null;
	}

	[ClientRpc]
	public void SyncScrapValuesClientRpc(NetworkObjectReference[] spawnedScrap, int[] allScrapValue)
	{
	}

	public void SpawnSyncedProps()
	{
	}

	public void SpawnMapObjects()
	{
	}

	public float YRotationThatFacesTheFarthestFromPosition(Vector3 pos, float maxDistance = 25f, int resolution = 6)
	{
		return 0f;
	}

	public float YRotationThatFacesTheNearestFromPosition(Vector3 pos, float maxDistance = 25f, int resolution = 6)
	{
		return 0f;
	}

	public void GenerateNewFloor()
	{
	}

	public void GeneratedFloorPostProcessing()
	{
	}

	public void TurnBreakerSwitchesOff()
	{
	}

	public void LoadNewLevel(int randomSeed, SelectableLevel newLevel)
	{
	}

	private void SetChallengeFileRandomModifiers()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadNewLevelWait_003Ed__115))]
	private IEnumerator LoadNewLevelWait(int randomSeed)
	{
		return null;
	}

	[ClientRpc]
	public void GenerateNewLevelClientRpc(int randomSeed, int levelID)
	{
	}

	private void FinishGeneratingLevel()
	{
	}

	private void Generator_OnGenerationStatusChanged(DungeonGenerator generator, GenerationStatus status)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void FinishedGeneratingLevelServerRpc(ulong clientId)
	{
	}

	public void DespawnPropsAtEndOfRound(bool despawnAllItems = false)
	{
	}

	public void UnloadSceneObjectsEarly()
	{
	}

	public override void OnDestroy()
	{
	}

	[ServerRpc]
	public void FinishGeneratingNewLevelServerRpc()
	{
	}

	private void SetToCurrentLevelWeather()
	{
	}

	[ClientRpc]
	public void FinishGeneratingNewLevelClientRpc()
	{
	}

	private void ResetEnemySpawningVariables()
	{
	}

	public void ResetEnemyVariables()
	{
	}

	public void CollectNewScrapForThisRound(GrabbableObject scrapObject)
	{
	}

	public void DetectElevatorIsRunning()
	{
	}

	[IteratorStateMachine(typeof(_003CDetectElevatorRunning_003Ed__130))]
	private IEnumerator DetectElevatorRunning()
	{
		return null;
	}

	public void BeginEnemySpawning()
	{
	}

	public void SpawnEnemiesOutside()
	{
	}

	public void SpawnDaytimeEnemiesOutside()
	{
	}

	private GameObject SpawnRandomDaytimeEnemy(GameObject[] spawnPoints, float timeUpToCurrentHour)
	{
		return null;
	}

	private GameObject SpawnRandomOutsideEnemy(GameObject[] spawnPoints, float timeUpToCurrentHour)
	{
		return null;
	}

	public void PlotOutEnemiesForNextHour()
	{
	}

	public void LogEnemySpawnTimes(bool couldNotFinish)
	{
	}

	private bool AssignRandomEnemyToVent(EnemyVent vent, float spawnTime)
	{
		return false;
	}

	private bool EnemyCannotBeSpawned(int enemyIndex)
	{
		return false;
	}

	public void InitializeRandomNumberGenerators()
	{
	}

	public void SpawnEnemyFromVent(EnemyVent vent)
	{
	}

	public void SpawnEnemyOnServer(Vector3 spawnPosition, float yRot, int enemyNumber = -1)
	{
	}

	[ServerRpc]
	public void SpawnEnemyServerRpc(Vector3 spawnPosition, float yRot, int enemyNumber)
	{
	}

	public NetworkObjectReference SpawnEnemyGameObject(Vector3 spawnPosition, float yRot, int enemyNumber, EnemyType enemyType = null)
	{
		return default(NetworkObjectReference);
	}

	public void DespawnEnemyOnServer(NetworkObject enemyNetworkObject)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void DespawnEnemyServerRpc(NetworkObjectReference enemyNetworkObject)
	{
	}

	private void DespawnEnemyGameObject(NetworkObjectReference enemyNetworkObject)
	{
	}

	public void SwitchPower(bool on)
	{
	}

	[ClientRpc]
	public void PowerSwitchOnClientRpc()
	{
	}

	[ClientRpc]
	public void PowerSwitchOffClientRpc()
	{
	}

	public void TurnOnAllLights(bool on)
	{
	}

	[IteratorStateMachine(typeof(_003CturnOnLights_003Ed__152))]
	private IEnumerator turnOnLights(bool turnOn)
	{
		return null;
	}

	public void FlickerLights(bool flickerFlashlights = false, bool disableFlashlights = false)
	{
	}

	[IteratorStateMachine(typeof(_003CFlickerPoweredLights_003Ed__154))]
	private IEnumerator FlickerPoweredLights(bool flickerFlashlights = false, bool disableFlashlights = false)
	{
		return null;
	}

	private void Start()
	{
	}

	private void ResetEnemyTypesSpawnedCounts()
	{
	}

	private void RefreshEnemiesList()
	{
	}

	private void Update()
	{
	}

	private void SpawnInsideEnemiesFromVentsIfReady()
	{
	}

	private void AdvanceHourAndSpawnNewBatchOfEnemies()
	{
	}

	public void RefreshLightsList()
	{
	}

	public void RefreshEnemyVents()
	{
	}

	private void SpawnOutsideHazards()
	{
	}

	private void SpawnRandomStoryLogs()
	{
	}

	public void SetLevelObjectVariables()
	{
	}

	[IteratorStateMachine(typeof(_003CwaitForMainEntranceTeleportToSpawn_003Ed__166))]
	private IEnumerator waitForMainEntranceTeleportToSpawn()
	{
		return null;
	}

	private void SetPowerOffAtStart()
	{
	}

	private void SetBigDoorCodes(Vector3 mainEntrancePosition)
	{
	}

	private void SetExitIDs(Vector3 mainEntrancePosition)
	{
	}

	private void SetSteamValveTimes(Vector3 mainEntrancePosition)
	{
	}

	private void SetLockedDoors(Vector3 mainEntrancePosition)
	{
	}

	[ServerRpc]
	public void LightningStrikeServerRpc(Vector3 strikePosition)
	{
	}

	[ClientRpc]
	public void LightningStrikeClientRpc(Vector3 strikePosition)
	{
	}

	[ServerRpc]
	public void ShowStaticElectricityWarningServerRpc(NetworkObjectReference warningObject, float timeLeft)
	{
	}

	[ClientRpc]
	public void ShowStaticElectricityWarningClientRpc(NetworkObjectReference warningObject, float timeLeft)
	{
	}

	public Vector3 RandomlyOffsetPosition(Vector3 pos, float maxRadius, float padding = 1f)
	{
		return default(Vector3);
	}

	public static Vector3 RandomPointInBounds(Bounds bounds)
	{
		return default(Vector3);
	}

	public Vector3 GetNavMeshPosition(Vector3 pos, NavMeshHit navMeshHit = default(NavMeshHit), float sampleRadius = 5f, int areaMask = -1)
	{
		return default(Vector3);
	}

	public Transform GetClosestNode(Vector3 pos, bool outside = true)
	{
		return null;
	}

	public Vector3 GetRandomNavMeshPositionInRadius(Vector3 pos, float radius = 10f, NavMeshHit navHit = default(NavMeshHit))
	{
		return default(Vector3);
	}

	public Vector3 GetRandomNavMeshPositionInBoxPredictable(Vector3 pos, float radius = 10f, NavMeshHit navHit = default(NavMeshHit), System.Random randomSeed = null, int layerMask = -1)
	{
		return default(Vector3);
	}

	public Vector3 GetRandomPositionInBoxPredictable(Vector3 pos, float radius = 10f, System.Random randomSeed = null)
	{
		return default(Vector3);
	}

	private float RandomNumberInRadius(float radius, System.Random randomSeed)
	{
		return 0f;
	}

	public Vector3 GetRandomNavMeshPositionInRadiusSpherical(Vector3 pos, float radius = 10f, NavMeshHit navHit = default(NavMeshHit))
	{
		return default(Vector3);
	}

	public Vector3 GetRandomPositionInRadius(Vector3 pos, float minRadius, float radius, System.Random randomGen = null)
	{
		return default(Vector3);
	}

	private float RandomFloatWithinRadius(float minValue, float radius, System.Random randomGenerator)
	{
		return 0f;
	}

	public static Vector3 AverageOfLivingGroupedPlayerPositions()
	{
		return default(Vector3);
	}

	public void PlayAudibleNoise(Vector3 noisePosition, float noiseRange = 10f, float noiseLoudness = 0.5f, int timesPlayedInSameSpot = 0, bool noiseIsInsideClosedShip = false, int noiseID = 0)
	{
	}

	public static int PlayRandomClip(AudioSource audioSource, AudioClip[] clipsArray, bool randomize = true, float oneShotVolume = 1f, int audibleNoiseID = 0)
	{
		return 0;
	}

	public static EntranceTeleport FindMainEntranceScript(bool getOutsideEntrance = false)
	{
		return null;
	}

	public static Vector3 FindMainEntrancePosition(bool getTeleportPosition = false, bool getOutsideEntrance = false)
	{
		return default(Vector3);
	}

	public int GetRandomWeightedIndex(int[] weights, System.Random randomSeed = null)
	{
		return 0;
	}

	public int GetRandomWeightedIndexList(List<int> weights, System.Random randomSeed = null)
	{
		return 0;
	}

	public int GetWeightedValue(int indexLength)
	{
		return 0;
	}

	private static int SortBySize(int p1, int p2)
	{
		return 0;
	}
}
