using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DunGen
{
	public sealed class TileProxy
	{
		private List<DoorwayProxy> doorways;

		public GameObject Prefab
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

		public Tile PrefabTile
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

		public TilePlacementData Placement
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public DoorwayProxy Entrance
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

		public DoorwayProxy Exit
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

		public ReadOnlyCollection<DoorwayProxy> Doorways
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

		public IEnumerable<DoorwayProxy> UsedDoorways => null;

		public IEnumerable<DoorwayProxy> UnusedDoorways => null;

		public TileProxy(TileProxy existingTile)
		{
		}

		public TileProxy(GameObject prefab, bool ignoreSpriteRendererBounds, Vector3 upVector)
		{
		}

		public void PositionBySocket(DoorwayProxy myDoorway, DoorwayProxy otherDoorway)
		{
		}

		private Vector3 CalculateOverlap(TileProxy other)
		{
			return default(Vector3);
		}

		public bool IsOverlapping(TileProxy other, float maxOverlap)
		{
			return false;
		}

		public bool IsOverlappingOrOverhanging(TileProxy other, AxisDirection upDirection, float maxOverlap)
		{
			return false;
		}
	}
}
