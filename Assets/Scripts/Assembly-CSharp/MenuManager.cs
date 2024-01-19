using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dissonance;
using Steamworks;
using Steamworks.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCreateLeaderboardSlots_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LeaderboardEntry[] entries;

		public MenuManager _003C_003E4__this;

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
		public _003CCreateLeaderboardSlots_003Ed__83(int _003C_003E1__state)
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
	private struct _003CGetLeaderboardForChallenge_003Ed__80 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MenuManager _003C_003E4__this;

		public bool submitScore;

		private TaskAwaiter<Leaderboard?> _003C_003Eu__1;

		private TaskAwaiter<LeaderboardUpdate?> _003C_003Eu__2;

		private TaskAwaiter<LeaderboardEntry[]> _003C_003Eu__3;

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
	private sealed class _003CPlayMenuMusicDelayed_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MenuManager _003C_003E4__this;

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
		public _003CPlayMenuMusicDelayed_003Ed__72(int _003C_003E1__state)
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
	private struct _003CRemoveLeaderboardScore_003Ed__76 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MenuManager _003C_003E4__this;

		private TaskAwaiter<Leaderboard?> _003C_003Eu__1;

		private TaskAwaiter<LeaderboardUpdate?> _003C_003Eu__2;

		private TaskAwaiter<LeaderboardEntry[]> _003C_003Eu__3;

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
	private sealed class _003CconnectionTimeOut_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MenuManager _003C_003E4__this;

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
		public _003CconnectionTimeOut_003Ed__85(int _003C_003E1__state)
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
	private sealed class _003CdelayedStartScene_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MenuManager _003C_003E4__this;

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
		public _003CdelayedStartScene_003Ed__91(int _003C_003E1__state)
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

	public GameObject menuButtons;

	public bool isInitScene;

	[Space(5f)]
	public GameObject menuNotification;

	public TextMeshProUGUI menuNotificationText;

	public TextMeshProUGUI menuNotificationButtonText;

	public TextMeshProUGUI versionNumberText;

	[Space(5f)]
	public TextMeshProUGUI loadingText;

	public GameObject loadingScreen;

	[Space(5f)]
	public GameObject lanButtonContainer;

	public GameObject lanWarningContainer;

	public GameObject joinCrewButtonContainer;

	public TextMeshProUGUI launchedInLanModeText;

	[Space(3f)]
	public GameObject serverListUIContainer;

	public AudioListener menuListener;

	public TextMeshProUGUI tipTextHostSettings;

	[Space(5f)]
	public TextMeshProUGUI logText;

	public GameObject inputFieldGameObject;

	[Space(5f)]
	public GameObject NewsPanel;

	[Space(5f)]
	public GameObject HostSettingsScreen;

	public TMP_InputField lobbyNameInputField;

	public TMP_InputField lobbyTagInputField;

	public bool hostSettings_LobbyPublic;

	public Animator setPublicButtonAnimator;

	public Animator setPrivateButtonAnimator;

	public TextMeshProUGUI privatePublicDescription;

	[SerializeField]
	private Button startHostButton;

	[SerializeField]
	private Button startClientButton;

	[SerializeField]
	private Button leaveButton;

	public GameObject HostSettingsOptionsLAN;

	public GameObject HostSettingsOptionsNormal;

	public Animator lanSetLocalButtonAnimator;

	public Animator lanSetAllowRemoteButtonAnimator;

	[SerializeField]
	private TMP_InputField joinCodeInput;

	private bool hasServerStarted;

	private bool startingAClient;

	private int currentMicrophoneDevice;

	public TextMeshProUGUI currentMicrophoneText;

	public DissonanceComms comms;

	public AudioSource MenuAudio;

	public AudioClip menuMusic;

	public AudioClip openMenuSound;

	public Animator menuAnimator;

	public TextMeshProUGUI changesNotAppliedText;

	public TextMeshProUGUI settingsBackButton;

	public GameObject PleaseConfirmChangesSettingsPanel;

	public Button PleaseConfirmChangesSettingsPanelBackButton;

	public GameObject KeybindsPanel;

	private bool selectingUIThisFrame;

	private GameObject lastSelectedGameObject;

	private bool playSelectAudioThisFrame;

	public bool[] filesCompatible;

	private Leaderboard? challengeLeaderboard;

	public GameObject leaderboardContainer;

	public GameObject leaderboardSlotPrefab;

	public Transform leaderboardSlotsContainer;

	public int leaderboardSlotOffset;

	public int leaderboardFilterType;

	public bool requestingLeaderboard;

	public GameObject hostSettingsPanel;

	public bool hasChallengeBeenCompleted;

	public int challengeScore;

	public Animator submittedRankAnimator;

	public AudioClip submitRankSFX;

	public TextMeshProUGUI submittedRankText;

	private Coroutine displayLeaderboardSlotsCoroutine;

	public TextMeshProUGUI leaderboardHeaderText;

	public TextMeshProUGUI leaderboardLoadingText;

	public GameObject removeScoreButton;

	private void Update()
	{
	}

	public void PlayConfirmSFX()
	{
	}

	public void PlayCancelSFX()
	{
	}

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayMenuMusicDelayed_003Ed__72))]
	private IEnumerator PlayMenuMusicDelayed()
	{
		return null;
	}

	private void Start()
	{
	}

	private void SetIfChallengeMoonHasBeenCompleted()
	{
	}

	public void EnableLeaderboardDisplay(bool enable)
	{
	}

	[AsyncStateMachine(typeof(_003CRemoveLeaderboardScore_003Ed__76))]
	private void RemoveLeaderboardScore()
	{
	}

	public void SetLeaderboardFilter(int filterId)
	{
	}

	public void RefreshLeaderboardButton()
	{
	}

	public void RemoveScoreFromLeaderboardButton()
	{
	}

	[AsyncStateMachine(typeof(_003CGetLeaderboardForChallenge_003Ed__80))]
	private void GetLeaderboardForChallenge(bool submitScore = false)
	{
	}

	private void ClearLeaderboard()
	{
	}

	private void DisplayLeaderboardSlots(LeaderboardEntry[] entries)
	{
	}

	[IteratorStateMachine(typeof(_003CCreateLeaderboardSlots_003Ed__83))]
	private IEnumerator CreateLeaderboardSlots(LeaderboardEntry[] entries)
	{
		return null;
	}

	public void SubmitLeaderboardScore()
	{
	}

	[IteratorStateMachine(typeof(_003CconnectionTimeOut_003Ed__85))]
	private IEnumerator connectionTimeOut()
	{
		return null;
	}

	public void SetLoadingScreen(bool isLoading, RoomEnter result = RoomEnter.Error, string overrideMessage = "")
	{
	}

	public void DisplayMenuNotification(string notificationText, string buttonText)
	{
	}

	public void StartConnectionTimeOutTimer()
	{
	}

	public void StartAClient()
	{
	}

	public void StartHosting()
	{
	}

	[IteratorStateMachine(typeof(_003CdelayedStartScene_003Ed__91))]
	private IEnumerator delayedStartScene()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	public void ClickHostButton()
	{
	}

	public void ConfirmHostButton()
	{
	}

	public void LAN_HostSetLocal()
	{
	}

	public void LAN_HostSetAllowRemoteConnections()
	{
	}

	public void HostSetLobbyPublic(bool setPublic = false)
	{
	}

	public void FilledRoomNameField()
	{
	}

	public void EnableUIPanel(GameObject enablePanel)
	{
	}

	public void DisableUIPanel(GameObject enablePanel)
	{
	}

	private void ClickJoinButton()
	{
	}

	private void ClickQuitButton()
	{
	}
}
