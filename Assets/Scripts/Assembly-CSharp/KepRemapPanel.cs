using System.Collections.Generic;
using UnityEngine;

public class KepRemapPanel : MonoBehaviour
{
	public List<RemappableKey> remappableKeys;

	private bool hasLoadedKeyRemappingSlots;

	public List<GameObject> keySlots;

	public GameObject keyRemapSlotPrefab;

	public RectTransform keyRemapContainer;

	public float maxVertical;

	public float horizontalOffset;

	public float verticalOffset;

	public int currentVertical;

	public int currentHorizontal;

	public GameObject sectionTextPrefab;

	private void LoadRemappedKeys()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}
}
