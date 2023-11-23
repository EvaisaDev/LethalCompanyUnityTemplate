using UnityEngine;

namespace Zeekerss.Core.Singletons
{
	public class Singleton<T> : MonoBehaviour where T : Component
	{
		private static T _instance;

		public static T Instance => null;
	}
}
