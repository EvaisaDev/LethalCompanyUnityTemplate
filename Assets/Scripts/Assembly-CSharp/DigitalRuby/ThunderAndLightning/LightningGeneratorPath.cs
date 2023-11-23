using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningGeneratorPath : LightningGenerator
	{
		public static readonly LightningGeneratorPath PathGeneratorInstance;

		public void GenerateLightningBoltPath(LightningBolt bolt, Vector3 start, Vector3 end, LightningBoltParameters parameters)
		{
		}

		protected override void OnGenerateLightningBolt(LightningBolt bolt, Vector3 start, Vector3 end, LightningBoltParameters parameters)
		{
		}
	}
}
