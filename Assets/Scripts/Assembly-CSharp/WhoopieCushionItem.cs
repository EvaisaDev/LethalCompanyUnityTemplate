using UnityEngine;

public class WhoopieCushionItem : GrabbableObject
{
	public AudioSource whoopieCushionAudio;

	public AudioClip[] fartAudios;

	private float fartDebounce;

	private Vector3 lastPositionAtFart;

	private int timesPlayingInOneSpot;

	public void Fart()
	{
	}

	public void FartWithDebounce()
	{
	}
}
