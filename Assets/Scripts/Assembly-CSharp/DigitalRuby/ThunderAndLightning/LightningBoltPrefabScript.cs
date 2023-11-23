using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBoltPrefabScript : LightningBoltPrefabScriptBase
	{
		[Header("Start/end")]
		[Tooltip("The source game object, can be null")]
		public GameObject Source;

		[Tooltip("The destination game object, can be null")]
		public GameObject Destination;

		[Tooltip("X, Y and Z for variance from the start point. Use positive values.")]
		public Vector3 StartVariance;

		[Tooltip("X, Y and Z for variance from the end point. Use positive values.")]
		public Vector3 EndVariance;

		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}
	}
}
