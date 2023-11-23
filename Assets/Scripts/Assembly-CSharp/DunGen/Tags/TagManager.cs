using System;
using System.Collections.Generic;
using UnityEngine;

namespace DunGen.Tags
{
	[Serializable]
	public sealed class TagManager : ISerializationCallbackReceiver
	{
		private Dictionary<int, string> tags;

		[SerializeField]
		private List<int> keys;

		[SerializeField]
		private List<string> values;

		public int TagCount => 0;

		public string TryGetNameFromID(int id)
		{
			return null;
		}

		public bool TagExists(string name, out int id)
		{
			id = default(int);
			return false;
		}

		public bool TryRenameTag(int id, string newName)
		{
			return false;
		}

		public int AddTag(string tagName)
		{
			return 0;
		}

		private string GetUnusedTagName(string desiredTagName)
		{
			return null;
		}

		public bool RemoveTag(int id)
		{
			return false;
		}

		public int[] GetTagIDs()
		{
			return null;
		}

		public void OnAfterDeserialize()
		{
		}

		public void OnBeforeSerialize()
		{
		}
	}
}
