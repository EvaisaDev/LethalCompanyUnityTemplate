using System;
using UnityEngine;

namespace DunGen
{
	[CreateAssetMenu(fileName = "New Doorway Socket", menuName = "DunGen/Doorway Socket", order = 700)]
	public class DoorwaySocket : ScriptableObject
	{
		[SerializeField]
		private Vector2 size;

		[Obsolete("Use DoorwayPairFinder.CustomConnectionRules instead")]
		public static SocketConnectionDelegate CustomSocketConnectionDelegate;

		public Vector2 Size => default(Vector2);

		public static bool CanSocketsConnect(DoorwaySocket a, DoorwaySocket b)
		{
			return false;
		}
	}
}
