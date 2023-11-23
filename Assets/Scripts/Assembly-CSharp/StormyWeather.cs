using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DigitalRuby.ThunderAndLightning;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.AI;

public class StormyWeather : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGetMetalObjectsAfterDelay_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StormyWeather _003C_003E4__this;

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
		public _003CGetMetalObjectsAfterDelay_003Ed__31(int _003C_003E1__state)
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

	private float randomThunderTime;

	private float timeAtLastStrike;

	private Vector3 lastRandomStrikePosition;

	private System.Random seed;

	public AudioClip[] strikeSFX;

	public AudioClip[] distantThunderSFX;

	public LightningBoltPrefabScript randomThunder;

	public LightningBoltPrefabScript targetedThunder;

	public AudioSource randomStrikeAudio;

	public AudioSource randomStrikeAudioB;

	private bool lastStrikeAudioUsed;

	public AudioSource targetedStrikeAudio;

	private RaycastHit rayHit;

	private GameObject[] outsideNodes;

	private NavMeshHit navHit;

	public ParticleSystem explosionEffectParticle;

	private List<GrabbableObject> metalObjects;

	private GrabbableObject targetingMetalObject;

	private float getObjectToTargetInterval;

	private float strikeMetalObjectTimer;

	private bool hasShownStrikeWarning;

	public ParticleSystem staticElectricityParticle;

	private GameObject setStaticToObject;

	private GrabbableObject setStaticGrabbableObject;

	public AudioClip staticElectricityAudio;

	private float lastGlobalTimeUsed;

	private float globalTimeAtLastStrike;

	private System.Random targetedThunderRandom;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnGlobalTimeSync()
	{
	}

	[IteratorStateMachine(typeof(_003CGetMetalObjectsAfterDelay_003Ed__31))]
	private IEnumerator GetMetalObjectsAfterDelay()
	{
		return null;
	}

	public void SwitchCamera(Camera newCamera)
	{
	}

	private void DetermineNextStrikeInterval()
	{
	}

	private int RoundUpToNearestTen(float x)
	{
		return 0;
	}

	private void Update()
	{
	}

	public void SetStaticElectricityWarning(NetworkObject warningObject, float particleTime)
	{
	}

	private void LightningStrikeRandom()
	{
	}

	public void LightningStrike(Vector3 strikePosition, bool useTargetedObject)
	{
	}

	private void PlayThunderEffects(Vector3 strikePosition, AudioSource audio)
	{
	}
}
