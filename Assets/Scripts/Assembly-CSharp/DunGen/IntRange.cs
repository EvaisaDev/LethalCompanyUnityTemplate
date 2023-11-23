using System;

namespace DunGen
{
	[Serializable]
	public class IntRange
	{
		public int Min;

		public int Max;

		public IntRange()
		{
		}

		public IntRange(int min, int max)
		{
		}

		public int GetRandom(RandomStream random)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
