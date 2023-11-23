using System;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBeamSpellScript : LightningSpellScript
	{
		[Header("Beam")]
		[Tooltip("The lightning path script creating the beam of lightning")]
		public LightningBoltPathScriptBase LightningPathScript;

		[Tooltip("Give the end point some randomization")]
		public float EndPointRandomization;

		[HideInInspector]
		public Action<RaycastHit> CollisionCallback;

		private void CheckCollision()
		{
		}

		protected override void Start()
		{
		}

		protected override void LateUpdate()
		{
		}

		protected override void OnCastSpell()
		{
		}

		protected override void OnStopSpell()
		{
		}
	}
}
