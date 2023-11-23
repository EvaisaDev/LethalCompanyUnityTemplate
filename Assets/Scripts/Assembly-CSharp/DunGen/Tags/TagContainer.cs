using System;
using System.Collections;
using System.Collections.Generic;

namespace DunGen.Tags
{
	[Serializable]
	public sealed class TagContainer : IEnumerable<Tag>, IEnumerable
	{
		public List<Tag> Tags;

		public bool HasTag(Tag tag)
		{
			return false;
		}

		public bool HasAnyTag(params Tag[] tags)
		{
			return false;
		}

		public bool HasAnyTag(TagContainer tags)
		{
			return false;
		}

		public bool HasAllTags(params Tag[] tags)
		{
			return false;
		}

		public bool HasAllTags(TagContainer tags)
		{
			return false;
		}

		public IEnumerator<Tag> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
