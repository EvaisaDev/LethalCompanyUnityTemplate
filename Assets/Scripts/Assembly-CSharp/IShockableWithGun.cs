using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public interface IShockableWithGun
{
	float GetDifficultyMultiplier();

	Vector3 GetShockablePosition();

	Transform GetShockableTransform();

	NetworkObject GetNetworkObject();

	bool CanBeShocked();

	void StopShockingWithGun();

	void ShockWithGun(PlayerControllerB shockedByPlayer);
}
