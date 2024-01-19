using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using GameNetcodeStuff;
using Steamworks;
using Steamworks.Data;
using TMPro;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class HUDManager : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDisplaySignalTranslatorMessage_003Ed__254 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int seed;

		public HUDManager _003C_003E4__this;

		public SignalTranslator signalTranslator;

		public string signalMessage;

		private System.Random _003CsignalMessageRandom_003E5__2;

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
		public _003CDisplaySignalTranslatorMessage_003Ed__254(int _003C_003E1__state)
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
	private sealed class _003CFadeUIElement_003Ed__241 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public HUDElement element;

		public float endAlpha;

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
		public _003CFadeUIElement_003Ed__241(int _003C_003E1__state)
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CFillImageWithSteamProfile_003Ed__216 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public bool large;

		public SteamId steamId;

		public RawImage image;

		private TaskAwaiter<Steamworks.Data.Image?> _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003CForceChangeText_003Ed__275 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TextMeshProUGUI textToChange;

		public string changeTextTo;

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
		public _003CForceChangeText_003Ed__275(int _003C_003E1__state)
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetRankAndSubmitScore_003Ed__257 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public HUDManager _003C_003E4__this;

		public int scrapCollected;

		private int _003CweekNum_003E5__2;

		private TaskAwaiter<Leaderboard?> _003C_003Eu__1;

		private TaskAwaiter<LeaderboardUpdate?> _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003CReadOutDialogue_003Ed__244 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HUDManager _003C_003E4__this;

		public DialogueSegment[] dialogueArray;

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
		public _003CReadOutDialogue_003Ed__244(int _003C_003E1__state)
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
	private sealed class _003CSetPlayerLevelSmoothly_003Ed__267 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HUDManager _003C_003E4__this;

		public int XPGain;

		private float _003CchangingPlayerXP_003E5__2;

		private int _003CchangingPlayerLevel_003E5__3;

		private int _003CtargetXPLevel_003E5__4;

		private bool _003CconditionMet_003E5__5;

		private float _003CtimeAtStart_003E5__6;

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
		public _003CSetPlayerLevelSmoothly_003Ed__267(int _003C_003E1__state)
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
	private sealed class _003CTipsPanelTimer_003Ed__285 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string prefsKey;

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
		public _003CTipsPanelTimer_003Ed__285(int _003C_003E1__state)
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
	private sealed class _003CdisplayScrapTimer_003Ed__273 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HUDManager _003C_003E4__this;

		public GameObject displayingObject;

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
		public _003CdisplayScrapTimer_003Ed__273(int _003C_003E1__state)
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
	private sealed class _003CdisplayTipTextTimer_003Ed__283 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HUDManager _003C_003E4__this;

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
		public _003CdisplayTipTextTimer_003Ed__283(int _003C_003E1__state)
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
	private sealed class _003CplayScrapDisplaySFX_003Ed__272 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HUDManager _003C_003E4__this;

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
		public _003CplayScrapDisplaySFX_003Ed__272(int _003C_003E1__state)
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
	private sealed class _003CrackUpNewQuotaText_003Ed__248 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HUDManager _003C_003E4__this;

		private int _003CquotaTextAmount_003E5__2;

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
		public _003CrackUpNewQuotaText_003Ed__248(int _003C_003E1__state)
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
	private sealed class _003CscrollRewardsListText_003Ed__246 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HUDManager _003C_003E4__this;

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
		public _003CscrollRewardsListText_003Ed__246(int _003C_003E1__state)
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
	private sealed class _003CwaitUntilLocalPlayerControllerInitialized_003Ed__201 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HUDManager _003C_003E4__this;

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
		public _003CwaitUntilLocalPlayerControllerInitialized_003Ed__201(int _003C_003E1__state)
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

	public HUDElement Inventory;

	public HUDElement Chat;

	public HUDElement PlayerInfo;

	public HUDElement Tooltips;

	public HUDElement InstabilityCounter;

	public HUDElement Clock;

	private HUDElement[] HUDElements;

	public GameObject HUDContainer;

	public Animator playerScreenShakeAnimator;

	public RawImage playerScreenTexture;

	public Volume playerGraphicsVolume;

	public TextMeshProUGUI weightCounter;

	public Animator weightCounterAnimator;

	[Header("Item UI")]
	public UnityEngine.UI.Image[] itemSlotIcons;

	public UnityEngine.UI.Image[] itemSlotIconFrames;

	[Header("Tooltips")]
	public TextMeshProUGUI[] controlTipLines;

	[Header("Object Scanner")]
	private RaycastHit[] scanNodesHit;

	public RectTransform[] scanElements;

	private bool scanElementsHidden;

	private float playerPingingScan;

	private float updateScanInterval;

	private Dictionary<RectTransform, ScanNodeProperties> scanNodes;

	private List<ScanNodeProperties> nodesOnScreen;

	private TextMeshProUGUI[] scanElementText;

	public Animator scanEffectAnimator;

	public AudioClip scanSFX;

	public AudioClip addToScrapTotalSFX;

	public AudioClip finishAddingToTotalSFX;

	private float addToDisplayTotalInterval;

	private bool addingToDisplayTotal;

	[Space(3f)]
	public TextMeshProUGUI totalValueText;

	public Animator scanInfoAnimator;

	public int totalScrapScanned;

	private int totalScrapScannedDisplayNum;

	private int scannedScrapNum;

	private bool addedToScrapCounterThisFrame;

	[Header("Batteries")]
	public UnityEngine.UI.Image batteryIcon;

	public TextMeshProUGUI batteryInventoryNumber;

	public UnityEngine.UI.Image batteryMeter;

	[Header("Audio")]
	public AudioSource UIAudio;

	public AudioClip criticalInjury;

	public AudioLowPassFilter audioListenerLowPass;

	public AudioClip globalNotificationSFX;

	[Header("Misc UI elements")]
	public TextMeshProUGUI debugText;

	public GameObject errorLogPanel;

	public TextMeshProUGUI errorLogText;

	private string previousErrorReceived;

	public UnityEngine.UI.Image PTTIcon;

	public Animator batteryBlinkUI;

	public TextMeshProUGUI holdingTwoHandedItem;

	public CanvasGroup selfRedCanvasGroup;

	public UnityEngine.UI.Image holdInteractionFillAmount;

	public CanvasGroup holdInteractionCanvasGroup;

	public float holdFillAmount;

	public EndOfGameStatUIElements statsUIElements;

	public Animator gameOverAnimator;

	public Animator quotaAnimator;

	public TextMeshProUGUI HUDQuotaNumerator;

	public TextMeshProUGUI HUDQuotaDenominator;

	public Animator planetIntroAnimator;

	public Animator endgameStatsAnimator;

	public TextMeshProUGUI loadingText;

	public UnityEngine.UI.Image loadingDarkenScreen;

	public TextMeshProUGUI planetInfoSummaryText;

	public TextMeshProUGUI planetInfoHeaderText;

	public TextMeshProUGUI planetRiskLevelText;

	[Header("Text chat")]
	public TextMeshProUGUI chatText;

	public TextMeshProUGUI typingIndicator;

	public TMP_InputField chatTextField;

	public string lastChatMessage;

	public List<string> ChatMessageHistory;

	public Animator playerCouldRecieveTextChatAnimator;

	public StartOfRound playersManager;

	public PlayerActions playerActions;

	public PlayerControllerB localPlayer;

	private bool playerIsCriticallyInjured;

	public TextMeshProUGUI instabilityCounterNumber;

	public TextMeshProUGUI instabilityCounterText;

	private int previousInstability;

	private Terminal terminalScript;

	[Header("Special Graphics")]
	public bool retrievingSteamLeaderboard;

	public Animator signalTranslatorAnimator;

	public TextMeshProUGUI signalTranslatorText;

	public Animator alarmHornEffect;

	public AudioClip shipAlarmHornSFX;

	public Animator deviceChangeAnimator;

	public TextMeshProUGUI deviceChangeText;

	public Animator saveDataIconAnimatorB;

	public Animator HUDAnimator;

	public Animator radiationGraphicAnimator;

	public AudioClip radiationWarningAudio;

	public UnityEngine.UI.Image shipLeavingEarlyIcon;

	private float timeSinceDisplayingStatusEffect;

	public Animator statusEffectAnimator;

	public TextMeshProUGUI statusEffectText;

	[Space(3f)]
	public bool increaseHelmetCondensation;

	public Material helmetCondensationMaterial;

	[Space(3f)]
	public Animator moneyRewardsAnimator;

	public TextMeshProUGUI moneyRewardsTotalText;

	public TextMeshProUGUI moneyRewardsListText;

	private Coroutine scrollRewardTextCoroutine;

	public Scrollbar rewardsScrollbar;

	[Space(3f)]
	public CanvasGroup shockTutorialLeftAlpha;

	[Space(3f)]
	public CanvasGroup shockTutorialRightAlpha;

	public int tutorialArrowState;

	public bool setTutorialArrow;

	[Space(3f)]
	public Animator tipsPanelAnimator;

	public TextMeshProUGUI tipsPanelBody;

	public TextMeshProUGUI tipsPanelHeader;

	public AudioClip[] tipsSFX;

	public AudioClip[] warningSFX;

	private Coroutine tipsPanelCoroutine;

	private bool isDisplayingWarning;

	public Animator globalNotificationAnimator;

	public TextMeshProUGUI globalNotificationText;

	public bool sinkingCoveredFace;

	public Animator sinkingUnderAnimator;

	[Header("Dialogue Box")]
	private Coroutine readDialogueCoroutine;

	public TextMeshProUGUI dialogeBoxHeaderText;

	public TextMeshProUGUI dialogeBoxText;

	public Animator dialogueBoxAnimator;

	public AudioSource dialogueBoxSFX;

	public AudioClip[] dialogueBleeps;

	private Coroutine forceChangeTextCoroutine;

	private bool hudHidden;

	[Header("Spectate UI")]
	private bool hasLoadedSpectateUI;

	private bool hasGottenPlayerSteamProfilePictures;

	public GameObject spectatingPlayerBoxPrefab;

	public Transform SpectateBoxesContainer;

	private Dictionary<Animator, PlayerControllerB> spectatingPlayerBoxes;

	private float updateSpectateBoxesInterval;

	private float yOffsetAmount;

	private int boxesAdded;

	public TextMeshProUGUI spectatingPlayerText;

	private bool displayedSpectatorAFKTip;

	public TextMeshProUGUI spectatorTipText;

	public TextMeshProUGUI holdButtonToEndGameEarlyText;

	public TextMeshProUGUI holdButtonToEndGameEarlyVotesText;

	public UnityEngine.UI.Image holdButtonToEndGameEarlyMeter;

	private float holdButtonToEndGameEarlyHoldTime;

	[Header("Time of day UI")]
	public TextMeshProUGUI clockNumber;

	public UnityEngine.UI.Image clockIcon;

	public Sprite[] clockIcons;

	private string amPM;

	private string newLine;

	[Space(5f)]
	public Animator gasHelmetAnimator;

	public Volume drunknessFilter;

	public CanvasGroup gasImageAlpha;

	public Volume insanityScreenFilter;

	public Volume flashbangScreenFilter;

	public float flashFilter;

	public Volume underwaterScreenFilter;

	public bool setUnderwaterFilter;

	public AudioSource breathingUnderwaterAudio;

	[Header("Player levelling")]
	public PlayerLevel[] playerLevels;

	public int localPlayerLevel;

	public int localPlayerXP;

	public TextMeshProUGUI playerLevelText;

	public TextMeshProUGUI playerLevelXPCounter;

	public UnityEngine.UI.Image playerLevelMeter;

	public AudioClip levelIncreaseSFX;

	public AudioClip levelDecreaseSFX;

	public AudioClip decreaseXPSFX;

	public AudioClip increaseXPSFX;

	public Animator playerLevelBoxAnimator;

	public AudioSource LevellingAudio;

	[Header("Profit quota/deadline")]
	public Animator reachedProfitQuotaAnimator;

	public TextMeshProUGUI newProfitQuotaText;

	public TextMeshProUGUI reachedProfitQuotaBonusText;

	public TextMeshProUGUI profitQuotaDaysLeftText;

	public TextMeshProUGUI profitQuotaDaysLeftText2;

	public AudioClip newProfitQuotaSFX;

	public AudioClip reachedQuotaSFX;

	public AudioClip OneDayToMeetQuotaSFX;

	public AudioClip profitQuotaDaysLeftCalmSFX;

	[Space(3f)]
	public Animator playersFiredAnimator;

	public TextMeshProUGUI EndOfRunStatsText;

	public bool displayingNewQuota;

	[Header("Displaying collected scrap")]
	public List<GrabbableObject> itemsToBeDisplayed;

	public ScrapItemHUDDisplay[] ScrapItemBoxes;

	private int boxesDisplaying;

	public Coroutine displayingItemCoroutine;

	private int bottomBoxIndex;

	public int bottomBoxYPosition;

	public Material hologramMaterial;

	public AudioClip displayCollectedScrapSFX;

	public AudioClip displayCollectedScrapSFXSmall;

	private int nextBoxIndex;

	[Space(5f)]
	public TextMeshProUGUI buildModeControlTip;

	public bool hasSetSavedValues;

	private float noLivingPlayersAtKeyboardTimer;

	public static HUDManager Instance
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

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDeviceChange(InputDevice device, InputDeviceChange deviceChange)
	{
	}

	public void SetSavedValues(int playerObjectId = -1)
	{
	}

	[IteratorStateMachine(typeof(_003CwaitUntilLocalPlayerControllerInitialized_003Ed__201))]
	private IEnumerator waitUntilLocalPlayerControllerInitialized()
	{
		return null;
	}

	public void SetNearDepthOfFieldEnabled(bool enabled)
	{
	}

	public void UpdateHealthUI(int health, bool hurtPlayer = true)
	{
	}

	private void AddChatMessage(string chatMessage, string nameOfUserWhoTyped = "")
	{
	}

	public void AddTextToChatOnServer(string chatMessage, int playerId = -1)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void AddPlayerChatMessageServerRpc(string chatMessage, int playerId)
	{
	}

	[ClientRpc]
	private void AddPlayerChatMessageClientRpc(string chatMessage, int playerId)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void AddTextMessageServerRpc(string chatMessage)
	{
	}

	[ClientRpc]
	private void AddTextMessageClientRpc(string chatMessage)
	{
	}

	private void SubmitChat_performed(InputAction.CallbackContext context)
	{
	}

	private void EnableChat_performed(InputAction.CallbackContext context)
	{
	}

	private void OpenMenu_performed(InputAction.CallbackContext context)
	{
	}

	private void PingScan_performed(InputAction.CallbackContext context)
	{
	}

	private bool CanPlayerScan()
	{
		return false;
	}

	public void UpdateBoxesSpectateUI()
	{
	}

	[AsyncStateMachine(typeof(_003CFillImageWithSteamProfile_003Ed__216))]
	public static void FillImageWithSteamProfile(RawImage image, SteamId steamId, bool large = true)
	{
	}

	public static Texture2D GetTextureFromImage(Steamworks.Data.Image? image)
	{
		return null;
	}

	public void RemoveSpectateUI()
	{
	}

	private void UpdateSpectateBoxSpeakerIcons()
	{
	}

	public void SetSpectatingTextToPlayer(PlayerControllerB playerScript)
	{
	}

	private void DisplayScrapItemsOnHud()
	{
	}

	private void SetScreenFilters()
	{
	}

	private void HelmetCondensationDrops()
	{
	}

	private void UnderwaterScreenFilters()
	{
	}

	private void Update()
	{
	}

	public void SetShipLeaveEarlyVotesText(int votes)
	{
	}

	private void UpdateScanNodes(PlayerControllerB playerScript)
	{
	}

	private void AssignNewNodes(PlayerControllerB playerScript)
	{
	}

	private void AttemptScanNode(ScanNodeProperties node, int i, PlayerControllerB playerScript)
	{
	}

	private bool MeetsScanNodeRequirements(ScanNodeProperties node, PlayerControllerB playerScript)
	{
		return false;
	}

	private bool NodeIsNotVisible(ScanNodeProperties node, int elementIndex)
	{
		return false;
	}

	private void AssignNodeToUIElement(ScanNodeProperties node)
	{
	}

	private void DisableAllScanElements()
	{
	}

	private void AttemptScanNewCreature(int enemyID)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void ScanNewCreatureServerRpc(int enemyID)
	{
	}

	[ClientRpc]
	public void ScanNewCreatureClientRpc(int enemyID)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void GetNewStoryLogServerRpc(int logID)
	{
	}

	[ClientRpc]
	public void GetNewStoryLogClientRpc(int logID)
	{
	}

	private void DisplayGlobalNotification(string displayText)
	{
	}

	public void PingHUDElement(HUDElement element, float delay = 2f, float startAlpha = 1f, float endAlpha = 0.2f)
	{
	}

	[IteratorStateMachine(typeof(_003CFadeUIElement_003Ed__241))]
	private IEnumerator FadeUIElement(HUDElement element, float delay, float endAlpha)
	{
		return null;
	}

	public void HideHUD(bool hide)
	{
	}

	public void ReadDialogue(DialogueSegment[] dialogueArray)
	{
	}

	[IteratorStateMachine(typeof(_003CReadOutDialogue_003Ed__244))]
	private IEnumerator ReadOutDialogue(DialogueSegment[] dialogueArray)
	{
		return null;
	}

	public void DisplayCreditsEarning(int creditsEarned, GrabbableObject[] objectsSold, int newGroupCredits)
	{
	}

	[IteratorStateMachine(typeof(_003CscrollRewardsListText_003Ed__246))]
	private IEnumerator scrollRewardsListText()
	{
		return null;
	}

	public void DisplayNewDeadline(int overtimeBonus)
	{
	}

	[IteratorStateMachine(typeof(_003CrackUpNewQuotaText_003Ed__248))]
	private IEnumerator rackUpNewQuotaText()
	{
		return null;
	}

	public void DisplayDaysLeft(int daysLeft)
	{
	}

	public void ShowPlayersFiredScreen(bool show)
	{
	}

	public void ShakeCamera(ScreenShakeType shakeType)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void UseSignalTranslatorServerRpc(string signalMessage)
	{
	}

	[ClientRpc]
	public void UseSignalTranslatorClientRpc(string signalMessage, int timesSendingMessage)
	{
	}

	[IteratorStateMachine(typeof(_003CDisplaySignalTranslatorMessage_003Ed__254))]
	private IEnumerator DisplaySignalTranslatorMessage(string signalMessage, int seed, SignalTranslator signalTranslator)
	{
		return null;
	}

	public void ToggleHUD(bool enable)
	{
	}

	public void FillChallengeResultsStats(int scrapCollected)
	{
	}

	[AsyncStateMachine(typeof(_003CGetRankAndSubmitScore_003Ed__257))]
	public void GetRankAndSubmitScore(int scrapCollected)
	{
	}

	public void FillEndGameStats(EndOfGameStats stats, int scrapCollected = 0)
	{
	}

	[ServerRpc]
	public void SyncAllPlayerLevelsServerRpc()
	{
	}

	[ClientRpc]
	public void SyncAllPlayerLevelsClientRpc(int[] playerLevelNumbers, bool[] playersHaveBeta)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SyncPlayerLevelServerRpc(int playerId, int playerLevelIndex, bool hasBeta = false)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SyncAllPlayerLevelsServerRpc(int newPlayerLevel, int playerClientId)
	{
	}

	[ClientRpc]
	public void SyncAllPlayerLevelsClientRpc(int[] allPlayerLevels, int connectedPlayers)
	{
	}

	[ClientRpc]
	public void SyncPlayerLevelClientRpc(int playerId, int playerLevelIndex, bool hasBeta)
	{
	}

	public void SetLevelOfPlayer(PlayerControllerB playerScript, int playerLevelIndex, bool hasBeta)
	{
	}

	public void SetPlayerLevel(bool isDead, bool mostProfitable, bool allPlayersDead)
	{
	}

	[IteratorStateMachine(typeof(_003CSetPlayerLevelSmoothly_003Ed__267))]
	private IEnumerator SetPlayerLevelSmoothly(int XPGain)
	{
		return null;
	}

	public void ApplyPenalty(int playersDead, int bodiesInsured)
	{
	}

	public void SetQuota(int numerator, int denominator = -1)
	{
	}

	public void AddNewScrapFoundToDisplay(GrabbableObject GObject)
	{
	}

	public void DisplayNewScrapFound()
	{
	}

	[IteratorStateMachine(typeof(_003CplayScrapDisplaySFX_003Ed__272))]
	private IEnumerator playScrapDisplaySFX()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CdisplayScrapTimer_003Ed__273))]
	private IEnumerator displayScrapTimer(GameObject displayingObject)
	{
		return null;
	}

	public void ChangeControlTip(int toolTipNumber, string changeTo, bool clearAllOther = false)
	{
	}

	[IteratorStateMachine(typeof(_003CForceChangeText_003Ed__275))]
	private IEnumerator ForceChangeText(TextMeshProUGUI textToChange, string changeTextTo)
	{
		return null;
	}

	public void ClearControlTips()
	{
	}

	public void ChangeControlTipMultiple(string[] allLines, bool holdingItem = false, Item itemProperties = null)
	{
	}

	public void SetDebugText(string setText)
	{
	}

	public void DisplayStatusEffect(string statusEffect)
	{
	}

	public void DisplayTip(string headerText, string bodyText, bool isWarning = false, bool useSave = false, string prefsKey = "LC_Tip1")
	{
	}

	private void DisplaySpectatorVoteTip()
	{
	}

	private void DisplaySpectatorTip(string tipText)
	{
	}

	[IteratorStateMachine(typeof(_003CdisplayTipTextTimer_003Ed__283))]
	private IEnumerator displayTipTextTimer()
	{
		return null;
	}

	private bool CanTipDisplay(bool isWarning, bool useSave, string prefsKey)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CTipsPanelTimer_003Ed__285))]
	private IEnumerator TipsPanelTimer(string prefsKey)
	{
		return null;
	}

	public string SetClock(float timeNormalized, float numberOfHours, bool createNewLine = true)
	{
		return null;
	}

	public void SetClockIcon(DayMode dayMode)
	{
	}

	public void SetClockVisible(bool visible)
	{
	}

	public void TriggerAlarmHornEffect()
	{
	}

	[ServerRpc]
	public void AlarmHornServerRpc()
	{
	}

	[ClientRpc]
	public void AlarmHornClientRpc()
	{
	}

	public void RadiationWarningHUD()
	{
	}

	public void UpdateInstabilityPercentage(int percentage)
	{
	}

	[ClientRpc]
	public void UpdateInstabilityClientRpc(int percentage)
	{
	}

	public void SetTutorialArrow(int state)
	{
	}

	public bool HoldInteractionFill(float timeToHold, float speedMultiplier = 1f)
	{
		return false;
	}

	public void ToggleErrorConsole()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SendErrorMessageServerRpc(string errorMessage, int sentByPlayerNum)
	{
	}

	public void AddToErrorLog(string errorMessage, int sentByPlayerNum)
	{
	}
}
