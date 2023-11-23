using System.Runtime.CompilerServices;
using UnityEngine;

namespace DunGen
{
	public sealed class DoorwayProxy
	{
		public bool Used => false;

		public TileProxy TileProxy
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

		public int Index
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DoorwaySocket Socket
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

		public Doorway DoorwayComponent
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

		public Vector3 LocalPosition
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Quaternion LocalRotation
		{
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DoorwayProxy ConnectedDoorway
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

		public Vector3 Forward => default(Vector3);

		public Vector3 Up => default(Vector3);

		public Vector3 Position => default(Vector3);

		public DoorwayProxy(TileProxy tileProxy, DoorwayProxy other)
		{
		}

		public DoorwayProxy(TileProxy tileProxy, int index, Doorway doorwayComponent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		public static void Connect(DoorwayProxy a, DoorwayProxy b)
		{
		}

		public void Disconnect()
		{
		}
	}
}
