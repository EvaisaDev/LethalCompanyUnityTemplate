using System;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningParticleSpellScript : LightningSpellScript, ICollisionHandler
	{
		[Header("Particle system")]
		public ParticleSystem ParticleSystem;

		[Tooltip("Particle system collision interval. This time must elapse before another collision will be registered.")]
		public float CollisionInterval;

		protected float collisionTimer;

		[HideInInspector]
		public Action<GameObject, List<ParticleCollisionEvent>, int> CollisionCallback;

		[Header("Particle Light Properties")]
		[Tooltip("Whether to enable point lights for the particles")]
		public bool EnableParticleLights;

		[SingleLineClamp("Possible range for particle lights", 0.001, 100.0)]
		public RangeOfFloats ParticleLightRange;

		[SingleLineClamp("Possible range of intensity for particle lights", 0.009999999776482582, 8.0)]
		public RangeOfFloats ParticleLightIntensity;

		[Tooltip("Possible range of colors for particle lights")]
		public Color ParticleLightColor1;

		[Tooltip("Possible range of colors for particle lights")]
		public Color ParticleLightColor2;

		[Tooltip("The culling mask for particle lights")]
		public LayerMask ParticleLightCullingMask;

		private ParticleSystem.Particle[] particles;

		private readonly List<GameObject> particleLights;

		private void PopulateParticleLight(Light src)
		{
		}

		private void UpdateParticleLights()
		{
		}

		private void UpdateParticleSystems()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		protected override void OnCastSpell()
		{
		}

		protected override void OnStopSpell()
		{
		}

		void ICollisionHandler.HandleCollision(GameObject obj, List<ParticleCollisionEvent> collisions, int collisionCount)
		{
		}
	}
}
