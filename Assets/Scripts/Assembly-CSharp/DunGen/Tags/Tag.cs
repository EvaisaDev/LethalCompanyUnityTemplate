using System;
using System.Collections.Generic;
using UnityEngine;

namespace DunGen.Tags
{
	[Serializable]
	public sealed class Tag : IEqualityComparer<Tag>
	{
		[SerializeField]
		private int id;

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
			set
			{
			}
		}

		public Tag(int id)
		{
		}

		public Tag(string name)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public int GetHashCode(Tag tag)
		{
			return 0;
		}

		public bool Equals(Tag x, Tag y)
		{
			return false;
		}

		public static bool operator ==(Tag a, Tag b)
		{
			return false;
		}

		public static bool operator !=(Tag a, Tag b)
		{
			return false;
		}
	}
}
