using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Steamworks.Data;
using Steamworks.ServerList;
using TMPro;
using UnityEngine;

public class SteamLobbyManager : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadServerList_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SteamLobbyManager _003C_003E4__this;

		private TaskAwaiter<Lobby[]> _003C_003Eu__1;

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

	private Internet Request;

	private Lobby[] currentLobbyList;

	public TextMeshProUGUI serverListBlankText;

	public Transform levelListContainer;

	public GameObject LobbySlotPrefab;

	private float lobbySlotPositionOffset;

	public int sortByDistanceSetting;

	private float refreshServerListTimer;

	private void Start()
	{
	}

	public void ChangeDistanceSort(int newValue)
	{
	}

	private void DebugLogServerList()
	{
	}

	public void RefreshServerListButton()
	{
	}

	[AsyncStateMachine(typeof(_003CLoadServerList_003Ed__12))]
	public void LoadServerList()
	{
	}

	private void Update()
	{
	}
}
