using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class UnlockableSuit : NetworkBehaviour
{
	public NetworkVariable<int> syncedSuitID;

	public int suitID;

	public Material suitMaterial;

	public SkinnedMeshRenderer suitRenderer;

	private void Update()
	{
	}

	public void SwitchSuitToThis(PlayerControllerB playerWhoTriggered = null)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SwitchSuitServerRpc(int playerID)
	{
	}

	[ClientRpc]
	public void SwitchSuitClientRpc(int playerID)
	{
	}

	public static void SwitchSuitForAllPlayers(int suitID, bool playAudio = false)
	{
	}

	public static void SwitchSuitForPlayer(PlayerControllerB player, int suitID, bool playAudio = true)
	{
	}
}
