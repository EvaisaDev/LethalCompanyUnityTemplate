using UnityEngine;
using UnityEngine.Events;

public class PlayAudioAnimationEvent : MonoBehaviour
{
	public AudioSource audioToPlay;

	public AudioSource audioToPlayB;

	public AudioClip audioClip;

	public AudioClip audioClip2;

	public AudioClip audioClip3;

	public AudioClip[] randomClips;

	public AudioClip[] randomClips2;

	public bool randomizePitch;

	public ParticleSystem particle;

	public UnityEvent onAnimationEventCalled;

	public GameObject destroyObject;

	private float timeAtStart;

	public bool playAudibleNoise;

	private void Start()
	{
	}

	public void PlayAudio1()
	{
	}

	public void PlayAudio1RandomClip()
	{
	}

	public void PlayAudio2RandomClip()
	{
	}

	public void PlayAudioB1()
	{
	}

	public void PlayParticle()
	{
	}

	public void PlayParticleWithChildren()
	{
	}

	public void StopParticle()
	{
	}

	public void PlayAudio1Oneshot()
	{
	}

	public void PlayAudio2()
	{
	}

	public void PlayAudioB2()
	{
	}

	public void PlayAudio2Oneshot()
	{
	}

	public void PlayAudio3Oneshot()
	{
	}

	public void StopAudio()
	{
	}

	public void PauseAudio()
	{
	}

	public void PlayAudio1DefaultClip()
	{
	}

	public void OnAnimationEvent()
	{
	}

	private bool TooEarlySinceInitializing()
	{
		return false;
	}

	public void DestroyObject()
	{
	}
}
