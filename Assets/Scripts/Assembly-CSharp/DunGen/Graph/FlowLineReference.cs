using System;

namespace DunGen.Graph
{
	[Serializable]
	public sealed class FlowLineReference : FlowGraphObjectReference
	{
		public GraphLine Line
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FlowLineReference(DungeonFlow flowGraph, GraphLine line)
		{
		}
	}
}
