using Unity.Netcode;
using UnityEngine;

public class ShipAlarmCord : NetworkBehaviour
{
	private bool hornBlaring;

	private float cordPulledDownTimer;

	public Animator cordAnimator;

	public AudioSource hornClose;

	public AudioSource hornFar;

	public AudioSource cordAudio;

	public AudioClip cordPullSFX;

	private bool otherClientHoldingCord;

	private float playAudibleNoiseInterval;

	private int timesPlayingAtOnce;

	public PlaceableShipObject shipObjectScript;

	private int unlockableID;

	private bool localClientHoldingCord;

	private void Start()
	{
	}

	public void HoldCordDown()
	{
	}

	public void StopHorn()
	{
	}

	private void Update()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void PullCordServerRpc(int playerPullingCord)
	{
	}

	[ClientRpc]
	public void PullCordClientRpc(int playerPullingCord)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void StopPullingCordServerRpc(int playerPullingCord)
	{
	}

	[ClientRpc]
	public void StopPullingCordClientRpc(int playerPullingCord)
	{
	}
}
