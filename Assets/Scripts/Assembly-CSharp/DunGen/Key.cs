using System;
using UnityEngine;

namespace DunGen
{
	[Serializable]
	public sealed class Key
	{
		public GameObject Prefab;

		public Color Colour;

		public IntRange KeysPerLock;

		[SerializeField]
		private int id;

		[SerializeField]
		private string name;

		public int ID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		internal Key(int id)
		{
		}
	}
}
