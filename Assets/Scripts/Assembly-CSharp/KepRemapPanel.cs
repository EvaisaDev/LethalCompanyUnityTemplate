using System.Collections.Generic;
using UnityEngine;

public class KepRemapPanel : MonoBehaviour
{
	public List<RemappableKey> remappableKeys;

	public List<GameObject> keySlots;

	public GameObject keyRemapSlotPrefab;

	public RectTransform keyRemapContainer;

	public float maxVertical;

	public float horizontalOffset;

	public float verticalOffset;

	public int currentVertical;

	public int currentHorizontal;

	public GameObject sectionTextPrefab;

	public void ResetKeybindsUI()
	{
	}

	private void OnDisable()
	{
	}

	public void UnloadKeybindsUI()
	{
	}

	public void LoadKeybindsUI()
	{
	}

	private void OnEnable()
	{
	}
}
