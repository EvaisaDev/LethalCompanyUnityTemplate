using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class SpringManAI : EnemyAI
{
	public AISearchRoutine searchForPlayers;

	private float checkLineOfSightInterval;

	private bool hasEnteredChaseMode;

	private bool stoppingMovement;

	private bool hasStopped;

	public AnimationStopPoints animStopPoints;

	private float currentChaseSpeed;

	private float currentAnimSpeed;

	private PlayerControllerB previousTarget;

	private bool wasOwnerLastFrame;

	private float stopAndGoMinimumInterval;

	private float timeSinceHittingPlayer;

	public AudioClip[] springNoises;

	public Collider mainCollider;

	public override void DoAIInterval()
	{
	}

	public override void Update()
	{
	}

	[ServerRpc]
	public void SetAnimationStopServerRpc()
	{
	}

	[ClientRpc]
	public void SetAnimationStopClientRpc()
	{
	}

	[ServerRpc]
	public void SetAnimationGoServerRpc()
	{
	}

	[ClientRpc]
	public void SetAnimationGoClientRpc()
	{
	}

	public override void OnCollideWithPlayer(Collider other)
	{
	}
}
