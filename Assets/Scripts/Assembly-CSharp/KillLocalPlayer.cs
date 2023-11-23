using GameNetcodeStuff;
using UnityEngine;

public class KillLocalPlayer : MonoBehaviour
{
	public bool dontSpawnBody;

	public CauseOfDeath causeOfDeath;

	public bool justDamage;

	public StartOfRound playersManager;

	public int deathAnimation;

	[Space(5f)]
	public RoundManager roundManager;

	public Transform spawnEnemyPosition;

	[Space(5f)]
	public int enemySpawnNumber;

	public int playAudioOnDeath;

	public void KillPlayer(PlayerControllerB playerWhoTriggered)
	{
	}

	public void SpawnEnemy()
	{
	}
}
