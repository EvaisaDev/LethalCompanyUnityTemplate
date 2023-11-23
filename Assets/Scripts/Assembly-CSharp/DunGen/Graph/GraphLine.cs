using System;
using System.Collections.Generic;

namespace DunGen.Graph
{
	[Serializable]
	public class GraphLine
	{
		public DungeonFlow Graph;

		public List<DungeonArchetype> DungeonArchetypes;

		public float Position;

		public float Length;

		public List<KeyLockPlacement> Keys;

		public List<KeyLockPlacement> Locks;

		public GraphLine(DungeonFlow graph)
		{
		}

		public DungeonArchetype GetRandomArchetype(RandomStream randomStream, IList<DungeonArchetype> usedArchetypes)
		{
			return null;
		}
	}
}
