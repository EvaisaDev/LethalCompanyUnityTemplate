using UnityEngine;
using UnityEngine.Video;

[CreateAssetMenu(menuName = "ScriptableObjects/TerminalNode", order = 2)]
public class TerminalNode : ScriptableObject
{
	[TextArea(2, 20)]
	public string displayText;

	public string terminalEvent;

	[Space(5f)]
	public bool clearPreviousText;

	public int maxCharactersToType;

	[Space(5f)]
	[Header("Purchasing items")]
	public int buyItemIndex;

	public bool isConfirmationNode;

	public int buyRerouteToMoon;

	public int displayPlanetInfo;

	public bool lockedInDemo;

	[Space(3f)]
	public int shipUnlockableID;

	public bool buyUnlockable;

	public bool returnFromStorage;

	[Space(3f)]
	public int itemCost;

	[Header("Bestiary / Logs")]
	public int creatureFileID;

	public string creatureName;

	public int storyLogFileID;

	[Space(5f)]
	public bool overrideOptions;

	public bool acceptAnything;

	public CompatibleNoun[] terminalOptions;

	[Header("Misc")]
	public AudioClip playClip;

	public int playSyncedClip;

	public Texture displayTexture;

	public VideoClip displayVideo;

	public bool loadImageSlowly;

	public bool persistentImage;
}
