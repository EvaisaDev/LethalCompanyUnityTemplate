using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DunGen.Analysis
{
	public class GenerationAnalysis
	{
		private readonly List<GenerationStats> statsSet;

		public int TargetIterationCount
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

		public int IterationCount
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

		public NumberSetData MainPathRoomCount
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public NumberSetData BranchPathRoomCount
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public NumberSetData TotalRoomCount
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public NumberSetData MaxBranchDepth
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public NumberSetData TotalRetries
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public NumberSetData PreProcessTime
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public NumberSetData MainPathGenerationTime
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public NumberSetData BranchPathGenerationTime
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public NumberSetData PostProcessTime
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public NumberSetData TotalTime
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float AnalysisTime
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

		public int SuccessCount
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

		public float SuccessPercentage => 0f;

		public GenerationAnalysis(int targetIterationCount)
		{
		}

		public void Clear()
		{
		}

		public void Add(GenerationStats stats)
		{
		}

		public void IncrementSuccessCount()
		{
		}

		public void Analyze()
		{
		}
	}
}
