using System;
using System.Collections.Generic;
using DunGen.Tags;
using UnityEngine;
using UnityEngine.Serialization;

namespace DunGen.Graph
{
	[Serializable]
	[CreateAssetMenu(fileName = "New Dungeon", menuName = "DunGen/Dungeon Flow", order = 700)]
	public class DungeonFlow : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		public sealed class GlobalPropSettings
		{
			public int ID;

			public IntRange Count;

			public GlobalPropSettings()
			{
			}

			public GlobalPropSettings(int id, IntRange count)
			{
			}
		}

		public enum TagConnectionMode
		{
			Accept = 0,
			Reject = 1
		}

		public enum BranchPruneMode
		{
			AnyTagPresent = 0,
			AllTagsMissing = 1
		}

		public const int FileVersion = 1;

		[SerializeField]
		[FormerlySerializedAs("GlobalPropGroupIDs")]
		private List<int> globalPropGroupID_obsolete;

		[SerializeField]
		[FormerlySerializedAs("GlobalPropRanges")]
		private List<IntRange> globalPropRanges_obsolete;

		public IntRange Length;

		public BranchMode BranchMode;

		public IntRange BranchCount;

		public List<GlobalPropSettings> GlobalProps;

		public KeyManager KeyManager;

		[Range(0f, 1f)]
		public float DoorwayConnectionChance;

		public bool RestrictConnectionToSameSection;

		public List<TileInjectionRule> TileInjectionRules;

		public TagConnectionMode TileTagConnectionMode;

		public List<TagPair> TileConnectionTags;

		public BranchPruneMode BranchTagPruneMode;

		public List<Tag> BranchPruneTags;

		public List<GraphNode> Nodes;

		public List<GraphLine> Lines;

		[SerializeField]
		private int currentFileVersion;

		public void Reset()
		{
		}

		public GraphLine GetLineAtDepth(float normalizedDepth)
		{
			return null;
		}

		public DungeonArchetype[] GetUsedArchetypes()
		{
			return null;
		}

		public TileSet[] GetUsedTileSets()
		{
			return null;
		}

		public bool ShouldPruneTileWithTags(TagContainer tileTags)
		{
			return false;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public bool CanTilesConnect(Tile tileA, Tile tileB)
		{
			return false;
		}

		public bool CanDoorwaysConnect(Tile tileA, Tile tileB, Doorway doorwayA, Doorway doorwayB)
		{
			return false;
		}

		private bool HasMatchingTagPair(Tile tileA, Tile tileB)
		{
			return false;
		}
	}
}
