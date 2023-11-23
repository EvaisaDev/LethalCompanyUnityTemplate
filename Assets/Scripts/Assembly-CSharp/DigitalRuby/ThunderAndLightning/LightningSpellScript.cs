using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public abstract class LightningSpellScript : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStopAfterSecondsCoRoutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LightningSpellScript _003C_003E4__this;

			public float seconds;

			private int _003Ctoken_003E5__2;

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
			public _003CStopAfterSecondsCoRoutine_003Ed__19(int _003C_003E1__state)
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

		[Header("Direction and distance")]
		[Tooltip("The start point of the spell. Set this to a muzzle end or hand.")]
		public GameObject SpellStart;

		[Tooltip("The end point of the spell. Set this to an empty game object. This will change depending on things like collisions, randomness, etc. Not all spells need an end object, but create this anyway to be sure.")]
		public GameObject SpellEnd;

		[HideInInspector]
		[Tooltip("The direction of the spell. Should be normalized. Does not change unless explicitly modified.")]
		public Vector3 Direction;

		[Tooltip("The maximum distance of the spell")]
		public float MaxDistance;

		[Header("Collision")]
		[Tooltip("Whether the collision is an exploision. If not explosion, collision is directional.")]
		public bool CollisionIsExplosion;

		[Tooltip("The radius of the collision explosion")]
		public float CollisionRadius;

		[Tooltip("The force to explode with when there is a collision")]
		public float CollisionForce;

		[Tooltip("Collision force mode")]
		public ForceMode CollisionForceMode;

		[Tooltip("The particle system for collisions. For best effects, this should emit particles in bursts at time 0 and not loop.")]
		public ParticleSystem CollisionParticleSystem;

		[Tooltip("The layers that the spell should collide with")]
		public LayerMask CollisionMask;

		[Tooltip("Collision audio source")]
		public AudioSource CollisionAudioSource;

		[Tooltip("Collision audio clips. One will be chosen at random and played one shot with CollisionAudioSource.")]
		public AudioClip[] CollisionAudioClips;

		[Tooltip("Collision sound volume range.")]
		public RangeOfFloats CollisionVolumeRange;

		[Header("Duration and Cooldown")]
		[Tooltip("The duration in seconds that the spell will last. Not all spells support a duration. For one shot spells, this is how long the spell cast / emission light, etc. will last.")]
		public float Duration;

		[Tooltip("The cooldown in seconds. Once cast, the spell must wait for the cooldown before being cast again.")]
		public float Cooldown;

		[Header("Emission")]
		[Tooltip("Emission sound")]
		public AudioSource EmissionSound;

		[Tooltip("Emission particle system. For best results use world space, turn off looping and play on awake.")]
		public ParticleSystem EmissionParticleSystem;

		[Tooltip("Light to illuminate when spell is cast")]
		public Light EmissionLight;

		private int stopToken;

		protected float DurationTimer
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected float CooldownTimer
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool Casting
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool CanCastSpell => false;

		[IteratorStateMachine(typeof(_003CStopAfterSecondsCoRoutine_003Ed__19))]
		private IEnumerator StopAfterSecondsCoRoutine(float seconds)
		{
			return null;
		}

		protected void ApplyCollisionForce(Vector3 point)
		{
		}

		protected void PlayCollisionSound(Vector3 pos)
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected abstract void OnCastSpell();

		protected abstract void OnStopSpell();

		protected virtual void OnActivated()
		{
		}

		protected virtual void OnDeactivated()
		{
		}

		public bool CastSpell()
		{
			return false;
		}

		public void StopSpell()
		{
		}

		public void ActivateSpell()
		{
		}

		public void DeactivateSpell()
		{
		}

		public void StopAfterSeconds(float seconds)
		{
		}

		public static GameObject FindChildRecursively(Transform t, string name)
		{
			return null;
		}
	}
}
