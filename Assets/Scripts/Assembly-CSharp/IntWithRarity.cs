using System;
using UnityEngine;

[Serializable]
public class IntWithRarity
{
	public int id;

	[Range(0f, 300f)]
	public int rarity;
}
