using System;

namespace DunGen
{
	[Serializable]
	public sealed class TileInjectionRule
	{
		public TileSet TileSet;

		public FloatRange NormalizedPathDepth;

		public FloatRange NormalizedBranchDepth;

		public bool CanAppearOnMainPath;

		public bool CanAppearOnBranchPath;

		public bool IsRequired;

		public bool IsLocked;

		public int LockID;
	}
}
