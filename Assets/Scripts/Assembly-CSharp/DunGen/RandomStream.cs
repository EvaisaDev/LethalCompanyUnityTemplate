namespace DunGen
{
	public sealed class RandomStream
	{
		private const int maxValue = int.MaxValue;

		private const int seed = 161803398;

		private int iNext;

		private int iNextP;

		private int[] seedArray;

		public RandomStream()
		{
		}

		public RandomStream(int Seed)
		{
		}

		private double Sample()
		{
			return 0.0;
		}

		private int InternalSample()
		{
			return 0;
		}

		public int Next()
		{
			return 0;
		}

		private double GetSampleForLargeRange()
		{
			return 0.0;
		}

		public int Next(int minValue, int maxValue)
		{
			return 0;
		}

		public int Next(int maxValue)
		{
			return 0;
		}

		public double NextDouble()
		{
			return 0.0;
		}

		public void NextBytes(byte[] buffer)
		{
		}
	}
}
