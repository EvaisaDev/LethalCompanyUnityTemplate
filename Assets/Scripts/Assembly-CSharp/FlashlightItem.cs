using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class FlashlightItem : GrabbableObject
{
	[Space(15f)]
	public bool usingPlayerHelmetLight;

	public int flashlightInterferenceLevel;

	public static int globalFlashlightInterferenceLevel;

	public Light flashlightBulb;

	public Light flashlightBulbGlow;

	public AudioSource flashlightAudio;

	public AudioClip[] flashlightClips;

	public AudioClip outOfBatteriesClip;

	public AudioClip flashlightFlicker;

	public Material bulbLight;

	public Material bulbDark;

	public MeshRenderer flashlightMesh;

	public int flashlightTypeID;

	public bool changeMaterial;

	private float initialIntensity;

	private PlayerControllerB previousPlayerHeldBy;

	public override void Start()
	{
	}

	public override void ItemActivate(bool used, bool buttonDown = true)
	{
	}

	public override void UseUpBatteries()
	{
	}

	public override void PocketItem()
	{
	}

	[ServerRpc]
	public void PocketFlashlightServerRpc(bool stillUsingFlashlight = false)
	{
	}

	[ClientRpc]
	public void PocketFlashlightClientRpc(bool stillUsingFlashlight)
	{
	}

	public override void DiscardItem()
	{
	}

	public override void EquipItem()
	{
	}

	public void SwitchFlashlight(bool on)
	{
	}

	public override void Update()
	{
	}
}
