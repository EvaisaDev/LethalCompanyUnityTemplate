using UnityEngine;

public class TestEnemy : EnemyAI
{
	public float detectionRadius;

	private Collider[] allPlayerColliders;

	private float closestPlayerDist;

	private Collider tempTargetCollider;

	public bool detectingPlayers;

	private bool tempDebug;

	public override void Start()
	{
	}

	public override void DoAIInterval()
	{
	}

	public override void Update()
	{
	}
}
