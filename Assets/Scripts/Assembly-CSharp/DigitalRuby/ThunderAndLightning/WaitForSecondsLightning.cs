using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class WaitForSecondsLightning : CustomYieldInstruction
	{
		private float remaining;

		public override bool keepWaiting => false;

		public WaitForSecondsLightning(float time)
		{
		}
	}
}
