using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

[CreateAssetMenu(menuName = "ScriptableObjects/Level", order = 2)]
public class SelectableLevel : ScriptableObject
{
	public GameObject planetPrefab;

	public string sceneName;

	public int levelID;

	public bool lockedForDemo;

	[Space(3f)]
	public bool spawnEnemiesAndScrap;

	public string PlanetName;

	[TextArea(5, 15)]
	public string LevelDescription;

	public VideoClip videoReel;

	public string riskLevel;

	public float timeToArrive;

	[Header("Time")]
	public float OffsetFromGlobalTime;

	public float DaySpeedMultiplier;

	public bool planetHasTime;

	[Space(5f)]
	public RandomWeatherWithVariables[] randomWeathers;

	public bool overrideWeather;

	public LevelWeatherType overrideWeatherType;

	[Space(2f)]
	public LevelWeatherType currentWeather;

	[Space(7f)]
	[Header("Level Values")]
	public float factorySizeMultiplier;

	public IntWithRarity[] dungeonFlowTypes;

	[Space(3f)]
	public SpawnableMapObject[] spawnableMapObjects;

	public SpawnableOutsideObjectWithRarity[] spawnableOutsideObjects;

	[Space(3f)]
	public List<SpawnableItemWithRarity> spawnableScrap;

	public int minScrap;

	public int maxScrap;

	public int minTotalScrapValue;

	public int maxTotalScrapValue;

	[Space(3f)]
	public LevelAmbienceLibrary levelAmbienceClips;

	[Header("Level enemy values")]
	public int maxEnemyPowerCount;

	public int maxOutsideEnemyPowerCount;

	public int maxDaytimeEnemyPowerCount;

	[Space(3f)]
	public List<SpawnableEnemyWithRarity> Enemies;

	public List<SpawnableEnemyWithRarity> OutsideEnemies;

	[Space(4f)]
	public List<SpawnableEnemyWithRarity> DaytimeEnemies;

	[Space(3f)]
	public AnimationCurve enemySpawnChanceThroughoutDay;

	public AnimationCurve outsideEnemySpawnChanceThroughDay;

	public AnimationCurve daytimeEnemySpawnChanceThroughDay;

	public float spawnProbabilityRange;

	public float daytimeEnemiesProbabilityRange;

	public bool levelIncludesSnowFootprints;

	public string levelIconString;
}
