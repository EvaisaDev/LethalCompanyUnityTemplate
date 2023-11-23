using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningFieldScript : LightningBoltPrefabScriptBase
	{
		[Header("Lightning Field Properties")]
		[Tooltip("The minimum length for a field segment")]
		public float MinimumLength;

		private float minimumLengthSquared;

		[Tooltip("The bounds to put the field in.")]
		public Bounds FieldBounds;

		[Tooltip("Optional light for the lightning field to emit")]
		public Light Light;

		private Vector3 RandomPointInBounds()
		{
			return default(Vector3);
		}

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}
	}
}
