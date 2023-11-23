using Unity.Netcode;
using UnityEngine;
using UnityEngine.Video;

public class TVScript : NetworkBehaviour
{
	public bool tvOn;

	private bool wasTvOnLastFrame;

	public MeshRenderer tvMesh;

	public VideoPlayer video;

	[Space(5f)]
	public VideoClip[] tvClips;

	public AudioClip[] tvAudioClips;

	[Space(5f)]
	private float currentClipTime;

	private int currentClip;

	public Material tvOnMaterial;

	public Material tvOffMaterial;

	public AudioClip switchTVOn;

	public AudioClip switchTVOff;

	public AudioSource tvSFX;

	private float timeSinceTurningOffTV;

	public Light tvLight;

	public void TurnTVOnOff(bool on)
	{
	}

	public void SwitchTVLocalClient()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void TurnOnTVServerRpc()
	{
	}

	[ClientRpc]
	public void TurnOnTVClientRpc()
	{
	}

	[ClientRpc]
	public void TurnOnTVAndSyncClientRpc(int clipIndex, float clipTime)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void TurnOffTVServerRpc()
	{
	}

	[ClientRpc]
	public void TurnOffTVClientRpc()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SyncTVServerRpc()
	{
	}

	[ClientRpc]
	public void SyncTVClientRpc(int clipIndex, float clipTime, bool isOn)
	{
	}

	private void SyncTimeAndClipWithClients(int clipIndex, float clipTime, bool isOn)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void TVFinishedClip(VideoPlayer source)
	{
	}

	private void Update()
	{
	}

	private void SetTVScreenMaterial(bool on)
	{
	}
}
