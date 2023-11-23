using System;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

namespace DunGen.Adapters
{
	[AddComponentMenu("DunGen/NavMesh/Unity NavMesh Adapter")]
	public class UnityNavMeshAdapter : NavMeshAdapter
	{
		public enum RuntimeNavMeshBakeMode
		{
			PreBakedOnly = 0,
			AddIfNoSurfaceExists = 1,
			AlwaysRebake = 2,
			FullDungeonBake = 3
		}

		[Serializable]
		public sealed class NavMeshAgentLinkInfo
		{
			public int AgentTypeID;

			public int AreaTypeID;

			public bool DisableLinkWhenDoorIsClosed;
		}

		public RuntimeNavMeshBakeMode BakeMode;

		public LayerMask LayerMask;

		public bool AddNavMeshLinksBetweenRooms;

		public List<NavMeshAgentLinkInfo> NavMeshAgentTypes;

		public float NavMeshLinkDistanceFromDoorway;

		public bool AutoGenerateFullRebakeSurfaces;

		public List<NavMeshSurface> FullRebakeTargets;

		private List<NavMeshSurface> addedSurfaces;

		private List<NavMeshSurface> fullBakeSurfaces;

		public override void Generate(Dungeon dungeon)
		{
		}

		private void BakeFullDungeon(Dungeon dungeon)
		{
		}

		private NavMeshSurface[] AddMissingSurfaces(Tile tile, NavMeshSurface[] existingSurfaces)
		{
			return null;
		}

		private void AddNavMeshLink(DoorwayConnection connection, NavMeshAgentLinkInfo agentLinkInfo)
		{
		}
	}
}
