using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DunGen.Tags;
using UnityEngine;
using UnityEngine.Serialization;

namespace DunGen
{
	[AddComponentMenu("DunGen/Doorway")]
	public class Doorway : MonoBehaviour, ISerializationCallbackReceiver
	{
		public const int CurrentFileVersion = 1;

		public int DoorPrefabPriority;

		public List<GameObjectWeight> ConnectorPrefabWeights;

		public List<GameObjectWeight> BlockerPrefabWeights;

		public bool AvoidRotatingDoorPrefab;

		public bool AvoidRotatingBlockerPrefab;

		[FormerlySerializedAs("AddWhenInUse")]
		public List<GameObject> ConnectorSceneObjects;

		[FormerlySerializedAs("AddWhenNotInUse")]
		public List<GameObject> BlockerSceneObjects;

		public TagContainer Tags;

		public int? LockID;

		[SerializeField]
		[FormerlySerializedAs("SocketGroup")]
		private DoorwaySocketType socketGroup_obsolete;

		[SerializeField]
		[FormerlySerializedAs("DoorPrefabs")]
		private List<GameObject> doorPrefabs_obsolete;

		[SerializeField]
		[FormerlySerializedAs("BlockerPrefabs")]
		private List<GameObject> blockerPrefabs_obsolete;

		[SerializeField]
		private DoorwaySocket socket;

		[SerializeField]
		private GameObject doorPrefabInstance;

		[SerializeField]
		private Door doorComponent;

		[SerializeField]
		private Tile tile;

		[SerializeField]
		private Doorway connectedDoorway;

		[SerializeField]
		private bool hideConditionalObjects;

		[SerializeField]
		private int fileVersion;

		internal bool placedByGenerator;

		public bool HasSocketAssigned => false;

		public DoorwaySocket Socket => null;

		public Tile Tile
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public bool IsLocked => false;

		public bool HasDoorPrefabInstance => false;

		public GameObject UsedDoorPrefabInstance => null;

		public Door DoorComponent => null;

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

		public Doorway ConnectedDoorway
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public bool HideConditionalObjects
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void OnDrawGizmos()
		{
		}

		internal void SetUsedPrefab(GameObject doorPrefab)
		{
		}

		internal void RemoveUsedPrefab()
		{
		}

		internal void DebugDraw()
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
