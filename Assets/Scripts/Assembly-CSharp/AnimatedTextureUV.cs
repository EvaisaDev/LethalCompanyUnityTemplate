using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AnimatedTextureUV : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateUV_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnimatedTextureUV _003C_003E4__this;

		private float _003CmaxVertical_003E5__2;

		private float _003CmaxHorizontal_003E5__3;

		object IEnumerator<object>.Current
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
		public _003CAnimateUV_003Ed__13(int _003C_003E1__state)
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

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private Material[] setMaterials;

	public MeshRenderer meshRenderer;

	public SkinnedMeshRenderer skinnedMeshRenderer;

	public int materialIndex;

	public int columns;

	public int rows;

	public float waitFrameTime;

	private float horizontalOffset;

	private float verticalOffset;

	private Coroutine animateMaterial;

	private bool skinnedMesh;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateUV_003Ed__13))]
	private IEnumerator AnimateUV()
	{
		return null;
	}
}
