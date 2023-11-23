using Unity.Netcode;
using UnityEngine;

public class EnemyVent : NetworkBehaviour
{
	public float spawnTime;

	public bool occupied;

	[Space(5f)]
	public EnemyType enemyType;

	public int enemyTypeIndex;

	[Space(10f)]
	public AudioSource ventAudio;

	public AudioLowPassFilter lowPassFilter;

	public AudioClip ventCrawlSFX;

	public Transform floorNode;

	private bool isPlayingAudio;

	private RoundManager roundManager;

	public Animator ventAnimator;

	public bool ventIsOpen;

	private void Start()
	{
	}

	private void BeginVentSFX()
	{
	}

	[ClientRpc]
	public void OpenVentClientRpc()
	{
	}

	[ClientRpc]
	public void SyncVentSpawnTimeClientRpc(int time, int enemyIndex)
	{
	}

	private void Update()
	{
	}
}
