using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class BreakerBox : NetworkBehaviour, IShockableWithGun
{
	public int leversSwitchedOff;

	public bool isPowerOn;

	public RoundManager roundManager;

	public Animator[] breakerSwitches;

	public AudioSource thisAudioSource;

	public AudioSource breakerBoxHum;

	public AudioClip switchPowerSFX;

	private void Start()
	{
	}

	public void SetSwitchesOff()
	{
	}

	public void SwitchBreaker(bool on)
	{
	}

	void IShockableWithGun.ShockWithGun(PlayerControllerB shockedByPlayer)
	{
	}

	void IShockableWithGun.StopShockingWithGun()
	{
	}

	bool IShockableWithGun.CanBeShocked()
	{
		return false;
	}

	float IShockableWithGun.GetDifficultyMultiplier()
	{
		return 0f;
	}

	Vector3 IShockableWithGun.GetShockablePosition()
	{
		return default(Vector3);
	}

	Transform IShockableWithGun.GetShockableTransform()
	{
		return null;
	}

	NetworkObject IShockableWithGun.GetNetworkObject()
	{
		return null;
	}
}
