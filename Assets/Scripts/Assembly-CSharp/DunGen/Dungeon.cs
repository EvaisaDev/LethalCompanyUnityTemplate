using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using DunGen.Graph;
using UnityEngine;

namespace DunGen
{
	public class Dungeon : MonoBehaviour
	{
		public bool DebugRender;

		private readonly List<Tile> allTiles;

		private readonly List<Tile> mainPathTiles;

		private readonly List<Tile> branchPathTiles;

		private readonly List<GameObject> doors;

		private readonly List<DoorwayConnection> connections;

		public Bounds Bounds
		{
			[CompilerGenerated]
			get
			{
				return default(Bounds);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public DungeonFlow DungeonFlow
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public ReadOnlyCollection<Tile> AllTiles
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

		public ReadOnlyCollection<Tile> MainPathTiles
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

		public ReadOnlyCollection<Tile> BranchPathTiles
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

		public ReadOnlyCollection<GameObject> Doors
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

		public ReadOnlyCollection<DoorwayConnection> Connections
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

		public DungeonGraph ConnectionGraph
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

		internal void AddAdditionalDoor(Door door)
		{
		}

		internal void PreGenerateDungeon(DungeonGenerator dungeonGenerator)
		{
		}

		internal void PostGenerateDungeon(DungeonGenerator dungeonGenerator)
		{
		}

		public void Clear()
		{
		}

		public Doorway GetConnectedDoorway(Doorway doorway)
		{
			return null;
		}

		public void FromProxy(DungeonProxy proxyDungeon, DungeonGenerator generator)
		{
		}

		private void SpawnDoorPrefab(Doorway a, Doorway b, RandomStream randomStream)
		{
		}

		public void OnDrawGizmos()
		{
		}

		public void DebugDraw()
		{
		}
	}
}
