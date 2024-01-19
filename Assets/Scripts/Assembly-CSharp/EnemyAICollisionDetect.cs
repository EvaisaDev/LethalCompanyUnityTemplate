using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class EnemyAICollisionDetect : MonoBehaviour, IHittable, INoiseListener, IShockableWithGun
{
	public EnemyAI mainScript;

	public bool canCollideWithEnemies;

	public bool onlyCollideWhenGrounded;

	private void OnTriggerStay(Collider other)
	{
	}

	bool IHittable.Hit(int force, Vector3 hitDirection, PlayerControllerB playerWhoHit, bool playHitSFX)
	{
		return false;
	}

	void INoiseListener.DetectNoise(Vector3 noisePosition, float noiseLoudness, int timesNoisePlayedInOneSpot, int noiseID)
	{
	}

	bool IShockableWithGun.CanBeShocked()
	{
		return false;
	}

	Vector3 IShockableWithGun.GetShockablePosition()
	{
		return default(Vector3);
	}

	float IShockableWithGun.GetDifficultyMultiplier()
	{
		return 0f;
	}

	void IShockableWithGun.ShockWithGun(PlayerControllerB shockedByPlayer)
	{
	}

	Transform IShockableWithGun.GetShockableTransform()
	{
		return null;
	}

	NetworkObject IShockableWithGun.GetNetworkObject()
	{
		return null;
	}

	void IShockableWithGun.StopShockingWithGun()
	{
	}
}
