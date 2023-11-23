using UnityEngine;

namespace DunGen
{
	[AddComponentMenu("DunGen/Runtime Dungeon")]
	public class RuntimeDungeon : MonoBehaviour
	{
		public DungeonGenerator Generator;

		public bool GenerateOnStart;

		public GameObject Root;

		protected virtual void Start()
		{
		}

		public void Generate()
		{
		}
	}
}
