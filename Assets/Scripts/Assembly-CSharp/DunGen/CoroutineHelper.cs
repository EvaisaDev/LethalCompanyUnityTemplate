using System.Collections;
using UnityEngine;

namespace DunGen
{
	public sealed class CoroutineHelper : MonoBehaviour
	{
		private static CoroutineHelper instance;

		private static CoroutineHelper Instance => null;

		public static Coroutine Start(IEnumerator routine)
		{
			return null;
		}

		public static void StopAll()
		{
		}
	}
}
