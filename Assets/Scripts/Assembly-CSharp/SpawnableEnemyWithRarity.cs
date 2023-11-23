using System;
using UnityEngine;

[Serializable]
public class SpawnableEnemyWithRarity
{
	public EnemyType enemyType;

	[Range(0f, 100f)]
	public int rarity;
}
