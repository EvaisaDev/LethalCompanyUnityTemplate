using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

public class AudioReverbTrigger : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CchangeVolume_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioReverbTrigger _003C_003E4__this;

		public AudioSource aud;

		public float changeVolumeTo;

		private float _003CfogTarget_003E5__2;

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
		public _003CchangeVolume_003Ed__19(int _003C_003E1__state)
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

	public PlayerControllerB playerScript;

	public ReverbPreset reverbPreset;

	public int usePreset;

	[Header("CHANGE AUDIO AMBIANCE")]
	public switchToAudio[] audioChanges;

	private bool changingVolumes;

	[Header("MISC")]
	public bool elevatorTriggerForProps;

	public bool setInElevatorTrigger;

	public bool isShipRoom;

	public bool toggleLocalFog;

	public float fogEnabledAmount;

	public LocalVolumetricFog localFog;

	public Terrain terrainObj;

	[Header("Weather and effects")]
	public bool setInsideAtmosphere;

	public bool insideLighting;

	public int weatherEffect;

	public bool effectEnabled;

	public bool disableAllWeather;

	public bool enableCurrentLevelWeather;

	private bool spectatedClientTriggered;

	[IteratorStateMachine(typeof(_003CchangeVolume_003Ed__19))]
	private IEnumerator changeVolume(AudioSource aud, float changeVolumeTo)
	{
		return null;
	}

	public void ChangeAudioReverbForPlayer(PlayerControllerB pScript)
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	public void StopAudioCoroutine(AudioSource audioKey)
	{
	}
}
