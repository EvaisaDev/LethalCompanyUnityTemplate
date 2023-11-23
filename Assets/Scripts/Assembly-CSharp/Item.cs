using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Item", order = 1)]
public class Item : ScriptableObject
{
	public int itemId;

	public string itemName;

	[Space(3f)]
	public List<ItemGroup> spawnPositionTypes;

	[Space(3f)]
	public bool twoHanded;

	public bool twoHandedAnimation;

	public bool canBeGrabbedBeforeGameStart;

	[Space(3f)]
	public float weight;

	public bool itemIsTrigger;

	public bool holdButtonUse;

	public bool itemSpawnsOnGround;

	[Space(5f)]
	public bool isConductiveMetal;

	[Header("Scrap-collection")]
	public bool isScrap;

	public int creditsWorth;

	public bool lockedInDemo;

	public int highestSalePercentage;

	[Space(3f)]
	public int maxValue;

	public int minValue;

	public GameObject spawnPrefab;

	[Space(3f)]
	[Header("Battery")]
	public bool requiresBattery;

	public float batteryUsage;

	public bool automaticallySetUsingPower;

	[Space(5f)]
	public Sprite itemIcon;

	[Space(5f)]
	[Header("Player animations")]
	public string grabAnim;

	public string useAnim;

	public string pocketAnim;

	public string throwAnim;

	[Space(5f)]
	public float grabAnimationTime;

	[Header("Player SFX")]
	public AudioClip grabSFX;

	public AudioClip dropSFX;

	public AudioClip pocketSFX;

	public AudioClip throwSFX;

	[Header("Netcode")]
	public bool syncGrabFunction;

	public bool syncUseFunction;

	public bool syncDiscardFunction;

	public bool syncInteractLRFunction;

	[Header("Save data")]
	public bool saveItemVariable;

	[Header("MISC")]
	public bool isDefensiveWeapon;

	[Space(3f)]
	public string[] toolTips;

	public float verticalOffset;

	public int floorYOffset;

	public bool allowDroppingAheadOfPlayer;

	public Vector3 restingRotation;

	public Vector3 rotationOffset;

	public Vector3 positionOffset;

	public bool meshOffset;

	public Mesh[] meshVariants;

	public Material[] materialVariants;

	public bool usableInSpecialAnimations;

	public bool canBeInspected;
}
