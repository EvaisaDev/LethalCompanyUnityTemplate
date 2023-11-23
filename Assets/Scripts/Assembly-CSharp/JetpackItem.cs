using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class JetpackItem : GrabbableObject
{
	public Transform backPart;

	public Vector3 backPartRotationOffset;

	public Vector3 backPartPositionOffset;

	private float jetpackPower;

	private bool jetpackActivated;

	private Vector3 forces;

	private bool jetpackActivatedPreviousFrame;

	public GameObject fireEffect;

	public AudioSource jetpackAudio;

	public AudioSource jetpackBeepsAudio;

	public AudioClip startJetpackSFX;

	public AudioClip jetpackSustainSFX;

	public AudioClip jetpackBrokenSFX;

	public AudioClip jetpackWarningBeepSFX;

	public AudioClip jetpackLowBatteriesSFX;

	public ParticleSystem smokeTrailParticle;

	private PlayerControllerB previousPlayerHeldBy;

	private bool jetpackBroken;

	private bool jetpackPlayingWarningBeep;

	private bool jetpackPlayingLowBatteryBeep;

	private float noiseInterval;

	private RaycastHit rayHit;

	public override void ItemActivate(bool used, bool buttonDown = true)
	{
	}

	private void DeactivateJetpack()
	{
	}

	private void ActivateJetpack()
	{
	}

	private void JetpackEffect(bool enable)
	{
	}

	public override void UseUpBatteries()
	{
	}

	public override void DiscardItem()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void ExplodeJetpackServerRpc()
	{
	}

	[ClientRpc]
	public void ExplodeJetpackClientRpc()
	{
	}

	public override void EquipItem()
	{
	}

	public override void Update()
	{
	}

	private void SetJetpackAudios()
	{
	}

	public override void LateUpdate()
	{
	}
}
