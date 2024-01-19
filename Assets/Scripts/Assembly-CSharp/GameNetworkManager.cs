using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using GameNetcodeStuff;
using Netcode.Transports.Facepunch;
using Steamworks;
using Steamworks.Data;
using Unity.Netcode;
using UnityEngine;

public class GameNetworkManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDisconnectProcess_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameNetworkManager _003C_003E4__this;

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
		public _003CDisconnectProcess_003Ed__74(int _003C_003E1__state)
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
	private struct _003CJoinLobby_003Ed__88 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Lobby lobby;

		public SteamId id;

		public GameNetworkManager _003C_003E4__this;

		private TaskAwaiter<RoomEnter> _003C_003Eu__1;

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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStartHost_003Ed__87 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GameNetworkManager _003C_003E4__this;

		private GameNetworkManager _003C_003E7__wrap1;

		private TaskAwaiter<Lobby?> _003C_003Eu__1;

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
	private sealed class _003CTimeOutLobbyRefresh_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameNetworkManager _003C_003E4__this;

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
		public _003CTimeOutLobbyRefresh_003Ed__62(int _003C_003E1__state)
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
	private sealed class _003CdelayStartClient_003Ed__92 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CdelayStartClient_003Ed__92(int _003C_003E1__state)
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
	private sealed class _003CwaitFrameBeforeFindingUsername_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameNetworkManager _003C_003E4__this;

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
		public _003CwaitFrameBeforeFindingUsername_003Ed__48(int _003C_003E1__state)
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

	public int gameVersionNum;

	public int compatibleFileCutoffVersion;

	public bool AlwaysDisplayNews;

	public bool isDemo;

	[Space(5f)]
	public bool SendExceptionsToServer;

	[Space(5f)]
	public bool disableSteam;

	private FacepunchTransport transport;

	public List<SteamId> steamIdsInLobby;

	public HostSettings lobbyHostSettings;

	public int connectedPlayers;

	public int maxAllowedPlayers;

	private bool hasSubscribedToConnectionCallbacks;

	public bool gameHasStarted;

	public PlayerControllerB localPlayerController;

	public int disconnectReason;

	public string username;

	public bool isDisconnecting;

	public bool firstTimeInMenu;

	public bool isHostingGame;

	public bool waitingForLobbyDataRefresh;

	public int playersInRefreshedLobby;

	public string steamLobbyName;

	public const string LCchallengeFileName = "LCChallengeFile";

	public const string LCsaveFile1Name = "LCSaveFile1";

	public const string LCsaveFile2Name = "LCSaveFile2";

	public const string LCsaveFile3Name = "LCSaveFile3";

	public const string generalSaveDataName = "LCGeneralSaveData";

	public string currentSaveFileName;

	public int saveFileNum;

	public AudioClip buttonCancelSFX;

	public AudioClip buttonSelectSFX;

	public AudioClip buttonPressSFX;

	public AudioClip buttonTuneSFX;

	public bool disallowConnection;

	public string disconnectionReasonMessage;

	public bool localClientWaitingForApproval;

	public bool disapprovedClientThisFrame;

	private string previousLogErrorString;

	public static GameNetworkManager Instance
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

	public Lobby? currentLobby
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

	private void LogCallback(string condition, string stackTrace, LogType type)
	{
	}

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CwaitFrameBeforeFindingUsername_003Ed__48))]
	private IEnumerator waitFrameBeforeFindingUsername()
	{
		return null;
	}

	public int GetWeekNumber()
	{
		return 0;
	}

	public string GetNameForWeekNumber(int overrideWeekNum = -1)
	{
		return null;
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetSteamFriendGrouping(string groupName, int groupSize, string steamDisplay)
	{
	}

	private void ConnectionApproval(NetworkManager.ConnectionApprovalRequest request, NetworkManager.ConnectionApprovalResponse response)
	{
	}

	private void Singleton_OnClientDisconnectCallback(ulong clientId)
	{
	}

	private void OnLocalClientConnectionDisapproved(ulong clientId)
	{
	}

	private void Singleton_OnClientConnectedCallback(ulong clientId)
	{
	}

	public void SubscribeToConnectionCallbacks()
	{
	}

	public void SteamFriends_OnGameLobbyJoinRequested(Lobby lobby, SteamId id)
	{
	}

	public bool LobbyDataIsJoinable(Lobby lobby)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CTimeOutLobbyRefresh_003Ed__62))]
	public IEnumerator TimeOutLobbyRefresh()
	{
		return null;
	}

	private void SteamMatchmaking_OnLobbyMemberJoined(Lobby lobby, Friend friend)
	{
	}

	private string NoPunctuation(string input)
	{
		return null;
	}

	private void SteamMatchmaking_OnLobbyMemberLeave(Lobby lobby, Friend friend)
	{
	}

	private void SteamMatchmaking_OnLobbyGameCreated(Lobby lobby, uint arg2, ushort arg3, SteamId arg4)
	{
	}

	private void SteamMatchmaking_OnLobbyInvite(Friend friend, Lobby lobby)
	{
	}

	private void SteamMatchmaking_OnLobbyCreated(Result result, Lobby lobby)
	{
	}

	public void LeaveLobbyAtGameStart()
	{
	}

	public void SetLobbyJoinable(bool joinable)
	{
	}

	public void SetCurrentLobbyNull()
	{
	}

	private void OnApplicationQuit()
	{
	}

	public void Disconnect()
	{
	}

	[IteratorStateMachine(typeof(_003CDisconnectProcess_003Ed__74))]
	private IEnumerator DisconnectProcess()
	{
		return null;
	}

	private void StartDisconnect()
	{
	}

	public void SaveGame()
	{
	}

	private void ResetGameValuesToDefault()
	{
	}

	public void ResetStaticVariables()
	{
	}

	public void ResetUnlockablesListValues(bool onlyResetPrefabItems = false)
	{
	}

	private void SaveLocalPlayerValues()
	{
	}

	public void ResetSavedGameValues()
	{
	}

	private void SaveGameValues()
	{
	}

	private void SaveItemsInShip()
	{
	}

	private void ConvertUnsellableItemsToCredits()
	{
	}

	private void SetInstanceValuesBackToDefault()
	{
	}

	public void InviteFriendsUI()
	{
	}

	[AsyncStateMachine(typeof(_003CStartHost_003Ed__87))]
	public void StartHost()
	{
	}

	[AsyncStateMachine(typeof(_003CJoinLobby_003Ed__88))]
	public void JoinLobby(Lobby lobby, SteamId id)
	{
	}

	public void LeaveCurrentSteamLobby()
	{
	}

	public void SetConnectionDataBeforeConnecting()
	{
	}

	public void StartClient(SteamId id)
	{
	}

	[IteratorStateMachine(typeof(_003CdelayStartClient_003Ed__92))]
	private IEnumerator delayStartClient()
	{
		return null;
	}
}
