using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CfadeVolumeBackToNormalDelayed_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private float _003CtargetVolume_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CfadeVolumeBackToNormalDelayed_003Ed__61(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private System.Random SoundsRandom;

	public float soundFrequencyServer;

	public float soundRarityServer;

	public float soundTimerServer;

	private int serverSoundsPlayedInARow;

	public float soundFrequency;

	public float soundRarity;

	private float soundTimer;

	private int localSoundsPlayedInARow;

	public AudioSource ambienceAudio;

	public AudioSource ambienceAudioNonDiagetic;

	[Header("Outside Music")]
	public AudioSource musicSource;

	public AudioClip[] DaytimeMusic;

	public AudioClip[] EveningMusic;

	private float timeSincePlayingLastMusic;

	public bool playingOutsideMusic;

	[Space(5f)]
	private bool isAudioPlaying;

	private PlayerControllerB localPlayer;

	private bool isInsanityMusicPlaying;

	private List<int> audioClipProbabilities;

	private int lastSoundTypePlayed;

	private int lastServerSoundTypePlayed;

	private bool playingInsanitySoundClip;

	private bool playingInsanitySoundClipOnServer;

	private float localPlayerAmbientMusicTimer;

	[Header("Audio Mixer")]
	public AudioMixerSnapshot[] mixerSnapshots;

	public AudioMixer diageticMixer;

	public AudioMixerGroup[] playerVoiceMixers;

	[Space(3f)]
	public float[] playerVoicePitchTargets;

	public float[] playerVoicePitches;

	public float[] playerVoicePitchLerpSpeed;

	[Space(3f)]
	public float[] playerVoiceVolumes;

	public int currentMixerSnapshotID;

	private bool overridingCurrentAudioMixer;

	[Header("Background music")]
	public AudioSource highAction1;

	private bool highAction1audible;

	public AudioSource highAction2;

	private bool highAction2audible;

	public AudioSource lowAction;

	private bool lowActionAudible;

	public AudioSource heartbeatSFX;

	public float currentHeartbeatInterval;

	public float heartbeatTimer;

	public AudioClip[] heartbeatClips;

	private int currentHeartbeatClip;

	private bool playingHeartbeat;

	public float earsRingingTimer;

	public float timeSinceEarsStartedRinging;

	private bool earsRinging;

	public AudioSource ringingEarsAudio;

	public AudioSource tempAudio1;

	public AudioSource tempAudio2;

	public AudioClip[] syncedAudioClips;

	private System.Random audioRandom;

	public static SoundManager Instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void ResetRandomSeed()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CfadeVolumeBackToNormalDelayed_003Ed__61))]
	private IEnumerator fadeVolumeBackToNormalDelayed()
	{
		return null;
	}

	public void InitializeRandom()
	{
	}

	public void ResetValues()
	{
	}

	public void SetPlayerPitch(float pitch, int playerObjNum)
	{
	}

	public void SetPlayerVoiceFilters()
	{
	}

	private void Update()
	{
	}

	private void SetAudioFilters()
	{
	}

	public void PlayRandomOutsideMusic(bool eveningMusic = false)
	{
	}

	private void SetOutsideMusicValues()
	{
	}

	private void SetEarsRinging()
	{
	}

	private void SetFearAudio()
	{
	}

	private void PlayNonDiageticSound()
	{
	}

	private void ServerSoundTimer()
	{
	}

	private void LocalPlayerSoundTimer()
	{
	}

	public void SetServerSoundRandomizerVariables()
	{
	}

	public void SetLocalSoundRandomizerVariables()
	{
	}

	public void PlayAmbientSound(bool syncedForAllPlayers = false, bool playInsanitySounds = false)
	{
	}

	public void ResetSoundType()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void PlayAmbienceClipServerRpc(int soundType, int clipIndex, float soundVolume, bool playInsanitySounds)
	{
	}

	[ClientRpc]
	public void PlayAmbienceClipClientRpc(int soundType, int clipIndex, float soundVolume, bool playInsanitySounds)
	{
	}

	public void PlayAmbienceClipLocal(int soundType, int clipIndex, float soundVolume, bool playInsanitySounds)
	{
	}

	public void PlaySoundAroundPlayersAsGroup(AudioClip clipToPlay, float vol)
	{
	}

	public void PlaySoundAroundLocalPlayer(AudioClip clipToPlay, float vol)
	{
	}

	public void SetDiageticMixerSnapshot(int snapshotID = 0, float transitionTime = 1f)
	{
	}

	public void ResumeCurrentMixerSnapshot(float time)
	{
	}

	public void PlayAudio1AtPositionForAllClients(Vector3 audioPosition, int clipIndex)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void PlayAudio1AtPositionServerRpc(Vector3 audioPos, int clipIndex)
	{
	}

	[ClientRpc]
	public void PlayAudio1AtPositionClientRpc(Vector3 audioPos, int clipIndex)
	{
	}
}
