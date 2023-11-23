using GameNetcodeStuff;
using UnityEngine;

public class QuicksandTrigger : MonoBehaviour
{
	public bool isWater;

	public int audioClipIndex;

	[Space(5f)]
	public bool sinkingLocalPlayer;

	public float movementHinderance;

	public float sinkingSpeedMultiplier;

	private void OnTriggerStay(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public void OnExit(Collider other)
	{
	}

	public void StopSinkingLocalPlayer(PlayerControllerB playerScript)
	{
	}
}
