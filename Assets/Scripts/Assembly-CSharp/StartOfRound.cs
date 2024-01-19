using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dissonance;
using GameNetcodeStuff;
using TMPro;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class StartOfRound : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass217_0
	{
		public StartOfRound _003C_003E4__this;

		public float startTime;

		internal bool _003CStartSpatialVoiceChat_003Eb__0()
		{
			return false;
		}

		internal bool _003CStartSpatialVoiceChat_003Eb__1()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass313_0
	{
		public NetworkObjectReference objectRef;

		public NetworkObject testRoomNetObject;

		internal bool _003CSetTestRoomDebug_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CEndOfGame_003Ed__260 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StartOfRound _003C_003E4__this;

		public int scrapCollected;

		public int bodiesInsured;

		public int connectedPlayersOnServer;

		private int _003CplayersDead_003E5__2;

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
		public _003CEndOfGame_003Ed__260(int _003C_003E1__state)
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
	private sealed class _003COpenShipDoors_003Ed__245 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StartOfRound _003C_003E4__this;

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
		public _003COpenShipDoors_003Ed__245(int _003C_003E1__state)
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
	private sealed class _003CResetDissonanceCommsComponent_003Ed__281 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StartOfRound _003C_003E4__this;

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
		public _003CResetDissonanceCommsComponent_003Ed__281(int _003C_003E1__state)
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
	private sealed class _003CSetTestRoomDebug_003Ed__313 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NetworkObjectReference objectRef;

		private _003C_003Ec__DisplayClass313_0 _003C_003E8__1;

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
		public _003CSetTestRoomDebug_003Ed__313(int _003C_003E1__state)
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
	private sealed class _003CStartSpatialVoiceChat_003Ed__217 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StartOfRound _003C_003E4__this;

		private _003C_003Ec__DisplayClass217_0 _003C_003E8__1;

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
		public _003CStartSpatialVoiceChat_003Ed__217(int _003C_003E1__state)
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
	private sealed class _003CTravelToLevelEffects_003Ed__299 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StartOfRound _003C_003E4__this;

		private StartMatchLever _003Clever_003E5__2;

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
		public _003CTravelToLevelEffects_003Ed__299(int _003C_003E1__state)
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
	private sealed class _003CUpdatePlayerVoiceEffectsOnDelay_003Ed__218 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StartOfRound _003C_003E4__this;

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
		public _003CUpdatePlayerVoiceEffectsOnDelay_003Ed__218(int _003C_003E1__state)
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
	private sealed class _003CfadeVolume_003Ed__257 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float finalVolume;

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
		public _003CfadeVolume_003Ed__257(int _003C_003E1__state)
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
	private sealed class _003CfirstDayAnimation_003Ed__273 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool waitForMenuToClose;

		public StartOfRound _003C_003E4__this;

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
		public _003CfirstDayAnimation_003Ed__273(int _003C_003E1__state)
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
	private sealed class _003CgameOverAnimation_003Ed__241 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StartOfRound _003C_003E4__this;

		public bool leavingOnMidnight;

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
		public _003CgameOverAnimation_003Ed__241(int _003C_003E1__state)
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
	private sealed class _003CopeningDoorsSequence_003Ed__246 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StartOfRound _003C_003E4__this;

		private StartMatchLever _003CleverScript_003E5__2;

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
		public _003CopeningDoorsSequence_003Ed__246(int _003C_003E1__state)
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
	private sealed class _003CplayDaysLeftAlertSFXDelayed_003Ed__263 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StartOfRound _003C_003E4__this;

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
		public _003CplayDaysLeftAlertSFXDelayed_003Ed__263(int _003C_003E1__state)
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
	private sealed class _003CplayRandomShipAudio_003Ed__280 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StartOfRound _003C_003E4__this;

		private System.Random _003CshipRandom_003E5__2;

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
		public _003CplayRandomShipAudio_003Ed__280(int _003C_003E1__state)
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
	private sealed class _003CplayersFiredGameOver_003Ed__268 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StartOfRound _003C_003E4__this;

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
		public _003CplayersFiredGameOver_003Ed__268(int _003C_003E1__state)
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
	private sealed class _003CsetPlayerToSpawnPosition_003Ed__233 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform playerBody;

		public Vector3 spawnPos;

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
		public _003CsetPlayerToSpawnPosition_003Ed__233(int _003C_003E1__state)
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
	private sealed class _003CunloadSceneForAllPlayers_003Ed__254 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StartOfRound _003C_003E4__this;

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
		public _003CunloadSceneForAllPlayers_003Ed__254(int _003C_003E1__state)
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
	private sealed class _003CwaitingForOtherPlayersToRevive_003Ed__283 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StartOfRound _003C_003E4__this;

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
		public _003CwaitingForOtherPlayersToRevive_003Ed__283(int _003C_003E1__state)
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

	public bool shouldApproveConnection;

	public bool allowLocalPlayerDeath;

	[Space(3f)]
	public int connectedPlayersAmount;

	public int thisClientPlayerId;

	public List<ulong> fullyLoadedPlayers;

	public int livingPlayers;

	private bool mostRecentlyJoinedClient;

	public bool allPlayersDead;

	public Dictionary<ulong, int> ClientPlayerList;

	public List<ulong> KickedClientIds;

	public int daysPlayersSurvivedInARow;

	[Space(5f)]
	private bool hasHostSpawned;

	public bool inShipPhase;

	public float timeSinceRoundStarted;

	public bool shipIsLeaving;

	public bool displayedLevelResults;

	public bool newGameIsLoading;

	private int playersRevived;

	public EndOfGameStats gameStats;

	private bool localPlayerWasMostProfitableThisRound;

	[Header("Important objects")]
	public Camera spectateCamera;

	public AudioListener audioListener;

	[HideInInspector]
	public bool overrideSpectateCamera;

	public GameObject[] allPlayerObjects;

	public PlayerControllerB[] allPlayerScripts;

	public Transform[] playerSpawnPositions;

	public Transform outsideShipSpawnPosition;

	public Transform notSpawnedPosition;

	public Transform propsContainer;

	public Transform elevatorTransform;

	public Transform playersContainer;

	public PlayerControllerB localPlayerController;

	public List<PlayerControllerB> OtherClients;

	[Space(3f)]
	public UnlockablesList unlockablesList;

	public AudioClip changeSuitSFX;

	public GameObject suitPrefab;

	public int suitsPlaced;

	public Transform rightmostSuitPosition;

	[Space(5f)]
	public GameObject playerPrefab;

	public GameObject ragdollGrabbableObjectPrefab;

	public List<GameObject> playerRagdolls;

	public GameObject playerBloodPrefab;

	public Transform bloodObjectsContainer;

	public Camera introCamera;

	public Camera activeCamera;

	public SimpleEvent CameraSwitchEvent;

	public SimpleEvent StartNewRoundEvent;

	public GameObject testRoom;

	public GameObject testRoomPrefab;

	public Transform testRoomSpawnPosition;

	public bool localClientHasControl;

	public RuntimeAnimatorController localClientAnimatorController;

	public RuntimeAnimatorController otherClientsAnimatorController;

	public int playersMask;

	public int collidersAndRoomMask;

	public int collidersAndRoomMaskAndPlayers;

	public int collidersAndRoomMaskAndDefault;

	public int collidersRoomMaskDefaultAndPlayers;

	public int collidersRoomDefaultAndFoliage;

	public int allPlayersCollideWithMask;

	public int walkableSurfacesMask;

	[Header("Physics")]
	public Collider[] PlayerPhysicsColliders;

	[Header("Ship Animations")]
	public NetworkObject shipAnimatorObject;

	public Animator shipAnimator;

	public AudioSource shipAmbianceAudio;

	public AudioSource ship3DAudio;

	public AudioClip shipDepartSFX;

	public AudioClip shipArriveSFX;

	public AudioSource shipDoorAudioSource;

	public AudioSource speakerAudioSource;

	public AudioClip suckedIntoSpaceSFX;

	public AudioClip airPressureSFX;

	public AudioClip[] shipCreakSFX;

	public AudioClip alarmSFX;

	public AudioClip firedVoiceSFX;

	public AudioClip openingHangarDoorAudio;

	public AudioClip allPlayersDeadAudio;

	public AudioClip shipIntroSpeechSFX;

	public AudioClip disableSpeakerSFX;

	public AudioClip zeroDaysLeftAlertSFX;

	public bool shipLeftAutomatically;

	public DialogueSegment[] openingDoorDialogue;

	public DialogueSegment[] gameOverDialogue;

	public DialogueSegment[] shipLeavingOnMidnightDialogue;

	public bool shipDoorsEnabled;

	public bool shipHasLanded;

	public Animator shipDoorsAnimator;

	public bool hangarDoorsClosed;

	private Coroutine shipTravelCoroutine;

	public ShipLights shipRoomLights;

	public AnimatedObjectTrigger closetLeftDoor;

	public AnimatedObjectTrigger closetRightDoor;

	public GameObject starSphereObject;

	public Dictionary<int, GameObject> SpawnedShipUnlockables;

	public Transform gameOverCameraHandle;

	public Transform freeCinematicCameraTurnCompass;

	public Camera freeCinematicCamera;

	[Header("Players fired animation")]
	public bool firingPlayersCutsceneRunning;

	public bool suckingPlayersOutOfShip;

	private bool choseRandomFlyDirForPlayer;

	private Vector3 randomFlyDir;

	public float suckingPower;

	public bool suckingFurnitureOutOfShip;

	public Transform middleOfShipNode;

	public Transform shipDoorNode;

	public Transform middleOfSpaceNode;

	public Transform moveAwayFromShipNode;

	[Header("Level selection")]
	public GameObject currentPlanetPrefab;

	public Animator currentPlanetAnimator;

	public Animator outerSpaceSunAnimator;

	public Transform planetContainer;

	public SelectableLevel[] levels;

	public SelectableLevel currentLevel;

	public int currentLevelID;

	public bool isChallengeFile;

	public bool hasSubmittedChallengeRank;

	public int defaultPlanet;

	public bool travellingToNewLevel;

	public AnimationCurve planetsWeatherRandomCurve;

	public int maxShipItemCapacity;

	public int currentShipItemCount;

	[Header("Ship Monitors")]
	public TextMeshProUGUI screenLevelDescription;

	public VideoPlayer screenLevelVideoReel;

	public TextMeshProUGUI mapScreenPlayerName;

	public ManualCameraRenderer mapScreen;

	public GameObject objectCodePrefab;

	public GameObject itemRadarIconPrefab;

	[Space(5f)]
	public Image deadlineMonitorBGImage;

	public Image profitQuotaMonitorBGImage;

	public TextMeshProUGUI deadlineMonitorText;

	public TextMeshProUGUI profitQuotaMonitorText;

	public GameObject upperMonitorsCanvas;

	public Canvas radarCanvas;

	[Header("Randomization")]
	public int randomMapSeed;

	public bool overrideRandomSeed;

	public int overrideSeedNumber;

	public AnimationCurve objectFallToGroundCurve;

	public AnimationCurve objectFallToGroundCurveNoBounce;

	public AnimationCurve playerSinkingCurve;

	[Header("Voice chat")]
	public DissonanceComms voiceChatModule;

	public float averageVoiceAmplitude;

	public int movingAverageLength;

	public int averageCount;

	private float voiceChatNoiseCooldown;

	public bool updatedPlayerVoiceEffectsThisFrame;

	[Header("Player Audios")]
	public AudioMixerGroup playersVoiceMixerGroup;

	public FootstepSurface[] footstepSurfaces;

	public string[] naturalSurfaceTags;

	public AudioClip[] statusEffectClips;

	public AudioClip HUDSystemAlertSFX;

	public AudioClip playerJumpSFX;

	public AudioClip playerHitGroundSoft;

	public AudioClip playerHitGroundHard;

	public AudioClip damageSFX;

	public AudioClip fallDamageSFX;

	public AudioClip bloodGoreSFX;

	[Space(5f)]
	public float drowningTimer;

	[HideInInspector]
	public bool playedDrowningSFX;

	public AudioClip[] bodyCollisionSFX;

	public AudioClip playerFallDeath;

	public AudioClip hitPlayerSFX;

	private Coroutine fadeVolumeCoroutine;

	public List<DecalProjector> snowFootprintsPooledObjects;

	public GameObject footprintDecal;

	public int currentFootprintIndex;

	public GameObject explosionPrefab;

	public float fearLevel;

	public bool fearLevelIncreasing;

	[Header("Company building game loop")]
	public float companyBuyingRate;

	public int hoursSinceLastCompanyVisit;

	public AudioClip companyVisitMusic;

	public bool localPlayerUsingController;

	private bool subscribedToConnectionApproval;

	public Collider shipBounds;

	public Collider shipInnerRoomBounds;

	private Coroutine updateVoiceEffectsCoroutine;

	public ReverbPreset shipReverb;

	public AnimationCurve drunknessSpeedEffect;

	public AnimationCurve drunknessSideEffect;

	private float updatePlayerVoiceInterval;

	public Volume blackSkyVolume;

	[Space(5f)]
	public AllItemsList allItemsList;

	public InteractEvent playerTeleportedEvent;

	[Space(3f)]
	public string[] randomNames;

	public float timeAtStartOfRun;

	public float playerLookMagnitudeThisFrame;

	public float timeAtMakingLastPersonalMovement;

	public Transform[] insideShipPositions;

	public int scrapCollectedLastRound;

	public static StartOfRound Instance
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

	public void InstantiateFootprintsPooledObjects()
	{
	}

	private void ResetPooledObjects(bool destroy = false)
	{
	}

	private void Awake()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void PlayerLoadedServerRpc(ulong clientId)
	{
	}

	[ClientRpc]
	private void PlayerLoadedClientRpc(ulong clientId)
	{
	}

	[ClientRpc]
	private void ResetPlayersLoadedValueClientRpc(bool landingShip = false)
	{
	}

	private void SceneManager_OnLoadComplete1(ulong clientId, string sceneName, LoadSceneMode loadSceneMode)
	{
	}

	private void SceneManager_OnUnloadComplete(ulong clientId, string sceneName)
	{
	}

	private void SceneManager_OnLoad(ulong clientId, string sceneName, LoadSceneMode loadSceneMode, AsyncOperation asyncOperation)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void DisableSpatializationOnAllAudio()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void BuyShipUnlockableServerRpc(int unlockableID, int newGroupCreditsAmount)
	{
	}

	[ClientRpc]
	public void BuyShipUnlockableClientRpc(int newGroupCreditsAmount, int unlockableID = -1)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void ReturnUnlockableFromStorageServerRpc(int unlockableID)
	{
	}

	[ClientRpc]
	public void ReturnUnlockableFromStorageClientRpc(int unlockableID)
	{
	}

	private void UnlockShipObject(int unlockableID)
	{
	}

	private void LoadUnlockables()
	{
	}

	private void SpawnUnlockable(int unlockableIndex)
	{
	}

	[ServerRpc]
	public void SyncSuitsServerRpc()
	{
	}

	[ClientRpc]
	public void SyncSuitsClientRpc()
	{
	}

	private void LoadShipGrabbableItems()
	{
	}

	private void SetTimeAndPlanetToSavedSettings()
	{
	}

	[IteratorStateMachine(typeof(_003CStartSpatialVoiceChat_003Ed__217))]
	private IEnumerator StartSpatialVoiceChat()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CUpdatePlayerVoiceEffectsOnDelay_003Ed__218))]
	private IEnumerator UpdatePlayerVoiceEffectsOnDelay()
	{
		return null;
	}

	public void KickPlayer(int playerObjToKick)
	{
	}

	public void OnLocalDisconnect()
	{
	}

	public void OnClientDisconnect(ulong clientId)
	{
	}

	[ClientRpc]
	public void OnClientDisconnectClientRpc(int playerObjectNumber, ulong clientId, ClientRpcParams clientRpcParams = default(ClientRpcParams))
	{
	}

	public void OnPlayerDC(int playerObjectNumber, ulong clientId)
	{
	}

	public void OnClientConnect(ulong clientId)
	{
	}

	[ClientRpc]
	private void OnPlayerConnectedClientRpc(ulong clientId, int connectedPlayers, ulong[] connectedPlayerIdsOrdered, int assignedPlayerObjectId, int serverMoneyAmount, int levelID, int profitQuota, int timeUntilDeadline, int quotaFulfilled, int randomSeed, bool isChallenge)
	{
	}

	private Vector3 GetPlayerSpawnPosition(int playerNum, bool simpleTeleport = false)
	{
		return default(Vector3);
	}

	[ServerRpc(RequireOwnership = false)]
	public void SyncAlreadyHeldObjectsServerRpc(int joiningClientId)
	{
	}

	[ClientRpc]
	public void SyncAlreadyHeldObjectsClientRpc(NetworkObjectReference[] gObjects, int[] playersHeldBy, int[] itemSlotNumbers, int[] isObjectPocketed, int syncWithClient)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SyncShipUnlockablesServerRpc()
	{
	}

	private void PositionSuitsOnRack()
	{
	}

	[ClientRpc]
	public void SyncShipUnlockablesClientRpc(int[] playerSuitIDs, bool shipLightsOn, Vector3[] placeableObjectPositions, Vector3[] placeableObjectRotations, int[] placeableObjects, int[] storedItems, int[] scrapValues, int[] itemSaveData)
	{
	}

	public void StartTrackingAllPlayerVoices()
	{
	}

	[IteratorStateMachine(typeof(_003CsetPlayerToSpawnPosition_003Ed__233))]
	private IEnumerator setPlayerToSpawnPosition(Transform playerBody, Vector3 spawnPos)
	{
		return null;
	}

	private void Update()
	{
	}

	private string NoPunctuation(string input)
	{
		return null;
	}

	private void SuckLocalPlayerOutOfShipDoor()
	{
	}

	private void DetectVoiceChatAmplitude()
	{
	}

	public void ShipLeaveAutomatically(bool leavingOnMidnight = false)
	{
	}

	public void SetSpectateCameraToGameOverMode(bool enableGameOver, PlayerControllerB localPlayer = null)
	{
	}

	public void SwitchCamera(Camera newCamera)
	{
	}

	[IteratorStateMachine(typeof(_003CgameOverAnimation_003Ed__241))]
	private IEnumerator gameOverAnimation(bool leavingOnMidnight)
	{
		return null;
	}

	[ServerRpc(RequireOwnership = false)]
	public void StartGameServerRpc()
	{
	}

	public void StartGame()
	{
	}

	public void ChooseNewRandomMapSeed()
	{
	}

	[IteratorStateMachine(typeof(_003COpenShipDoors_003Ed__245))]
	private IEnumerator OpenShipDoors()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CopeningDoorsSequence_003Ed__246))]
	public IEnumerator openingDoorsSequence()
	{
		return null;
	}

	private void OnShipLandedMiscEvents()
	{
	}

	public void ForcePlayerIntoShip()
	{
	}

	public void SetPlayerObjectExtrapolate(bool enable)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void EndGameServerRpc(int playerClientId)
	{
	}

	[ClientRpc]
	public void EndGameClientRpc(int playerClientId)
	{
	}

	private void ShipLeave()
	{
	}

	public void ShipHasLeft()
	{
	}

	[IteratorStateMachine(typeof(_003CunloadSceneForAllPlayers_003Ed__254))]
	private IEnumerator unloadSceneForAllPlayers()
	{
		return null;
	}

	private int GetBodiesInShip()
	{
		return 0;
	}

	[ClientRpc]
	public void EndOfGameClientRpc(int bodiesInsured, int daysPlayersSurvived, int connectedPlayersOnServer, int scrapCollectedOnServer)
	{
	}

	[IteratorStateMachine(typeof(_003CfadeVolume_003Ed__257))]
	private IEnumerator fadeVolume(float finalVolume)
	{
		return null;
	}

	public void ResetStats()
	{
	}

	public void WritePlayerNotes()
	{
	}

	[IteratorStateMachine(typeof(_003CEndOfGame_003Ed__260))]
	private IEnumerator EndOfGame(int bodiesInsured = 0, int connectedPlayersOnServer = 0, int scrapCollected = 0)
	{
		return null;
	}

	private int[] GetEndgameStatsInOrder()
	{
		return null;
	}

	private void PassTimeToNextDay(int connectedPlayersOnServer = 0)
	{
	}

	[IteratorStateMachine(typeof(_003CplayDaysLeftAlertSFXDelayed_003Ed__263))]
	private IEnumerator playDaysLeftAlertSFXDelayed()
	{
		return null;
	}

	[ClientRpc]
	public void AllPlayersHaveRevivedClientRpc()
	{
	}

	private void AutoSaveShipData()
	{
	}

	[ServerRpc]
	public void ManuallyEjectPlayersServerRpc()
	{
	}

	[ClientRpc]
	public void FirePlayersAfterDeadlineClientRpc(int[] endGameStats, bool abridgedVersion = false)
	{
	}

	[IteratorStateMachine(typeof(_003CplayersFiredGameOver_003Ed__268))]
	private IEnumerator playersFiredGameOver(bool abridgedVersion)
	{
		return null;
	}

	public void ResetShip()
	{
	}

	private void ResetShipFurniture(bool onlyClearBoughtFurniture = false, bool despawnProps = true)
	{
	}

	[ClientRpc]
	public void EndPlayersFiredSequenceClientRpc()
	{
	}

	private void PlayFirstDayShipAnimation(bool waitForMenuToClose = false)
	{
	}

	[IteratorStateMachine(typeof(_003CfirstDayAnimation_003Ed__273))]
	private IEnumerator firstDayAnimation(bool waitForMenuToClose)
	{
		return null;
	}

	public void DisableShipSpeaker()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void StopShipSpeakerServerRpc(int playerWhoTriggered)
	{
	}

	[ClientRpc]
	public void StopShipSpeakerClientRpc(int playerWhoTriggered)
	{
	}

	private void DisableShipSpeakerLocalClient()
	{
	}

	public void SetPlanetsWeather(int connectedPlayersOnServer = 0)
	{
	}

	private void SetShipReadyToLand()
	{
	}

	[IteratorStateMachine(typeof(_003CplayRandomShipAudio_003Ed__280))]
	private IEnumerator playRandomShipAudio()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CResetDissonanceCommsComponent_003Ed__281))]
	private IEnumerator ResetDissonanceCommsComponent()
	{
		return null;
	}

	[ServerRpc(RequireOwnership = false)]
	public void PlayerHasRevivedServerRpc()
	{
	}

	[IteratorStateMachine(typeof(_003CwaitingForOtherPlayersToRevive_003Ed__283))]
	private IEnumerator waitingForOtherPlayersToRevive()
	{
		return null;
	}

	public void ReviveDeadPlayers()
	{
	}

	private void ResetMiscValues()
	{
	}

	public void RefreshPlayerVoicePlaybackObjects()
	{
	}

	public void UpdatePlayerVoiceEffects()
	{
	}

	[ServerRpc]
	public void SetShipDoorsOverheatServerRpc()
	{
	}

	[ClientRpc]
	public void SetShipDoorsOverheatClientRpc()
	{
	}

	public void SetShipDoorsClosed(bool closed)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SetDoorsClosedServerRpc(bool closed)
	{
	}

	[ClientRpc]
	public void SetDoorsClosedClientRpc(bool closed)
	{
	}

	public void SetPlayerSafeInShip()
	{
	}

	public bool CanChangeLevels()
	{
		return false;
	}

	[ServerRpc(RequireOwnership = false)]
	public void ChangeLevelServerRpc(int levelID, int newGroupCreditsAmount)
	{
	}

	[ClientRpc]
	public void CancelChangeLevelClientRpc(int groupCreditsAmount)
	{
	}

	[ClientRpc]
	public void ChangeLevelClientRpc(int levelID, int newGroupCreditsAmount)
	{
	}

	public void ChangeLevel(int levelID)
	{
	}

	[IteratorStateMachine(typeof(_003CTravelToLevelEffects_003Ed__299))]
	private IEnumerator TravelToLevelEffects()
	{
		return null;
	}

	public void ArriveAtLevel()
	{
	}

	public void ChangePlanet()
	{
	}

	public void SetMapScreenInfoToCurrentLevel()
	{
	}

	public void SwitchMapMonitorPurpose(bool displayInfo = false)
	{
	}

	public void PowerSurgeShip()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SyncCompanyBuyingRateServerRpc()
	{
	}

	[ClientRpc]
	public void SyncCompanyBuyingRateClientRpc(float buyingRate)
	{
	}

	private void TeleportPlayerInShipIfOutOfRoomBounds()
	{
	}

	public void LateUpdate()
	{
	}

	public override void OnDestroy()
	{
	}

	[ServerRpc]
	public void Debug_EnableTestRoomServerRpc(bool enable)
	{
	}

	public bool IsClientFriendsWithHost()
	{
		return false;
	}

	[ClientRpc]
	public void Debug_EnableTestRoomClientRpc(bool enable, NetworkObjectReference objectRef = default(NetworkObjectReference))
	{
	}

	[IteratorStateMachine(typeof(_003CSetTestRoomDebug_003Ed__313))]
	private IEnumerator SetTestRoomDebug(NetworkObjectReference objectRef)
	{
		return null;
	}

	[ServerRpc]
	public void Debug_ToggleAllowDeathServerRpc()
	{
	}

	[ClientRpc]
	public void Debug_ToggleAllowDeathClientRpc(bool allowDeath)
	{
	}

	public void SetDiscordStatusDetails()
	{
	}

	public int GetValueOfAllScrap(bool onlyScrapCollected = true, bool onlyNewScrap = false)
	{
		return 0;
	}
}
