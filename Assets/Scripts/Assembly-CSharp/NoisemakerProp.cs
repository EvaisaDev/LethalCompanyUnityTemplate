using System;
using UnityEngine;

public class NoisemakerProp : GrabbableObject
{
	public AudioSource noiseAudio;

	public AudioSource noiseAudioFar;

	[Space(3f)]
	public AudioClip[] noiseSFX;

	public AudioClip[] noiseSFXFar;

	[Space(3f)]
	public float noiseRange;

	public float maxLoudness;

	public float minLoudness;

	public float minPitch;

	public float maxPitch;

	private System.Random noisemakerRandom;

	public Animator triggerAnimator;

	public override void Start()
	{
	}

	public override void ItemActivate(bool used, bool buttonDown = true)
	{
	}
}
