using UnityEngine;

namespace DunGen
{
	public abstract class RandomProp : MonoBehaviour
	{
		public virtual void Process(RandomStream randomStream, Tile tile)
		{
		}
	}
}
