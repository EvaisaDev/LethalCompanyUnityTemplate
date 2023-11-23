using GameNetcodeStuff;
using UnityEngine;

public interface IHittable
{
	void Hit(int force, Vector3 hitDirection, PlayerControllerB playerWhoHit = null, bool playHitSFX = false);
}
