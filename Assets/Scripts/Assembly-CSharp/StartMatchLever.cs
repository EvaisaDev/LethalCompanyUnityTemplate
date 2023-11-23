using Unity.Netcode;
using UnityEngine;

public class StartMatchLever : NetworkBehaviour
{
	public bool singlePlayerEnabled;

	public bool leverHasBeenPulled;

	public InteractTrigger triggerScript;

	public StartOfRound playersManager;

	public Animator leverAnimatorObject;

	private float updateInterval;

	private bool clientSentRPC;

	public bool hasDisplayedTimeWarning;

	public void LeverAnimation()
	{
	}

	private void PullLeverAnim(bool leverPulled)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void PlayLeverPullEffectsServerRpc(bool leverPulled)
	{
	}

	[ClientRpc]
	private void PlayLeverPullEffectsClientRpc(bool leverPulled)
	{
	}

	public void PullLever()
	{
	}

	public void StartGame()
	{
	}

	[ClientRpc]
	public void CancelStartGameClientRpc()
	{
	}

	private void CancelStartGame()
	{
	}

	public void EndGame()
	{
	}

	public void BeginHoldingInteractOnLever()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
