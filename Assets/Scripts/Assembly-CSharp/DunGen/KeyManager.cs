using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace DunGen
{
	[Serializable]
	[CreateAssetMenu(menuName = "DunGen/Key Manager", order = 700)]
	public sealed class KeyManager : ScriptableObject
	{
		private ReadOnlyCollection<Key> keysReadOnly;

		[SerializeField]
		private List<Key> keys;

		public ReadOnlyCollection<Key> Keys => null;

		public Key CreateKey()
		{
			return null;
		}

		public void DeleteKey(int index)
		{
		}

		public Key GetKeyByID(int id)
		{
			return null;
		}

		public Key GetKeyByName(string name)
		{
			return null;
		}

		public bool RenameKey(int index, string newName)
		{
			return false;
		}

		private int GetNextAvailableID()
		{
			return 0;
		}
	}
}
