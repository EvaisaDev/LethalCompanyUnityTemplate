using System;
using UnityEngine;

namespace DunGen
{
	[Serializable]
	public sealed class GameObjectWeight
	{
		public GameObject GameObject;

		public float Weight;

		public GameObjectWeight()
		{
		}

		public GameObjectWeight(GameObject gameObject, float weight = 1f)
		{
		}
	}
}
