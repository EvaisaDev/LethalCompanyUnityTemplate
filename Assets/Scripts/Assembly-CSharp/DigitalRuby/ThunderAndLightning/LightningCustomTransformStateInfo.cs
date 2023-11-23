using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningCustomTransformStateInfo
	{
		public Vector3 BoltStartPosition;

		public Vector3 BoltEndPosition;

		public Transform Transform;

		public Transform StartTransform;

		public Transform EndTransform;

		public object UserInfo;

		private static readonly List<LightningCustomTransformStateInfo> cache;

		public LightningCustomTransformState State
		{
			[CompilerGenerated]
			get
			{
				return default(LightningCustomTransformState);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public LightningBoltParameters Parameters
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static LightningCustomTransformStateInfo GetOrCreateStateInfo()
		{
			return null;
		}

		public static void ReturnStateInfoToCache(LightningCustomTransformStateInfo info)
		{
		}
	}
}
