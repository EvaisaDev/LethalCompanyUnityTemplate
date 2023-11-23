using System;

namespace DunGen
{
	[Serializable]
	public class FloatRange
	{
		public float Min;

		public float Max;

		public FloatRange()
		{
		}

		public FloatRange(float min, float max)
		{
		}

		public float GetRandom(RandomStream random)
		{
			return 0f;
		}
	}
}
