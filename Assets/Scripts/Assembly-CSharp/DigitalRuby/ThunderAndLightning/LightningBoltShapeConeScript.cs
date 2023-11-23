using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBoltShapeConeScript : LightningBoltPrefabScriptBase
	{
		[Header("Lightning Cone Properties")]
		[Tooltip("Radius at base of cone where lightning can emit from")]
		public float InnerRadius;

		[Tooltip("Radius at outer part of the cone where lightning emits to")]
		public float OuterRadius;

		[Tooltip("The length of the cone from the center of the inner and outer circle")]
		public float Length;

		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}
	}
}
