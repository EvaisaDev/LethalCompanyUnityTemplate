using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DunGen.Graph;
using UnityEngine;

namespace DunGen
{
	public sealed class DoorwayPairFinder
	{
		[CompilerGenerated]
		private sealed class _003CGetPotentialDoorwayPairsForFirstTile_003Ed__18 : IEnumerable<DoorwayPair>, IEnumerable, IEnumerator<DoorwayPair>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private DoorwayPair _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public DoorwayPairFinder _003C_003E4__this;

			private List<GameObjectChance>.Enumerator _003C_003E7__wrap1;

			private GameObjectChance _003CtileWeight_003E5__3;

			private TileProxy _003CnextTile_003E5__4;

			private float _003Cweight_003E5__5;

			private IEnumerator<DoorwayProxy> _003C_003E7__wrap5;

			DoorwayPair IEnumerator<DoorwayPair>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(DoorwayPair);
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
			public _003CGetPotentialDoorwayPairsForFirstTile_003Ed__18(int _003C_003E1__state)
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

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<DoorwayPair> IEnumerable<DoorwayPair>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetPotentialDoorwayPairsForNonFirstTile_003Ed__17 : IEnumerable<DoorwayPair>, IEnumerable, IEnumerator<DoorwayPair>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private DoorwayPair _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public DoorwayPairFinder _003C_003E4__this;

			private IEnumerator<DoorwayProxy> _003C_003E7__wrap1;

			private DoorwayProxy _003CpreviousDoor_003E5__3;

			private List<GameObjectChance>.Enumerator _003C_003E7__wrap3;

			private GameObjectChance _003CtileWeight_003E5__5;

			private TileProxy _003CnextTile_003E5__6;

			private float _003Cweight_003E5__7;

			private IEnumerator<DoorwayProxy> _003C_003E7__wrap7;

			DoorwayPair IEnumerator<DoorwayPair>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(DoorwayPair);
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
			public _003CGetPotentialDoorwayPairsForNonFirstTile_003Ed__17(int _003C_003E1__state)
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

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<DoorwayPair> IEnumerable<DoorwayPair>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public static List<TileConnectionRule> CustomConnectionRules;

		public RandomStream RandomStream;

		public List<GameObjectChance> TileWeights;

		public TileProxy PreviousTile;

		public bool IsOnMainPath;

		public float NormalizedDepth;

		public DungeonArchetype Archetype;

		public bool? AllowRotation;

		public Vector3 UpVector;

		public TileMatchDelegate IsTileAllowedPredicate;

		public GetTileTemplateDelegate GetTileTemplateDelegate;

		public DungeonFlow DungeonFlow;

		private List<GameObjectChance> tileOrder;

		public Queue<DoorwayPair> GetDoorwayPairs(int? maxCount)
		{
			return null;
		}

		private int CompareDoorwaysTileWeight(DoorwayPair x, DoorwayPair y)
		{
			return 0;
		}

		private IEnumerable<DoorwayPair> OrderDoorwayPairs(List<DoorwayPair> potentialPairs, int count)
		{
			return null;
		}

		private List<GameObjectChance> CalculateOrderedListOfTiles()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetPotentialDoorwayPairsForNonFirstTile_003Ed__17))]
		private IEnumerable<DoorwayPair> GetPotentialDoorwayPairsForNonFirstTile()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetPotentialDoorwayPairsForFirstTile_003Ed__18))]
		private IEnumerable<DoorwayPair> GetPotentialDoorwayPairsForFirstTile()
		{
			return null;
		}

		private bool IsValidDoorwayPairing(DoorwayProxy a, DoorwayProxy b, TileProxy previousTile, TileProxy nextTile, ref float weight)
		{
			return false;
		}

		private float CalculateDoorwayWeight(DoorwayProxy doorway)
		{
			return 0f;
		}
	}
}
