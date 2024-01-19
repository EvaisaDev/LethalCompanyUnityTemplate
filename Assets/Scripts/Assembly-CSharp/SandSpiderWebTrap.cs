using GameNetcodeStuff;
using UnityEngine;

public class SandSpiderWebTrap : MonoBehaviour, IHittable
{
	public SandSpiderAI mainScript;

	private bool hinderingLocalPlayer;

	public PlayerControllerB currentTrappedPlayer;

	public Transform leftBone;

	public Transform rightBone;

	public Transform centerOfWeb;

	public int trapID;

	public float zScale;

	public AudioSource webAudio;

	private bool webHasBeenBroken;

	public bool Hit(int force, Vector3 hitDirection, PlayerControllerB playerWhoHit = null, bool playHitSFX = false)
	{
		return false;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Update()
	{
	}

	private void Awake()
	{
	}

	private void CallPlayerLeaveWebOnDeath()
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	private void PlayerLeaveWeb(PlayerControllerB playerScript)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
