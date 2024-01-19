using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Steamworks.Data;
using Steamworks.ServerList;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SteamLobbyManager : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadServerList_003Ed__19 : IAsyncStateMachine
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

	[CompilerGenerated]
	private sealed class _003CloadLobbyListAndFilter_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SteamLobbyManager _003C_003E4__this;

		public Lobby[] lobbyList;

		private string[] _003CoffensiveWords_003E5__2;

		private int _003Ci_003E5__3;

		private string _003ClobbyName_003E5__4;

		private string _003ClobbyNameNoCapitals_003E5__5;

		private bool _003CnameIsOffensive_003E5__6;

		private int _003Cb_003E5__7;

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
		public _003CloadLobbyListAndFilter_003Ed__20(int _003C_003E1__state)
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

	private Internet Request;

	private Lobby[] currentLobbyList;

	public TextMeshProUGUI serverListBlankText;

	public Transform levelListContainer;

	public GameObject LobbySlotPrefab;

	public GameObject LobbySlotPrefabChallenge;

	private float lobbySlotPositionOffset;

	public int sortByDistanceSetting;

	private float refreshServerListTimer;

	public bool censorOffensiveLobbyNames;

	private Coroutine loadLobbyListCoroutine;

	public UnityEngine.UI.Image sortWithChallengeMoonsCheckbox;

	private bool sortWithChallengeMoons;

	public TMP_InputField serverTagInputField;

	public void ToggleSortWithChallengeMoons()
	{
	}

	public void ChangeDistanceSort(int newValue)
	{
	}

	private void OnEnable()
	{
	}

	private void DebugLogServerList()
	{
	}

	public void RefreshServerListButton()
	{
	}

	[AsyncStateMachine(typeof(_003CLoadServerList_003Ed__19))]
	public void LoadServerList()
	{
	}

	[IteratorStateMachine(typeof(_003CloadLobbyListAndFilter_003Ed__20))]
	private IEnumerator loadLobbyListAndFilter(Lobby[] lobbyList)
	{
		return null;
	}

	private void Update()
	{
	}
}
