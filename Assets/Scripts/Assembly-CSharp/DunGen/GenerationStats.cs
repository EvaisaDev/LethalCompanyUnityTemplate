using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DunGen
{
	public sealed class GenerationStats
	{
		private Stopwatch stopwatch;

		private GenerationStatus generationStatus;

		public int MainPathRoomCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int BranchPathRoomCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int TotalRoomCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int MaxBranchDepth
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int TotalRetries
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int PrunedBranchTileCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public float PreProcessTime
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

		public float MainPathGenerationTime
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

		public float BranchPathGenerationTime
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

		public float PostProcessTime
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

		public float TotalTime
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

		internal void Clear()
		{
		}

		internal void IncrementRetryCount()
		{
		}

		internal void SetRoomStatistics(int mainPathRoomCount, int branchPathRoomCount, int maxBranchDepth)
		{
		}

		internal void BeginTime(GenerationStatus status)
		{
		}

		internal void EndTime()
		{
		}

		public GenerationStats Clone()
		{
			return null;
		}
	}
}
