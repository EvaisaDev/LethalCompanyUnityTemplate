using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBoltTransformTrackerScript : MonoBehaviour
	{
		[Tooltip("The lightning script to track.")]
		public LightningBoltPrefabScript LightningScript;

		[Tooltip("The transform to track which will be where the bolts are emitted from.")]
		public Transform StartTarget;

		[Tooltip("(Optional) The transform to track which will be where the bolts are emitted to. If no end target is specified, lightning will simply move to stay on top of the start target.")]
		public Transform EndTarget;

		[SingleLine("Scaling limits.")]
		public RangeOfFloats ScaleLimit;

		private readonly Dictionary<Transform, LightningCustomTransformStateInfo> transformStartPositions;

		private void Start()
		{
		}

		private static float AngleBetweenVector2(Vector2 vec1, Vector2 vec2)
		{
			return 0f;
		}

		private static void UpdateTransform(LightningCustomTransformStateInfo state, LightningBoltPrefabScript script, RangeOfFloats scaleLimit)
		{
		}

		public void CustomTransformHandler(LightningCustomTransformStateInfo state)
		{
		}
	}
}
