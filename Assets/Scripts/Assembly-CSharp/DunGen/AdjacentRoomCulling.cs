using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DunGen
{
	[AddComponentMenu("DunGen/Culling/Adjacent Room Culling")]
	public class AdjacentRoomCulling : MonoBehaviour
	{
		public delegate void VisibilityChangedDelegate(Tile tile, bool visible);

		[CompilerGenerated]
		private sealed class _003CGetAllDoorsInDungeon_003Ed__34 : IEnumerable<Door>, IEnumerable, IEnumerator<Door>, IEnumerator, IDisposable
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
			public _003CGetAllDoorsInDungeon_003Ed__34(int _003C_003E1__state)
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

		public bool IncludeDisabledComponents;

		[NonSerialized]
		public Dictionary<Renderer, bool> OverrideRendererVisibilities;

		[NonSerialized]
		public Dictionary<Light, bool> OverrideLightVisibilities;

		protected List<Tile> allTiles;

		protected List<Door> allDoors;

		protected List<Tile> oldVisibleTiles;

		protected List<Tile> visibleTiles;

		protected Dictionary<Tile, bool> tileVisibilities;

		protected Dictionary<Tile, List<Renderer>> tileRenderers;

		protected Dictionary<Tile, List<Light>> lightSources;

		protected Dictionary<Tile, List<ReflectionProbe>> reflectionProbes;

		protected Dictionary<Door, List<Renderer>> doorRenderers;

		private bool dirty;

		private DungeonGenerator generator;

		private Tile currentTile;

		private Queue<Tile> tilesToSearch;

		private List<Tile> searchedTiles;

		public bool Ready
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

		protected Transform targetTransform => null;

		public event VisibilityChangedDelegate TileVisibilityChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void SetDungeon(Dungeon dungeon)
		{
		}

		public virtual bool IsTileVisible(Tile tile)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CGetAllDoorsInDungeon_003Ed__34))]
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

		protected virtual void OnDungeonGenerationStatusChanged(DungeonGenerator generator, GenerationStatus status)
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual void RefreshVisibility()
		{
		}

		protected virtual void RefreshDoorVisibilities()
		{
		}

		protected virtual void SetDoorVisibility(Door door, bool visible)
		{
		}

		protected virtual void UpdateVisibleTiles()
		{
		}

		protected virtual void SetTileVisibility(Tile tile, bool visible)
		{
		}

		public virtual void UpdateRendererLists()
		{
		}

		protected Tile FindCurrentTile()
		{
			return null;
		}

		protected Tile SearchForNewCurrentTile()
		{
			return null;
		}
	}
}
