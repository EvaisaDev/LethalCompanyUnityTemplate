using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class ItemDropship : NetworkBehaviour
{
	public bool deliveringOrder;

	public bool shipLanded;

	public bool shipDoorsOpened;

	public Animator shipAnimator;

	public float shipTimer;

	public bool playersFirstOrder;

	private StartOfRound playersManager;

	private Terminal terminalScript;

	private List<int> itemsToDeliver;

	public Transform[] itemSpawnPositions;

	private float noiseInterval;

	private int timesPlayedWithoutTurningOff;

	public InteractTrigger triggerScript;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void TryOpeningShip()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void OpenShipServerRpc()
	{
	}

	private void OpenShipDoorsOnServer()
	{
	}

	[ClientRpc]
	public void OpenShipClientRpc()
	{
	}

	public void ShipLandedAnimationEvent()
	{
	}

	private void LandShipOnServer()
	{
	}

	[ClientRpc]
	public void LandShipClientRpc()
	{
	}

	[ClientRpc]
	public void ShipLeaveClientRpc()
	{
	}

	public void ShipLeave()
	{
	}

	public void ShipLandedInAnimation()
	{
	}
}
