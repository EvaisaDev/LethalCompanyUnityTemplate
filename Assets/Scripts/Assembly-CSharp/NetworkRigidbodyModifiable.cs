using Unity.Netcode;
using Unity.Netcode.Components;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(NetworkTransform))]
public class NetworkRigidbodyModifiable : NetworkBehaviour
{
	private Rigidbody m_Rigidbody;

	private NetworkTransform m_NetworkTransform;

	private bool m_OriginalKinematic;

	public bool kinematicOnOwner;

	public bool nonKinematicWhenDropping;

	private RigidbodyInterpolation m_OriginalInterpolation;

	private bool m_IsAuthority;

	private bool HasAuthority => false;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	public void UpdateRigidbodyKinematicMode()
	{
	}

	public override void OnNetworkSpawn()
	{
	}

	public override void OnNetworkDespawn()
	{
	}
}
