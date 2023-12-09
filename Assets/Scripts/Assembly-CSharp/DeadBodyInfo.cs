using GameNetcodeStuff;
using UnityEngine;

public class DeadBodyInfo : MonoBehaviour
{
	public int playerObjectId;

	public PlayerControllerB playerScript;

	public Rigidbody[] bodyParts;

	[Space(3f)]
	public Rigidbody attachedLimb;

	public Transform attachedTo;

	[Space(2f)]
	public Rigidbody secondaryAttachedLimb;

	public Transform secondaryAttachedTo;

	[Space(5f)]
	public int timesOutOfBounds;

	public Vector3 spawnPosition;

	[Space(3f)]
	private Vector3 forceDirection;

	public float maxVelocity;

	public float speedMultiplier;

	public bool matchPositionExactly;

	public bool wasMatchingPosition;

	private Rigidbody previousAttachedLimb;

	[Space(3f)]
	public bool bodyBleedingHeavily;

	private Vector3 previousBodyPosition;

	private int bloodAmount;

	private int maxBloodAmount;

	public GameObject[] bodyBloodDecals;

	[Space(3f)]
	private bool bodyMovedThisFrame;

	private float syncBodyPositionTimer;

	private bool serverSyncedPositionWithClients;

	public bool seenByLocalPlayer;

	public AudioSource bodyAudio;

	private float velocityLastFrame;

	public Transform radarDot;

	private float timeSinceLastCollisionSFX;

	public bool parentedToShip;

	public bool detachedHead;

	public Transform detachedHeadObject;

	public Vector3 detachedHeadVelocity;

	public ParticleSystem bloodSplashParticle;

	public ParticleSystem beamUpParticle;

	public ParticleSystem beamOutParticle;

	public AudioSource playAudioOnDeath;

	public CauseOfDeath causeOfDeath;

	private float resetBodyPartsTimer;

	public GrabbableObject grabBodyObject;

	private bool bodySetToKinematic;

	public bool lerpBeforeMatchingPosition;

	private float moveToExactPositionTimer;

	public bool canBeGrabbedBackByPlayers;

	public bool isInShip;

	public bool deactivated;

	public bool overrideSpawnPosition;

	private void FloatBodyToWaterSurface()
	{
	}

	private void StopFloatingBody()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void DetectIfSeenByLocalPlayer()
	{
	}

	private void LateUpdate()
	{
	}

	private void DetectBodyMovedDistanceThreshold()
	{
	}

	private void ResetBodyPositionIfTooFarFromAttachment()
	{
	}

	private void EnableCollisionOnBodyParts()
	{
	}

	public void MakeCorpseBloody()
	{
	}

	public void SetBodyPartsKinematic(bool setKinematic = true)
	{
	}

	public void DeactivateBody(bool setActive)
	{
	}

	public void ResetRagdollPosition()
	{
	}

	public void SetRagdollPositionSafely(Vector3 newPosition, bool disableSpecialEffects = false)
	{
	}

	public void AddForceToBodyPart(int bodyPartIndex, Vector3 force)
	{
	}

	public void ChangeMesh(Mesh changeMesh, Material changeMaterial = null)
	{
	}
}
