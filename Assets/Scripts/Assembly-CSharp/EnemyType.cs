using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/EnemyType", order = 1)]
public class EnemyType : ScriptableObject
{
	public string enemyName;

	[Header("Spawning logic")]
	[Tooltip("Determines how likely an enemy is to spawn throughout the day.")]
	public AnimationCurve probabilityCurve;

	public bool spawningDisabled;

	[Tooltip("X axis is the number of this enemy type that have spawned, divided by 10; Y axis is a multiplier to probabilityCurve.")]
	public AnimationCurve numberSpawnedFalloff;

	public bool useNumberSpawnedFalloff;

	public GameObject enemyPrefab;

	[Tooltip("Adds to a global counter determining how many enemies can spawn.")]
	public int PowerLevel;

	[Tooltip("An individual counter determining how many of this enemy can spawn, regardless of how many other enemies there are.")]
	public int MaxCount;

	public int numberSpawned;

	public bool isOutsideEnemy;

	[Space(3f)]
	public bool isDaytimeEnemy;

	[Range(0f, 1f)]
	public float normalizedTimeInDayToLeave;

	[Space(3f)]
	[Header("Misc. ingame properties")]
	public float stunTimeMultiplier;

	public float doorSpeedMultiplier;

	public float stunGameDifficultyMultiplier;

	public bool canBeStunned;

	public bool canDie;

	public bool destroyOnDeath;

	public bool canSeeThroughFog;

	[Space(10f)]
	[Header("Vent Properties")]
	public float timeToPlayAudio;

	public float loudnessMultiplier;

	public AudioClip overrideVentSFX;

	[Space(5f)]
	public AudioClip hitBodySFX;

	public AudioClip hitEnemyVoiceSFX;

	public AudioClip deathSFX;

	public AudioClip stunSFX;

	public MiscAnimation[] miscAnimations;

	public AudioClip[] audioClips;
}
