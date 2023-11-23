using System;
using UnityEngine;

namespace DunGen.Graph
{
	[Serializable]
	public abstract class FlowGraphObjectReference
	{
		[SerializeField]
		protected DungeonFlow flow;

		[SerializeField]
		protected int index;

		public DungeonFlow Flow => null;
	}
}
