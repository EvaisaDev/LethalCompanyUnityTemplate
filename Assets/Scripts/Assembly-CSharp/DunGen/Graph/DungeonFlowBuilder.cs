using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DunGen.Graph
{
	public sealed class DungeonFlowBuilder
	{
		private List<GraphLine> lines;

		private List<GraphNode> nodes;

		private float currentPosition;

		public DungeonFlow Flow
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

		public DungeonFlowBuilder(DungeonFlow flow)
		{
		}

		public DungeonFlowBuilder AddLine(DungeonArchetype archetype, float length = 1f, IEnumerable<KeyLockPlacement> locks = null, IEnumerable<KeyLockPlacement> keys = null)
		{
			return null;
		}

		public DungeonFlowBuilder AddLine(IEnumerable<DungeonArchetype> archetypes, float length = 1f, IEnumerable<KeyLockPlacement> locks = null, IEnumerable<KeyLockPlacement> keys = null)
		{
			return null;
		}

		public DungeonFlowBuilder ContinueLine(float length = 1f)
		{
			return null;
		}

		public DungeonFlowBuilder AddNode(TileSet tileSet, string label = null, bool allowLocksOnEntrance = false, bool allowLocksOnExit = false, IEnumerable<KeyLockPlacement> locks = null, IEnumerable<KeyLockPlacement> keys = null)
		{
			return null;
		}

		public DungeonFlowBuilder AddNode(IEnumerable<TileSet> tileSets, string label = null, bool allowLocksOnEntrance = false, bool allowLocksOnExit = false, IEnumerable<KeyLockPlacement> locks = null, IEnumerable<KeyLockPlacement> keys = null)
		{
			return null;
		}

		public DungeonFlowBuilder Complete()
		{
			return null;
		}
	}
}
