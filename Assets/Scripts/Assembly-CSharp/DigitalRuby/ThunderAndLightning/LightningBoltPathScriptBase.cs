using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public abstract class LightningBoltPathScriptBase : LightningBoltPrefabScriptBase
	{
		[Header("Lightning Path Properties")]
		[Tooltip("The game objects to follow for the lightning path")]
		public List<GameObject> LightningPath;

		private readonly List<GameObject> currentPathObjects;

		protected List<GameObject> GetCurrentPathObjects()
		{
			return null;
		}

		protected override LightningBoltParameters OnCreateParameters()
		{
			return null;
		}
	}
}
