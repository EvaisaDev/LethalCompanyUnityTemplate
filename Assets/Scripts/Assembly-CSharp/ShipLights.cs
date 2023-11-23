using Unity.Netcode;
using UnityEngine;

public class ShipLights : NetworkBehaviour
{
	public bool areLightsOn;

	public Animator shipLightsAnimator;

	[ServerRpc(RequireOwnership = false)]
	public void SetShipLightsServerRpc(bool setLightsOn)
	{
	}

	[ClientRpc]
	public void SetShipLightsClientRpc(bool setLightsOn)
	{
	}

	public void ToggleShipLights()
	{
	}

	public void SetShipLightsBoolean(bool setLights)
	{
	}

	public void ToggleShipLightsOnLocalClientOnly()
	{
	}

	public void SetShipLightsOnLocalClientOnly(bool setLightsOn)
	{
	}
}
