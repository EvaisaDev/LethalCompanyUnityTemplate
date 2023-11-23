using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DunGen
{
	public static class UnityUtil
	{
		[CompilerGenerated]
		private sealed class _003CGetComponentsInParents_003Ed__26<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : Component
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private GameObject obj;

			public GameObject _003C_003E3__obj;

			private bool includeInactive;

			public bool _003C_003E3__includeInactive;

			private T[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private IEnumerator<T> _003C_003E7__wrap3;

			T IEnumerator<T>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGetComponentsInParents_003Ed__26(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public static Type ProBuilderMeshType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static PropertyInfo ProBuilderPositionsProperty
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		static UnityUtil()
		{
		}

		public static void FindProBuilderObjectType()
		{
		}

		public static void Restart(this Stopwatch stopwatch)
		{
		}

		public static bool Contains(this Bounds bounds, Bounds other)
		{
			return false;
		}

		public static Bounds TransformBounds(this Transform transform, Bounds localBounds)
		{
			return default(Bounds);
		}

		public static Bounds InverseTransformBounds(this Transform transform, Bounds worldBounds)
		{
			return default(Bounds);
		}

		public static void SetLayerRecursive(GameObject gameObject, int layer)
		{
		}

		public static void Destroy(UnityEngine.Object obj)
		{
		}

		public static string GetUniqueName(string name, IEnumerable<string> usedNames)
		{
			return null;
		}

		public static Bounds CombineBounds(params Bounds[] bounds)
		{
			return default(Bounds);
		}

		public static Bounds CalculateProxyBounds(GameObject prefab, bool ignoreSpriteRendererBounds, Vector3 upVector)
		{
			return default(Bounds);
		}

		public static Bounds CalculateObjectBounds(GameObject obj, bool includeInactive, bool ignoreSpriteRenderers, bool ignoreTriggerColliders = true)
		{
			return default(Bounds);
		}

		public static void PositionObjectBySocket(GameObject objectA, GameObject socketA, GameObject socketB)
		{
		}

		public static void PositionObjectBySocket(Transform objectA, Transform socketA, Transform socketB)
		{
		}

		public static Vector3 GetCardinalDirection(Vector3 direction, out float magnitude)
		{
			magnitude = default(float);
			return default(Vector3);
		}

		public static Vector3 VectorAbs(Vector3 vector)
		{
			return default(Vector3);
		}

		public static void SetVector3Masked(ref Vector3 input, Vector3 value, Vector3 mask)
		{
		}

		public static Bounds CondenseBounds(Bounds bounds, IEnumerable<Doorway> doorways)
		{
			return default(Bounds);
		}

		[IteratorStateMachine(typeof(_003CGetComponentsInParents_003Ed__26<>))]
		public static IEnumerable<T> GetComponentsInParents<T>(GameObject obj, bool includeInactive = false) where T : Component
		{
			return null;
		}

		public static T GetComponentInParents<T>(GameObject obj, bool includeInactive = false) where T : Component
		{
			return null;
		}

		public static float CalculateOverlap(Bounds boundsA, Bounds boundsB)
		{
			return 0f;
		}

		public static Vector3 CalculatePerAxisOverlap(Bounds boundsA, Bounds boundsB)
		{
			return default(Vector3);
		}
	}
}
