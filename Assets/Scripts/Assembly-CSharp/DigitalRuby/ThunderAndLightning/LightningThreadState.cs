using System;
using System.Collections.Generic;
using System.Threading;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningThreadState
	{
		internal readonly int mainThreadId;

		internal readonly bool multiThreaded;

		private Thread lightningThread;

		private AutoResetEvent lightningThreadEvent;

		private readonly Queue<Action> actionsForBackgroundThread;

		private readonly Queue<KeyValuePair<Action<bool>, ManualResetEvent>> actionsForMainThread;

		public bool Running;

		private bool isTerminating;

		private bool UpdateMainThreadActionsOnce(bool inDestroy)
		{
			return false;
		}

		private void BackgroundThreadMethod()
		{
		}

		public LightningThreadState(bool multiThreaded)
		{
		}

		public void TerminateAndWaitForEnd(bool inDestroy)
		{
		}

		public void UpdateMainThreadActions()
		{
		}

		public bool AddActionForMainThread(Action<bool> action, bool waitForAction = false)
		{
			return false;
		}

		public bool AddActionForBackgroundThread(Action action)
		{
			return false;
		}
	}
}
