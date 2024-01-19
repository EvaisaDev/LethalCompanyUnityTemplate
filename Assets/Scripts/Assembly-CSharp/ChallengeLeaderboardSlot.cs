using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeLeaderboardSlot : MonoBehaviour
{
	public RawImage profileIcon;

	public TextMeshProUGUI userNameText;

	public TextMeshProUGUI rankNumText;

	public TextMeshProUGUI scrapCollectedText;

	public SteamId steamId;

	public void SetSlotValues(string userName, int rankNum, int scrapCollected, SteamId playerSteamId, int entryDetails)
	{
	}

	public void ClickProfileIcon()
	{
	}
}
