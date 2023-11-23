using System;

namespace DunGen
{
	public struct DungeonGeneratorPostProcessStep
	{
		public Action<DungeonGenerator> PostProcessCallback;

		public PostProcessPhase Phase;

		public int Priority;
	}
}
