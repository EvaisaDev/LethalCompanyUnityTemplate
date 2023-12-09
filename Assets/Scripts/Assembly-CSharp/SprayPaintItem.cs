using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

public class SprayPaintItem : GrabbableObject
{
	public AudioSource sprayAudio;

	public AudioClip spraySFX;

	public AudioClip sprayNeedsShakingSFX;

	public AudioClip sprayStart;

	public AudioClip sprayStop;

	public AudioClip sprayCanEmptySFX;

	public AudioClip sprayCanNeedsShakingSFX;

	public AudioClip sprayCanShakeEmptySFX;

	public AudioClip[] sprayCanShakeSFX;

	public ParticleSystem sprayParticle;

	public ParticleSystem sprayCanNeedsShakingParticle;

	private bool isSpraying;

	private float sprayInterval;

	public float sprayIntervalSpeed;

	private Vector3 previousSprayPosition;

	public static List<GameObject> sprayPaintDecals;

	public static int sprayPaintDecalsIndex;

	public GameObject sprayPaintPrefab;

	public int maxSprayPaintDecals;

	private float sprayCanTank;

	private float sprayCanShakeMeter;

	public static DecalProjector previousSprayDecal;

	private float shakingCanTimer;

	private bool tryingToUseEmptyCan;

	public Material[] sprayCanMats;

	public Material[] particleMats;

	private int sprayCanMatsIndex;

	private RaycastHit sprayHit;

	public bool debugSprayPaint;

	private int addSprayPaintWithFrameDelay;

	private DecalProjector delayedSprayPaintDecal;

	private int sprayPaintMask;

	private bool makingAudio;

	private float audioInterval;

	public override void Start()
	{
	}

	public override void LoadItemSaveData(int saveData)
	{
	}

	public override int GetItemDataToSave()
	{
		return 0;
	}

	public override void EquipItem()
	{
	}

	public override void ItemActivate(bool used, bool buttonDown = true)
	{
	}

	private void PlayCanEmptyEffect(bool isEmpty)
	{
	}

	public override void ItemInteractLeftRight(bool right)
	{
	}

	public override void LateUpdate()
	{
	}

	public bool TrySpraying()
	{
		return false;
	}

	[ServerRpc]
	public void SprayPaintServerRpc(Vector3 sprayPos, Vector3 sprayRot)
	{
	}

	[ClientRpc]
	public void SprayPaintClientRpc(Vector3 sprayPos, Vector3 sprayRot)
	{
	}

	private void ToggleSprayCollisionOnHolder(bool enable)
	{
	}

	private bool AddSprayPaintLocal(Vector3 sprayPos, Vector3 sprayRot)
	{
		return false;
	}

	public void StartSpraying()
	{
	}

	public void StopSpraying()
	{
	}

	public override void PocketItem()
	{
	}

	public override void DiscardItem()
	{
	}
}
