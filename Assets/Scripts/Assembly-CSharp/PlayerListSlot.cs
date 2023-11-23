using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class PlayerListSlot
{
	public GameObject slotContainer;

	public GameObject volumeSliderContainer;

	public GameObject KickUserButton;

	public bool isConnected;

	public TextMeshProUGUI usernameHeader;

	public Slider volumeSlider;

	public ulong playerSteamId;
}
