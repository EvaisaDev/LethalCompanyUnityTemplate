using Unity.Netcode;
using UnityEngine;

public class SteamValveHazard : NetworkBehaviour
{
	public float valveCrackTime;

	public float valveBurstTime;

	private bool valveHasBurst;

	private bool valveHasCracked;

	private bool valveHasBeenRepaired;

	public InteractTrigger triggerScript;

	[Header("Fog")]
	public Animator fogAnimator;

	public Animator valveAnimator;

	public float fogSizeMultiplier;

	public float currentFogSize;

	[Header("Other Effects")]
	public ParticleSystem valveSteamParticle;

	public AudioClip[] pipeFlowingSFX;

	public AudioClip valveTwistSFX;

	public AudioClip valveBurstSFX;

	public AudioClip valveCrackSFX;

	public AudioClip steamBlowSFX;

	public AudioSource valveAudio;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void CrackValve()
	{
	}

	private void BurstValve()
	{
	}

	private void FixValveLocalClient()
	{
	}

	public void FixValve()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void FixValveServerRpc()
	{
	}

	[ClientRpc]
	public void FixValveClientRpc()
	{
	}
}
