using System;

namespace DunGen.Graph
{
	[Serializable]
	public sealed class FlowNodeReference : FlowGraphObjectReference
	{
		public GraphNode Node
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FlowNodeReference(DungeonFlow flowGraph, GraphNode node)
		{
		}
	}
}
