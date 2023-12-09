using Unity.Netcode;
using UnityEngine;

public class RadarBoosterItem : GrabbableObject
{
	public bool radarEnabled;

	public Animator radarBoosterAnimator;

	public GameObject radarDot;

	public AudioSource pingAudio;

	public AudioClip pingSFX;

	public AudioSource radarBoosterAudio;

	public AudioClip turnOnSFX;

	public AudioClip turnOffSFX;

	public AudioClip flashSFX;

	public string radarBoosterName;

	private bool setRandomBoosterName;

	private int timesPlayingPingAudioInOneSpot;

	private Vector3 pingAudioLastPosition;

	private float timeSincePlayingPingAudio;

	private int radarBoosterNameIndex;

	private float flashCooldown;

	public Transform radarSpherePosition;

	public override void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public override int GetItemDataToSave()
	{
		return 0;
	}

	public override void LoadItemSaveData(int saveData)
	{
	}

	public void FlashAndSync()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void RadarBoosterFlashServerRpc()
	{
	}

	[ClientRpc]
	public void RadarBoosterFlashClientRpc()
	{
	}

	public void Flash()
	{
	}

	public void SetRadarBoosterNameLocal(string newName)
	{
	}

	private void RemoveBoosterFromRadar()
	{
	}

	private void AddBoosterToRadar()
	{
	}

	public void EnableRadarBooster(bool enable)
	{
	}

	public void PlayPingAudio()
	{
	}

	public void PlayPingAudioAndSync()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void PingRadarBoosterServerRpc(int playerWhoPlayedPing)
	{
	}

	[ClientRpc]
	public void PingRadarBoosterClientRpc(int playerWhoPlayedPing)
	{
	}

	public override void EquipItem()
	{
	}

	public override void ItemActivate(bool used, bool buttonDown = true)
	{
	}

	public override void PocketItem()
	{
	}

	public override void DiscardItem()
	{
	}

	public override void Update()
	{
	}
}
