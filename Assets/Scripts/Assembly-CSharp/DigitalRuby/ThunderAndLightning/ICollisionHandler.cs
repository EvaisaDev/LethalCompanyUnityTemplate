using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public interface ICollisionHandler
	{
		void HandleCollision(GameObject obj, List<ParticleCollisionEvent> collision, int collisionCount);
	}
}
