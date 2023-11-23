using System.Collections.Generic;
using DunGen.Graph;
using UnityEngine;

namespace DunGen
{
	public sealed class DungeonProxy
	{
		public List<TileProxy> AllTiles;

		public List<TileProxy> MainPathTiles;

		public List<TileProxy> BranchPathTiles;

		public List<ProxyDoorwayConnection> Connections;

		private Transform visualsRoot;

		private Dictionary<TileProxy, GameObject> tileVisuals;

		public DungeonProxy(Transform debugVisualsRoot = null)
		{
		}

		public void ClearDebugVisuals()
		{
		}

		public void MakeConnection(DoorwayProxy a, DoorwayProxy b)
		{
		}

		public void RemoveLastConnection()
		{
		}

		public void RemoveConnection(ProxyDoorwayConnection connection)
		{
		}

		internal void AddTile(TileProxy tile)
		{
		}

		internal void RemoveTile(TileProxy tile)
		{
		}

		internal void ConnectOverlappingDoorways(float globalChance, DungeonFlow dungeonFlow, RandomStream randomStream)
		{
		}
	}
}
