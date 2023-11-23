using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Netcode;
using UnityEngine;

public class EntranceTeleport : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CplayMusicOnDelay_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EntranceTeleport _003C_003E4__this;

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
		public _003CplayMusicOnDelay_003Ed__20(int _003C_003E1__state)
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

	public bool isEntranceToBuilding;

	public Transform entrancePoint;

	private Transform exitPoint;

	public int entranceId;

	public StartOfRound playersManager;

	private bool initializedVariables;

	public int audioReverbPreset;

	public AudioSource entrancePointAudio;

	private AudioSource exitPointAudio;

	public AudioClip[] doorAudios;

	public AudioClip firstTimeAudio;

	public int dungeonFlowId;

	private InteractTrigger triggerScript;

	private float checkForEnemiesInterval;

	private bool enemyNearLastCheck;

	private bool gotExitPoint;

	private bool checkedForFirstTime;

	private void Awake()
	{
	}

	public bool FindExitPoint()
	{
		return false;
	}

	public void TeleportPlayer()
	{
	}

	[IteratorStateMachine(typeof(_003CplayMusicOnDelay_003Ed__20))]
	private IEnumerator playMusicOnDelay()
	{
		return null;
	}

	[ServerRpc(RequireOwnership = false)]
	public void TeleportPlayerServerRpc(int playerObj)
	{
	}

	[ClientRpc]
	public void TeleportPlayerClientRpc(int playerObj)
	{
	}

	private void SetAudioPreset(int playerObj)
	{
	}

	public void PlayAudioAtTeleportPositions()
	{
	}

	private void Update()
	{
	}
}
