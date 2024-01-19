using GameNetcodeStuff;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PhysicsKnockbackOnHit : MonoBehaviour, IHittable
{
	public AudioClip playSFX;

	public bool Hit(int force, Vector3 hitDirection, PlayerControllerB playerWhoHit = null, bool playHitSFX = false)
	{
		return false;
	}
}
