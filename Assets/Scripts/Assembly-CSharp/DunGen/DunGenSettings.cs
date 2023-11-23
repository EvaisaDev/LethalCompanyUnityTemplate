using DunGen.Tags;
using UnityEngine;

namespace DunGen
{
	public sealed class DunGenSettings : ScriptableObject
	{
		private static DunGenSettings instance;

		[SerializeField]
		private DoorwaySocket defaultSocket;

		[SerializeField]
		private TagManager tagManager;

		public static DunGenSettings Instance => null;

		public DoorwaySocket DefaultSocket => null;

		public TagManager TagManager => null;

		private static DunGenSettings GetOrCreateInstance()
		{
			return null;
		}
	}
}
