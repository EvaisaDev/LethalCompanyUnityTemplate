using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DunGen
{
	[AddComponentMenu("DunGen/Character")]
	public class DungenCharacter : MonoBehaviour
	{
		private static readonly List<DungenCharacter> allCharacters;

		private List<Tile> overlappingTiles;

		public static ReadOnlyCollection<DungenCharacter> AllCharacters
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

		public Tile CurrentTile => null;

		public static event DungenCharacterDelegate CharacterAdded
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

		public static event DungenCharacterDelegate CharacterRemoved
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

		public event CharacterTileChangedEvent OnTileChanged
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

		static DungenCharacter()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		internal void ForceRecheckTile()
		{
		}

		protected virtual void OnTileChangedEvent(Tile previousTile, Tile newTile)
		{
		}

		internal void OnTileEntered(Tile tile)
		{
		}

		internal void OnTileExited(Tile tile)
		{
		}
	}
}
