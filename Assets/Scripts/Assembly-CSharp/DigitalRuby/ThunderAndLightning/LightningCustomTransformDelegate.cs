using System;
using UnityEngine.Events;

namespace DigitalRuby.ThunderAndLightning
{
	[Serializable]
	public class LightningCustomTransformDelegate : UnityEvent<LightningCustomTransformStateInfo>
	{
		public LightningCustomTransformDelegate()
		{
		}
	}
}
