using System;

namespace DunGen
{
	[Serializable]
	public sealed class LockedDoorwayAssociation
	{
		public DoorwaySocket Socket;

		public GameObjectChanceTable LockPrefabs;
	}
}
