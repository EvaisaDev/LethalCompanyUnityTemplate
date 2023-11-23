using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class LassoManAI : EnemyAI
{
	public AISearchRoutine searchForPlayers;

	private float checkLineOfSightInterval;

	public float maxSearchAndRoamRadius;

	[Space(5f)]
	public float noticePlayerTimer;

	private bool hasEnteredChaseMode;

	private bool lostPlayerInChase;

	private bool beginningChasingThisClient;

	private float timeSinceHittingPlayer;

	public DeadBodyInfo currentlyHeldBody;

	public override void Start()
	{
	}

	public override void DoAIInterval()
	{
	}

	public override void FinishedCurrentSearchRoutine()
	{
	}

	public override void Update()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void BeginChasingPlayerServerRpc(int playerObjectId)
	{
	}

	[ClientRpc]
	public void BeginChasingPlayerClientRpc(int playerObjectId)
	{
	}

	[ServerRpc]
	public void MakeScreechNoiseServerRpc()
	{
	}

	[ClientRpc]
	public void MakeScreechNoiseClientRpc()
	{
	}

	public override void OnCollideWithPlayer(Collider other)
	{
	}

	public override void KillEnemy(bool destroy = false)
	{
	}

	public override void HitEnemy(int force = 1, PlayerControllerB playerWhoHit = null, bool playHitSFX = false)
	{
	}
}
