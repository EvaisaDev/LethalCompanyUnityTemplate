using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBoltPathScript : LightningBoltPathScriptBase
	{
		[Tooltip("How fast the lightning moves through the points or objects. 1 is normal speed, 0.01 is slower, so the lightning will move slowly between the points or objects.")]
		[Range(0.01f, 1f)]
		public float Speed;

		[Tooltip("Repeat when the path completes?")]
		[SingleLineClamp("When each new point is moved to, this can provide a random value to make the movement to the next point appear more staggered or random. Leave as 1 and 1 to have constant speed. Use a higher maximum to create more randomness.", 1.0, 500.0)]
		public RangeOfFloats SpeedIntervalRange;

		[Tooltip("Repeat when the path completes?")]
		public bool Repeat;

		private float nextInterval;

		private int nextIndex;

		private Vector3? lastPoint;

		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}

		public void Reset()
		{
		}
	}
}
