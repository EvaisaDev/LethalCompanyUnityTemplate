using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace DunGen.Adapters
{
	[AddComponentMenu("DunGen/NavMesh/Unity NavMesh Adapter (2D)")]
	public class UnityNavMesh2DAdapter : NavMeshAdapter
	{
		[Serializable]
		public sealed class NavMeshAgentLinkInfo
		{
			public int AgentTypeID;

			public int AreaTypeID;

			public bool DisableLinkWhenDoorIsClosed;
		}

		private static Quaternion rotation;

		public bool AddNavMeshLinksBetweenRooms;

		public List<NavMeshAgentLinkInfo> NavMeshAgentTypes;

		public float NavMeshLinkDistanceFromDoorway;

		[SerializeField]
		private int agentTypeID;

		[SerializeField]
		private bool overrideTileSize;

		[SerializeField]
		private int tileSize;

		[SerializeField]
		private bool overrideVoxelSize;

		[SerializeField]
		private float voxelSize;

		[SerializeField]
		private NavMeshData navMeshData;

		[SerializeField]
		private LayerMask layerMask;

		[SerializeField]
		private int defaultArea;

		[SerializeField]
		private bool ignoreNavMeshAgent;

		[SerializeField]
		private bool ignoreNavMeshObstacle;

		[SerializeField]
		private int unwalkableArea;

		private NavMeshDataInstance m_NavMeshDataInstance;

		private Dictionary<Sprite, Mesh> cachedSpriteMeshes;

		public int AgentTypeID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool OverrideTileSize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int TileSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool OverrideVoxelSize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float VoxelSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public NavMeshData NavMeshData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LayerMask LayerMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public int DefaultArea
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool IgnoreNavMeshAgent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IgnoreNavMeshObstacle
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int UnwalkableArea
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override void Generate(Dungeon dungeon)
		{
		}

		protected void AddData()
		{
		}

		protected void RemoveData()
		{
		}

		protected virtual void BakeNavMesh(Dungeon dungeon)
		{
		}

		protected void AppendModifierVolumes(ref List<NavMeshBuildSource> sources)
		{
		}

		protected virtual List<NavMeshBuildSource> CollectSources()
		{
			return null;
		}

		protected Mesh GetMesh(Sprite sprite)
		{
			return null;
		}

		protected void AddNavMeshLink(DoorwayConnection connection, NavMeshAgentLinkInfo agentLinkInfo)
		{
		}

		public NavMeshBuildSettings GetBuildSettings()
		{
			return default(NavMeshBuildSettings);
		}

		protected Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources)
		{
			return default(Bounds);
		}

		private static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds)
		{
			return default(Bounds);
		}
	}
}
