using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace DunGen
{
	[AddComponentMenu("DunGen/Culling/Adjacent Room Culling (Multi-Camera)")]
	public class BasicRoomCullingCamera : MonoBehaviour
	{
		protected struct RendererData
		{
			public Renderer Renderer;

			public bool Enabled;
		}

		protected struct LightData
		{
			public Light Light;

			public bool Enabled;
		}

		protected struct ReflectionProbeData
		{
			public ReflectionProbe Probe;

			public bool Enabled;
		}

		[CompilerGenerated]
		private sealed class _003CGetAllDoorsInDungeon_003Ed__38 : IEnumerable<Door>, IEnumerable, IEnumerator<Door>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Door _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private Dungeon dungeon;

			public Dungeon _003C_003E3__dungeon;

			private IEnumerator<GameObject> _003C_003E7__wrap1;

			Door IEnumerator<Door>.Current
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
			public _003CGetAllDoorsInDungeon_003Ed__38(int _003C_003E1__state)
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
			IEnumerator<Door> IEnumerable<Door>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public int AdjacentTileDepth;

		public bool CullBehindClosedDoors;

		public Transform TargetOverride;

		public bool CullInEditor;

		public bool CullLights;

		protected bool isCulling;

		protected bool isDirty;

		protected DungeonGenerator generator;

		protected Tile currentTile;

		protected List<Tile> allTiles;

		protected List<Door> allDoors;

		protected List<Tile> visibleTiles;

		protected Dictionary<Tile, List<RendererData>> rendererVisibilities;

		protected Dictionary<Tile, List<LightData>> lightVisibilities;

		protected Dictionary<Tile, List<ReflectionProbeData>> reflectionProbeVisibilities;

		protected Dictionary<Door, List<RendererData>> doorRendererVisibilities;

		public bool IsReady
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		private void OnEndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		protected virtual void OnDungeonGenerationStatusChanged(DungeonGenerator generator, GenerationStatus status)
		{
		}

		protected virtual void EnableCulling(Camera camera)
		{
		}

		protected virtual void DisableCulling(Camera camera)
		{
		}

		protected void SetCullingEnabled(Camera camera, bool enabled)
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected void UpdateRendererList(Tile tile)
		{
		}

		protected void SetIsCulling(bool isCulling)
		{
		}

		protected void UpdateCulling()
		{
		}

		public void SetDungeon(Dungeon dungeon)
		{
		}

		[IteratorStateMachine(typeof(_003CGetAllDoorsInDungeon_003Ed__38))]
		protected IEnumerable<Door> GetAllDoorsInDungeon(Dungeon dungeon)
		{
			return null;
		}

		protected virtual void ClearDungeon()
		{
		}

		protected virtual void OnDoorStateChanged(Door door, bool isOpen)
		{
		}
	}
}
