using System;
using System.Runtime.CompilerServices;
using DunGen.Graph;
using UnityEngine;

namespace DunGen
{
	[Serializable]
	public sealed class TilePlacementData
	{
		[SerializeField]
		private int pathDepth;

		[SerializeField]
		private float normalizedPathDepth;

		[SerializeField]
		private int branchDepth;

		[SerializeField]
		private float normalizedBranchDepth;

		[SerializeField]
		private bool isOnMainPath;

		[SerializeField]
		private Bounds localBounds;

		[SerializeField]
		private GraphNode graphNode;

		[SerializeField]
		private GraphLine graphLine;

		[SerializeField]
		private DungeonArchetype archetype;

		[SerializeField]
		private TileSet tileSet;

		[SerializeField]
		private Vector3 position;

		[SerializeField]
		private Quaternion rotation;

		public int PathDepth
		{
			get
			{
				return 0;
			}
			internal set
			{
			}
		}

		public float NormalizedPathDepth
		{
			get
			{
				return 0f;
			}
			internal set
			{
			}
		}

		public int BranchDepth
		{
			get
			{
				return 0;
			}
			internal set
			{
			}
		}

		public float NormalizedBranchDepth
		{
			get
			{
				return 0f;
			}
			internal set
			{
			}
		}

		public bool IsOnMainPath
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public Bounds Bounds
		{
			[CompilerGenerated]
			get
			{
				return default(Bounds);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Bounds LocalBounds
		{
			get
			{
				return default(Bounds);
			}
			internal set
			{
			}
		}

		public GraphNode GraphNode
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public GraphLine GraphLine
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public DungeonArchetype Archetype
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public TileSet TileSet
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public Vector3 Position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion Rotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Matrix4x4 Transform
		{
			[CompilerGenerated]
			get
			{
				return default(Matrix4x4);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int Depth => 0;

		public float NormalizedDepth => 0f;

		public InjectedTile InjectionData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public TilePlacementData()
		{
		}

		public TilePlacementData(TilePlacementData copy)
		{
		}

		private void RecalculateTransform()
		{
		}
	}
}
