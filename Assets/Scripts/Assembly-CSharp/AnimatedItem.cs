using System;
using UnityEngine;

public class AnimatedItem : GrabbableObject
{
	public string grabItemBoolString;

	public string dropItemTriggerString;

	public bool makeAnimationWhenDropping;

	public Animator itemAnimator;

	public AudioSource itemAudio;

	public AudioClip grabAudio;

	public AudioClip dropAudio;

	public bool loopGrabAudio;

	public bool loopDropAudio;

	[Range(0f, 100f)]
	public int chanceToTriggerAnimation;

	public int chanceToTriggerAlternateMesh;

	public Mesh alternateMesh;

	private Mesh normalMesh;

	private System.Random itemRandomChance;

	public float noiseRange;

	public float noiseLoudness;

	private int timesPlayedInOneSpot;

	private float makeNoiseInterval;

	private Vector3 lastPosition;

	public AudioLowPassFilter itemAudioLowPassFilter;

	private bool wasInPocket;

	public override void Start()
	{
	}

	public override void EquipItem()
	{
	}

	public override void DiscardItem()
	{
	}

	public override void PocketItem()
	{
	}

	public override void Update()
	{
	}
}
