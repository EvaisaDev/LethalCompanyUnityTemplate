using System;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	[Serializable]
	public struct RangeOfIntegers
	{
		[Tooltip("Minimum value (inclusive)")]
		public int Minimum;

		[Tooltip("Maximum value (inclusive)")]
		public int Maximum;

		public int Random()
		{
			return 0;
		}

		public int Random(System.Random r)
		{
			return 0;
		}
	}
}
