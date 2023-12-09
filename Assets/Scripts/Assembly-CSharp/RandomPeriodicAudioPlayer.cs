using Unity.Netcode;
using UnityEngine;

public class RandomPeriodicAudioPlayer : NetworkBehaviour
{
	public GrabbableObject attachedGrabbableObject;

	public AudioClip[] randomClips;

	public AudioSource thisAudio;

	public float audioMinInterval;

	public float audioMaxInterval;

	public float audioChancePercent;

	private float currentInterval;

	private float lastIntervalTime;

	private void Update()
	{
	}

	[ClientRpc]
	public void PlayRandomAudioClientRpc(int clipIndex)
	{
	}

	private void PlayAudio(int clipIndex)
	{
	}
}
