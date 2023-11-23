using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/AnomalyType", order = 1)]
public class AnomalyType : ScriptableObject
{
	public string anomalyName;

	[Space(10f)]
	[Header("Capturing")]
	public float anomalyMaxHealth;

	[Range(0f, 1f)]
	public float captureDifficulty;

	public AnimationCurve difficultyVariance;

	[Header("Spawning")]
	public AnimationCurve probabilityCurve;

	public int[] spawnableEnemies;

	public GameObject anomalyPrefab;
}
