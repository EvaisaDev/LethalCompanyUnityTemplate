using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	[RequireComponent(typeof(ParticleSystem))]
	public class LightningParticleCollisionForwarder : MonoBehaviour
	{
		[Tooltip("The script to forward the collision to. Must implement ICollisionHandler.")]
		public MonoBehaviour CollisionHandler;

		private ParticleSystem _particleSystem;

		private readonly List<ParticleCollisionEvent> collisionEvents;

		private void Start()
		{
		}

		private void OnParticleCollision(GameObject other)
		{
		}
	}
}
