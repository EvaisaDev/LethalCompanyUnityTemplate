using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DunGen.Tags;
using UnityEngine;
using UnityEngine.Serialization;

namespace DunGen
{
	[AddComponentMenu("DunGen/Tile")]
	public class Tile : MonoBehaviour, ISerializationCallbackReceiver
	{
		public const int CurrentFileVersion = 1;

		[SerializeField]
		[FormerlySerializedAs("AllowImmediateRepeats")]
		private bool allowImmediateRepeats;

		public bool AllowRotation;

		public TileRepeatMode RepeatMode;

		public bool OverrideAutomaticTileBounds;

		public Bounds TileBoundsOverride;

		public Doorway Entrance;

		public Doorway Exit;

		public bool OverrideConnectionChance;

		public float ConnectionChance;

		public TagContainer Tags;

		public List<Doorway> AllDoorways;

		public List<Doorway> UsedDoorways;

		public List<Doorway> UnusedDoorways;

		[SerializeField]
		private TilePlacementData placement;

		[SerializeField]
		private int fileVersion;

		[HideInInspector]
		public Bounds Bounds => default(Bounds);

		public TilePlacementData Placement
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public Dungeon Dungeon
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		internal void AddTriggerVolume()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		public IEnumerable<Tile> GetAdjactedTiles()
		{
			return null;
		}

		public bool IsAdjacentTo(Tile other)
		{
			return false;
		}

		public Doorway GetEntranceDoorway()
		{
			return null;
		}

		public Doorway GetExitDoorway()
		{
			return null;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
