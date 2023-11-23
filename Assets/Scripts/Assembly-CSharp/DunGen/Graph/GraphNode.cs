using System;
using System.Collections.Generic;

namespace DunGen.Graph
{
	[Serializable]
	public class GraphNode
	{
		public DungeonFlow Graph;

		public List<TileSet> TileSets;

		public NodeType NodeType;

		public float Position;

		public string Label;

		public List<KeyLockPlacement> Keys;

		public List<KeyLockPlacement> Locks;

		public NodeLockPlacement LockPlacement;

		public GraphNode(DungeonFlow graph)
		{
		}
	}
}
