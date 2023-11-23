using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DunGen
{
	[Serializable]
	public class Door : MonoBehaviour
	{
		public delegate void DoorStateChangedDelegate(Door door, bool isOpen);

		[HideInInspector]
		public Dungeon Dungeon;

		[HideInInspector]
		public Doorway DoorwayA;

		[HideInInspector]
		public Doorway DoorwayB;

		[HideInInspector]
		public Tile TileA;

		[HideInInspector]
		public Tile TileB;

		[SerializeField]
		private bool dontCullBehind;

		[SerializeField]
		private bool isOpen;

		public bool DontCullBehind
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ShouldCullBehind => false;

		public virtual bool IsOpen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event DoorStateChangedDelegate OnDoorStateChanged
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

		private void OnDestroy()
		{
		}

		public void SetDoorState(bool isOpen)
		{
		}
	}
}
