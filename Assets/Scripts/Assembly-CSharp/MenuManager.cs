using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dissonance;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayMenuMusicDelayed_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CPlayMenuMusicDelayed_003Ed__53(int _003C_003E1__state)
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
	private sealed class _003CconnectionTimeOut_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CconnectionTimeOut_003Ed__55(int _003C_003E1__state)
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
	private sealed class _003CdelayedStartScene_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CdelayedStartScene_003Ed__61(int _003C_003E1__state)
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

	private bool selectingUIThisFrame;

	private GameObject lastSelectedGameObject;

	private bool playSelectAudioThisFrame;

	public bool[] filesCompatible;

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

	[IteratorStateMachine(typeof(_003CPlayMenuMusicDelayed_003Ed__53))]
	private IEnumerator PlayMenuMusicDelayed()
	{
		return null;
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CconnectionTimeOut_003Ed__55))]
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

	[IteratorStateMachine(typeof(_003CdelayedStartScene_003Ed__61))]
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
