using Steamworks;
using Steamworks.Data;
using TMPro;
using UnityEngine;

public class LobbySlot : MonoBehaviour
{
	public MenuManager menuScript;

	public TextMeshProUGUI LobbyName;

	public TextMeshProUGUI playerCount;

	public SteamId lobbyId;

	public Lobby thisLobby;

	private static Coroutine timeOutLobbyRefreshCoroutine;

	private void Awake()
	{
	}

	public void JoinButton()
	{
	}

	public static void JoinLobbyAfterVerifying(Lobby lobby, SteamId lobbyId)
	{
	}

	public static void OnLobbyDataRefresh(Lobby lobby)
	{
	}

	private void Update()
	{
	}
}
