using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DunGen
{
	public sealed class DungeonGraphNode : DungeonGraphObject
	{
		public List<DungeonGraphConnection> Connections;

		public Tile Tile
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

		public DungeonGraphNode(Tile tile)
		{
		}

		internal void AddConnection(DungeonGraphConnection connection)
		{
		}
	}
}
