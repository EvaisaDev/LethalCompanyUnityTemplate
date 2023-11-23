using Unity.Netcode;
using UnityEngine;

public abstract class Anomaly : NetworkBehaviour
{
	public AnomalyType anomalyType;

	public float initialInstability;

	public float difficultyMultiplier;

	public float normalizedHealth;

	public NetworkObject thisNetworkObject;

	public float maxHealth;

	[HideInInspector]
	public float health;

	[HideInInspector]
	public float removingHealth;

	[HideInInspector]
	public float usedInstability;

	public RoundManager roundManager;

	[Header("Misc properties")]
	public bool raycastToSurface;

	private bool addingInstability;

	public virtual void Start()
	{
	}

	public virtual void AnomalyDespawn(bool removedByPatcher = false)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void DespawnAnomalyServerRpc()
	{
	}

	public virtual void Update()
	{
	}
}
