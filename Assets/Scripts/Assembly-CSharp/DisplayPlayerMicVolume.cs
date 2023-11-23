using Dissonance;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayerMicVolume : MonoBehaviour
{
	public bool useDissonanceForMicDetection;

	[Space(3f)]
	private DissonanceComms comms;

	public Image volumeMeterImage;

	public float detectedVolumeAmplitude;

	private VoicePlayerState playerState;

	public float MicLoudness;

	private string _device;

	private AudioClip _clipRecord;

	private int _sampleWindow;

	private bool _isInitialized;

	private void InitMic()
	{
	}

	private void StopMicrophone()
	{
	}

	public void SwitchMicrophone()
	{
	}

	private float LevelMax()
	{
		return 0f;
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}
}
