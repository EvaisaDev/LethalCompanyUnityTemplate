using UnityEngine;

public class SignalTranslator : MonoBehaviour
{
	public float timeLastUsingSignalTranslator;

	public Coroutine signalTranslatorCoroutine;

	public int timesSendingMessage;

	public AudioClip[] typeTextClips;

	public AudioClip finishTypingSFX;

	public AudioClip startTransmissionSFX;

	public AudioSource localAudio;
}
