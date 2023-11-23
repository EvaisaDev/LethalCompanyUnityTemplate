using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningLightsabreScript : LightningBoltPrefabScript
	{
		[Header("Lightsabre Properties")]
		[Tooltip("Height of the blade")]
		public float BladeHeight;

		[Tooltip("How long it takes to turn the lightsabre on and off")]
		public float ActivationTime;

		[Tooltip("Sound to play when the lightsabre turns on")]
		public AudioSource StartSound;

		[Tooltip("Sound to play when the lightsabre turns off")]
		public AudioSource StopSound;

		[Tooltip("Sound to play when the lightsabre stays on")]
		public AudioSource ConstantSound;

		private int state;

		private Vector3 bladeStart;

		private Vector3 bladeDir;

		private float bladeTime;

		private float bladeIntensity;

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		public bool TurnOn(bool value)
		{
			return false;
		}

		public void TurnOnGUI(bool value)
		{
		}
	}
}
