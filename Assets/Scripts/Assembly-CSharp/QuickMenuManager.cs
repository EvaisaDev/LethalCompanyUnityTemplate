using Dissonance;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuickMenuManager : MonoBehaviour
{
	[Header("HUD")]
	public TextMeshProUGUI interactTipText;

	public TextMeshProUGUI leaveGameClarificationText;

	public Image cursorIcon;

	[Header("In-game Menu")]
	public GameObject menuContainer;

	public GameObject mainButtonsPanel;

	public GameObject leaveGameConfirmPanel;

	public GameObject settingsPanel;

	[Space(3f)]
	public GameObject ConfirmKickUserPanel;

	public TextMeshProUGUI ConfirmKickPlayerText;

	public bool isMenuOpen;

	private int currentMicrophoneDevice;

	public TextMeshProUGUI currentMicrophoneText;

	public DissonanceComms voiceChatModule;

	public TextMeshProUGUI changesNotAppliedText;

	public TextMeshProUGUI settingsBackButton;

	public GameObject PleaseConfirmChangesSettingsPanel;

	public Button PleaseConfirmChangesSettingsPanelBackButton;

	public CanvasGroup inviteFriendsTextAlpha;

	[Header("Player list")]
	public PlayerListSlot[] playerListSlots;

	public GameObject playerListPanel;

	private int playerObjToKick;

	private void Start()
	{
	}

	public void OpenQuickMenu()
	{
	}

	public void CloseQuickMenu()
	{
	}

	public void CloseQuickMenuPanels()
	{
	}

	public void DisableInviteFriendsButton()
	{
	}

	public void InviteFriendsButton()
	{
	}

	public void LeaveGame()
	{
	}

	public void LeaveGameConfirm()
	{
	}

	public void EnableUIPanel(GameObject enablePanel)
	{
	}

	public void DisableUIPanel(GameObject enablePanel)
	{
	}

	private void Update()
	{
	}

	private bool NonHostPlayerSlotsEnabled()
	{
		return false;
	}

	public void AddUserToPlayerList(ulong steamId, string playerName, int playerObjectId)
	{
	}

	public void KickUserFromServer(int playerObjId)
	{
	}

	public void CancelKickUserFromServer()
	{
	}

	public void ConfirmKickUserFromServer()
	{
	}

	public void RemoveUserFromPlayerList(int playerObjectId)
	{
	}

	public void OpenUserSteamProfile(int slotId)
	{
	}
}
