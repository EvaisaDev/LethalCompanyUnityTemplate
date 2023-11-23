using System;
using UnityEngine;

[Serializable]
public class QuotaSettings
{
	[Tooltip("The starting profit quota")]
	public int startingQuota;

	public int startingCredits;

	public int deadlineDaysAmount;

	[Space(5f)]
	[Tooltip("Higher value means a less steep exponential increase")]
	public float increaseSteepness;

	[Tooltip("The minimum amount to increase")]
	public float baseIncrease;

	[Tooltip("A random Y coordinate on this line is picked and multiplied with the increase amount")]
	public AnimationCurve randomizerCurve;

	[Tooltip("This determines the severity of the randomizer curve")]
	public float randomizerMultiplier;
}
