using System.Runtime.CompilerServices;
using UnityEngine;

namespace DunGen.Adapters
{
	public abstract class BaseAdapter : MonoBehaviour
	{
		public int Priority;

		protected DungeonGenerator dungeonGenerator;

		public virtual bool RunDuringAnalysis
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void OnPostProcess(DungeonGenerator generator)
		{
		}

		protected virtual void Clear()
		{
		}

		protected abstract void Run(DungeonGenerator generator);
	}
}
