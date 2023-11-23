using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBoltShapeSphereScript : LightningBoltPrefabScriptBase
	{
		[Header("Lightning Sphere Properties")]
		[Tooltip("Radius inside the sphere where lightning can emit from")]
		public float InnerRadius;

		[Tooltip("Radius of the sphere")]
		public float Radius;

		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}
	}
}
