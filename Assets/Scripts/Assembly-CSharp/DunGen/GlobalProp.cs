using UnityEngine;

namespace DunGen
{
	[AddComponentMenu("DunGen/Random Props/Global Prop")]
	public class GlobalProp : MonoBehaviour
	{
		public int PropGroupID;

		public float MainPathWeight;

		public float BranchPathWeight;

		public AnimationCurve DepthWeightScale;
	}
}
