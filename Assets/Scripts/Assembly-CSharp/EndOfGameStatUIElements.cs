using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class EndOfGameStatUIElements
{
	public TextMeshProUGUI quotaNumerator;

	public TextMeshProUGUI quotaDenominator;

	public TextMeshProUGUI[] playerNamesText;

	public Image[] playerStates;

	public Sprite aliveIcon;

	public Sprite deceasedIcon;

	public Sprite missingIcon;

	public TextMeshProUGUI[] playerNotesText;

	public TextMeshProUGUI gradeLetter;

	public Image allPlayersDeadOverlay;

	public TextMeshProUGUI penaltyAddition;

	public TextMeshProUGUI penaltyTotal;

	public TextMeshProUGUI challengeCollectedText;

	public TextMeshProUGUI challengeRankText;
}
