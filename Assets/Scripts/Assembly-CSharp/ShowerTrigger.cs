using System.Collections.Generic;
using GameNetcodeStuff;
using UnityEngine;

public class ShowerTrigger : MonoBehaviour
{
	private float cleanInterval;

	private bool showerOn;

	private int cleanDecalIndex;

	private List<PlayerControllerB> playersInShower;

	private int playerIndex;

	private bool everyOtherFrame;

	public Collider showerCollider;

	public void ToggleShower(bool on)
	{
	}

	private void AddPlayerToShower(PlayerControllerB playerScript)
	{
	}

	private void RemovePlayerFromShower(PlayerControllerB playerScript)
	{
	}

	private void CheckBoundsForPlayers()
	{
	}

	private void Update()
	{
	}
}
