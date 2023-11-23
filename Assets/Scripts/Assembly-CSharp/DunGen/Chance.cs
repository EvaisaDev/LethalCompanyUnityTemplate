using System;

namespace DunGen
{
	[Serializable]
	public class Chance<T>
	{
		public T Value;

		public float Weight;

		public Chance()
		{
		}

		public Chance(T value)
		{
		}

		public Chance(T value, float weight)
		{
		}
	}
}
