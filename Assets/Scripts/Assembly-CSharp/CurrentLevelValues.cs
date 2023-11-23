using System;
using UnityEngine;

[Serializable]
public class CurrentLevelValues
{
	public int difficultyLevel;

	[Header("Scrap-collecting difficulty")]
	public int minScrap;

	public int maxScrap;

	public int minTotalScrapValue;

	public int maxTotalScrapValue;

	[Space(5f)]
	public float levelSizeMultiplier;
}
