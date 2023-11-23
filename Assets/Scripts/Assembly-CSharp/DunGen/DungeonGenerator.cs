using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DunGen.Graph;
using UnityEngine;
using UnityEngine.Serialization;

namespace DunGen
{
	[Serializable]
	public class DungeonGenerator : ISerializationCallbackReceiver
	{
		[CompilerGenerated]
		private sealed class _003CGenerateBranchPaths_003Ed__103 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DungeonGenerator _003C_003E4__this;

			private int[] _003CmainPathBranches_003E5__2;

			private int _003Cb_003E5__3;

			private TileProxy _003Ctile_003E5__4;

			private int _003CbranchCount_003E5__5;

			private int _003Ci_003E5__6;

			private TileProxy _003CpreviousTile_003E5__7;

			private int _003CbranchDepth_003E5__8;

			private int _003Cj_003E5__9;

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
			public _003CGenerateBranchPaths_003Ed__103(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CGenerateMainPath_003Ed__100 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DungeonGenerator _003C_003E4__this;

			private List<List<TileSet>> _003CtileSets_003E5__2;

			private List<DungeonArchetype> _003Carchetypes_003E5__3;

			private List<GraphNode> _003Cnodes_003E5__4;

			private List<GraphLine> _003Clines_003E5__5;

			private int _003CtileRetryCount_003E5__6;

			private int _003CtotalForLoopRetryCount_003E5__7;

			private int _003Cj_003E5__8;

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
			public _003CGenerateMainPath_003Ed__100(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CInnerGenerate_003Ed__94 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool isRetry;

			public DungeonGenerator _003C_003E4__this;

			private List<InjectedTile>.Enumerator _003C_003E7__wrap1;

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
			public _003CInnerGenerate_003Ed__94(int _003C_003E1__state)
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
		}

		[CompilerGenerated]
		private sealed class _003COuterGenerate_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DungeonGenerator _003C_003E4__this;

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
			public _003COuterGenerate_003Ed__91(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CPostProcess_003Ed__114 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DungeonGenerator _003C_003E4__this;

			private int _003Clength_003E5__2;

			private int _003CmaxBranchDepth_003E5__3;

			private List<DungeonGeneratorPostProcessStep>.Enumerator _003C_003E7__wrap3;

			private DungeonGeneratorPostProcessStep _003Cstep_003E5__5;

			private IEnumerator<Tile> _003C_003E7__wrap5;

			private Tile _003Ctile_003E5__7;

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
			public _003CPostProcess_003Ed__114(int _003C_003E1__state)
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

			private void _003C_003Em__Finally2()
			{
			}

			private void _003C_003Em__Finally3()
			{
			}

			private void _003C_003Em__Finally4()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public const int CurrentFileVersion = 1;

		[SerializeField]
		[FormerlySerializedAs("AllowImmediateRepeats")]
		private bool allowImmediateRepeats;

		public int Seed;

		public bool ShouldRandomizeSeed;

		public int MaxAttemptCount;

		public bool UseMaximumPairingAttempts;

		public int MaxPairingAttempts;

		public bool IgnoreSpriteBounds;

		public AxisDirection UpDirection;

		[FormerlySerializedAs("OverrideAllowImmediateRepeats")]
		public bool OverrideRepeatMode;

		public TileRepeatMode RepeatMode;

		public bool OverrideAllowTileRotation;

		public bool AllowTileRotation;

		public bool DebugRender;

		public float LengthMultiplier;

		public bool PlaceTileTriggers;

		public int TileTriggerLayer;

		public bool GenerateAsynchronously;

		public float MaxAsyncFrameMilliseconds;

		public float PauseBetweenRooms;

		public bool RestrictDungeonToBounds;

		public Bounds TilePlacementBounds;

		public float OverlapThreshold;

		public float Padding;

		public bool DisallowOverhangs;

		public GameObject Root;

		public DungeonFlow DungeonFlow;

		protected int retryCount;

		protected DungeonProxy proxyDungeon;

		protected readonly Dictionary<TilePlacementResult, int> tilePlacementResultCounters;

		protected readonly List<GameObject> useableTiles;

		protected int targetLength;

		protected List<InjectedTile> tilesPendingInjection;

		protected List<DungeonGeneratorPostProcessStep> postProcessSteps;

		[SerializeField]
		private int fileVersion;

		private int nextNodeIndex;

		private DungeonArchetype currentArchetype;

		private GraphLine previousLineSegment;

		private List<TileProxy> preProcessData;

		private Stopwatch yieldTimer;

		private Dictionary<TileProxy, InjectedTile> injectedTiles;

		public RandomStream RandomStream
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public Vector3 UpVector => default(Vector3);

		public GenerationStatus Status
		{
			[CompilerGenerated]
			get
			{
				return default(GenerationStatus);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public GenerationStats GenerationStats
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

		public int ChosenSeed
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public Dungeon CurrentDungeon
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

		public bool IsGenerating
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsAnalysis
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

		public event GenerationStatusDelegate OnGenerationStatusChanged
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

		public static event GenerationStatusDelegate OnAnyDungeonGenerationStatusChanged
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

		public event TileInjectionDelegate TileInjectionMethods
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

		public event Action Cleared
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

		public event Action Retrying
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

		public DungeonGenerator()
		{
		}

		public DungeonGenerator(GameObject root)
		{
		}

		public void Generate()
		{
		}

		public void Cancel()
		{
		}

		public Dungeon DetachDungeon()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003COuterGenerate_003Ed__91))]
		protected virtual IEnumerator OuterGenerate()
		{
			return null;
		}

		private Coroutine Wait(IEnumerator routine)
		{
			return null;
		}

		public void RandomizeSeed()
		{
		}

		[IteratorStateMachine(typeof(_003CInnerGenerate_003Ed__94))]
		protected virtual IEnumerator InnerGenerate(bool isRetry)
		{
			return null;
		}

		private void PruneBranches()
		{
		}

		public virtual void Clear(bool stopCoroutines)
		{
		}

		private void ChangeStatus(GenerationStatus status)
		{
		}

		protected virtual void PreProcess()
		{
		}

		protected virtual void GatherTilesToInject()
		{
		}

		[IteratorStateMachine(typeof(_003CGenerateMainPath_003Ed__100))]
		protected virtual IEnumerator GenerateMainPath()
		{
			return null;
		}

		private bool ShouldSkipFrame(bool isRoomPlacement)
		{
			return false;
		}

		private YieldInstruction GetRoomPause()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGenerateBranchPaths_003Ed__103))]
		protected virtual IEnumerator GenerateBranchPaths()
		{
			return null;
		}

		protected virtual TileProxy AddTile(TileProxy attachTo, IEnumerable<TileSet> useableTileSets, float normalizedDepth, DungeonArchetype archetype, TilePlacementResult result = TilePlacementResult.None)
		{
			return null;
		}

		protected void AddTilePlacementResult(TilePlacementResult result)
		{
		}

		protected TilePlacementResult TryPlaceTile(DoorwayPair pair, DungeonArchetype archetype, out TileProxy tile)
		{
			tile = null;
			return default(TilePlacementResult);
		}

		protected TileProxy GetTileTemplate(GameObject prefab)
		{
			return null;
		}

		protected TileProxy PickRandomTemplate(DoorwaySocket socketGroupFilter)
		{
			return null;
		}

		protected int NormalizedDepthToIndex(float normalizedDepth)
		{
			return 0;
		}

		protected float IndexToNormalizedDepth(int index)
		{
			return 0f;
		}

		protected bool IsCollidingWithAnyTile(TileProxy newTile, TileProxy previousTile)
		{
			return false;
		}

		public void RegisterPostProcessStep(Action<DungeonGenerator> postProcessCallback, int priority = 0, PostProcessPhase phase = PostProcessPhase.AfterBuiltIn)
		{
		}

		public void UnregisterPostProcessStep(Action<DungeonGenerator> postProcessCallback)
		{
		}

		[IteratorStateMachine(typeof(_003CPostProcess_003Ed__114))]
		protected virtual IEnumerator PostProcess()
		{
			return null;
		}

		protected void ProcessProps(Tile tile, GameObject root)
		{
		}

		protected virtual void ProcessGlobalProps()
		{
		}

		protected virtual void PlaceLocksAndKeys()
		{
		}

		protected virtual void LockDoorway(Doorway doorway, Key key, KeyManager keyManager)
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
