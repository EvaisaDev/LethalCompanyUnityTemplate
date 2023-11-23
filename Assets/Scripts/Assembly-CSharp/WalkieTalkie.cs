using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class WalkieTalkie : GrabbableObject
{
	[CompilerGenerated]
	private sealed class _003CspeakingIntoWalkieTalkieMode_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WalkieTalkie _003C_003E4__this;

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
		public _003CspeakingIntoWalkieTalkieMode_003Ed__42(int _003C_003E1__state)
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

	public PlayerControllerB playerListeningTo;

	public AudioSource thisAudio;

	private PlayerControllerB previousPlayerHeldBy;

	public bool isHoldingButton;

	public bool speakingIntoWalkieTalkie;

	public bool clientIsHoldingAndSpeakingIntoThis;

	public bool otherClientIsTransmittingAudios;

	private Coroutine speakIntoWalkieTalkieCoroutine;

	public AudioClip[] stopTransmissionSFX;

	public AudioClip[] startTransmissionSFX;

	public AudioClip switchWalkieTalkiePowerOff;

	public AudioClip switchWalkieTalkiePowerOn;

	public AudioClip talkingOnWalkieTalkieNotHeldSFX;

	public AudioClip playerDieOnWalkieTalkieSFX;

	public static List<WalkieTalkie> allWalkieTalkies;

	public bool playingGarbledVoice;

	public Material onMaterial;

	public Material offMaterial;

	public Light walkieTalkieLight;

	public AudioSource target;

	[SerializeField]
	private float recordingRange;

	[SerializeField]
	private float maxVolume;

	private List<AudioSource> audioSourcesToReplay;

	private Dictionary<AudioSource, AudioSource> audioSourcesReceiving;

	public Collider listenCollider;

	private int audioSourcesToReplayLastFrameCount;

	public Collider[] collidersInRange;

	public List<WalkieTalkie> talkiesSendingToThis;

	private float cleanUpInterval;

	private float updateInterval;

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	public void SetLocalClientSpeaking(bool speaking)
	{
	}

	[ServerRpc]
	public void SetPlayerSpeakingOnWalkieTalkieServerRpc(int playerId)
	{
	}

	[ClientRpc]
	public void SetPlayerSpeakingOnWalkieTalkieClientRpc(int playerId)
	{
	}

	[ServerRpc]
	public void UnsetPlayerSpeakingOnWalkieTalkieServerRpc(int playerId)
	{
	}

	[ClientRpc]
	public void UnsetPlayerSpeakingOnWalkieTalkieClientRpc(int playerId)
	{
	}

	private void SendWalkieTalkieEndTransmissionSFX(int playerId)
	{
	}

	private void SendWalkieTalkieStartTransmissionSFX(int playerId)
	{
	}

	private void BroadcastSFXFromWalkieTalkie(AudioClip sfx, int fromPlayerId)
	{
	}

	private bool PlayerIsHoldingAnotherWalkieTalkie(WalkieTalkie walkieTalkie)
	{
		return false;
	}

	public override void ItemActivate(bool used, bool buttonDown = true)
	{
	}

	[IteratorStateMachine(typeof(_003CspeakingIntoWalkieTalkieMode_003Ed__42))]
	private IEnumerator speakingIntoWalkieTalkieMode()
	{
		return null;
	}

	private void PlayerHoldingWalkieTalkieButton(bool speaking)
	{
	}

	public void EnableWalkieTalkieListening(bool enable)
	{
	}

	public override void UseUpBatteries()
	{
	}

	public override void PocketItem()
	{
	}

	public override void ItemInteractLeftRight(bool right)
	{
	}

	public void SwitchWalkieTalkieOn(bool on)
	{
	}

	public override void EquipItem()
	{
	}

	public override void DiscardItem()
	{
	}

	private bool IsPlayerSpectatedOrLocal()
	{
		return false;
	}

	public override void Start()
	{
	}

	public override void Update()
	{
	}

	private void TimeAllAudioSources()
	{
	}

	public static void TransmitOneShotAudio(AudioSource audioSource, AudioClip clip, float vol = 1f)
	{
	}

	private void SetupAudiosourceClip()
	{
	}

	private void GetAllAudioSourcesToReplay()
	{
	}
}
