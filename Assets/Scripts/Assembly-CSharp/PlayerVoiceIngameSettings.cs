using Dissonance;
using Dissonance.Audio.Playback;
using UnityEngine;

public class PlayerVoiceIngameSettings : MonoBehaviour
{
	public AudioReverbFilter filter;

	public AudioSource voiceAudio;

	public VoicePlayback _playbackComponent;

	public DissonanceComms _dissonanceComms;

	public VoicePlayerState _playerState;

	public bool set2D;

	private bool isEnabled;

	private void Awake()
	{
	}

	public void InitializeComponents()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnEnable()
	{
	}

	public void FindPlayerIfNull()
	{
	}

	private void OnDisable()
	{
	}
}
