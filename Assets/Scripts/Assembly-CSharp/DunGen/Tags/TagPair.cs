using System;

namespace DunGen.Tags
{
	[Serializable]
	public sealed class TagPair
	{
		public Tag TagA;

		public Tag TagB;

		public TagPair()
		{
		}

		public TagPair(Tag a, Tag b)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public bool Matches(Tag a, Tag b, bool twoWay)
		{
			return false;
		}
	}
}
