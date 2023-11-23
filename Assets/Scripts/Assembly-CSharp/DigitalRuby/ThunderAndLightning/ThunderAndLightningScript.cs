using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class ThunderAndLightningScript : MonoBehaviour
	{
		private class LightningBoltHandler
		{
			[CompilerGenerated]
			private sealed class _003CProcessLightning_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public LightningBoltHandler _003C_003E4__this;

				public bool intense;

				public Vector3? _start;

				public Vector3? _end;

				public bool visible;

				private AudioClip[] _003Csounds_003E5__2;

				private float _003Cintensity_003E5__3;

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
				public _003CProcessLightning_003Ed__9(int _003C_003E1__state)
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

			private ThunderAndLightningScript script;

			private readonly System.Random random;

			public float VolumeMultiplier
			{
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public LightningBoltHandler(ThunderAndLightningScript script)
			{
			}

			private void UpdateLighting()
			{
			}

			private void CalculateNextLightningTime()
			{
			}

			[IteratorStateMachine(typeof(_003CProcessLightning_003Ed__9))]
			public IEnumerator ProcessLightning(Vector3? _start, Vector3? _end, bool intense, bool visible)
			{
				return null;
			}

			private void Strike(Vector3? _start, Vector3? _end, bool intense, float intensity, Camera camera, Camera visibleInCamera)
			{
			}

			private void CheckForLightning()
			{
			}

			public void Update()
			{
			}
		}

		[Tooltip("Lightning bolt script - optional, leave null if you don't want lightning bolts")]
		public LightningBoltPrefabScript LightningBoltScript;

		[Tooltip("Camera where the lightning should be centered over. Defaults to main camera.")]
		public Camera Camera;

		[SingleLine("Random interval between strikes.")]
		public RangeOfFloats LightningIntervalTimeRange;

		[Tooltip("Probability (0-1) of an intense lightning bolt that hits really close. Intense lightning has increased brightness and louder thunder compared to normal lightning, and the thunder sounds plays a lot sooner.")]
		[Range(0f, 1f)]
		public float LightningIntenseProbability;

		[Tooltip("Sounds to play for normal thunder. One will be chosen at random for each lightning strike. Depending on intensity, some normal lightning may not play a thunder sound.")]
		public AudioClip[] ThunderSoundsNormal;

		[Tooltip("Sounds to play for intense thunder. One will be chosen at random for each lightning strike.")]
		public AudioClip[] ThunderSoundsIntense;

		[Tooltip("Whether lightning strikes should always try to be in the camera view")]
		public bool LightningAlwaysVisible;

		[Tooltip("The chance lightning will simply be in the clouds with no visible bolt")]
		[Range(0f, 1f)]
		public float CloudLightningChance;

		[Tooltip("Whether to modify the skybox exposure when lightning is created")]
		public bool ModifySkyboxExposure;

		[Tooltip("Base point light range for lightning bolts. Increases as intensity increases.")]
		[Range(1f, 10000f)]
		public float BaseLightRange;

		[Tooltip("Starting y value for the lightning strikes")]
		[Range(0f, 100000f)]
		public float LightningYStart;

		[Tooltip("Volume multiplier")]
		[Range(0f, 1f)]
		public float VolumeMultiplier;

		private float skyboxExposureOriginal;

		private float skyboxExposureStorm;

		private float nextLightningTime;

		private bool lightningInProgress;

		private AudioSource audioSourceThunder;

		private LightningBoltHandler lightningBoltHandler;

		private Material skyboxMaterial;

		private AudioClip lastThunderSound;

		public float SkyboxExposureOriginal => 0f;

		public bool EnableLightning
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void CallNormalLightning()
		{
		}

		public void CallNormalLightning(Vector3? start, Vector3? end)
		{
		}

		public void CallIntenseLightning()
		{
		}

		public void CallIntenseLightning(Vector3? start, Vector3? end)
		{
		}
	}
}
