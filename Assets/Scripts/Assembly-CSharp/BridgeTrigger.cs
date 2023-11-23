using System.Collections.Generic;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class BridgeTrigger : NetworkBehaviour
{
	public float bridgeDurability;

	private PlayerControllerB playerOnBridge;

	private List<PlayerControllerB> playersOnBridge;

	public AudioSource bridgeAudioSource;

	public AudioClip[] bridgeCreakSFX;

	public AudioClip bridgeFallSFX;

	public Animator bridgeAnimator;

	private bool hasBridgeFallen;

	public Transform bridgePhysicsPartsContainer;

	private bool giantOnBridge;

	private bool giantOnBridgeLastFrame;

	public Collider[] fallenBridgeColliders;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	[ServerRpc]
	public void BridgeFallServerRpc()
	{
	}

	[ClientRpc]
	public void BridgeFallClientRpc()
	{
	}

	private void EnableFallenBridgeColliders()
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	public void RemovePlayerFromBridge(PlayerControllerB playerOnBridge)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
