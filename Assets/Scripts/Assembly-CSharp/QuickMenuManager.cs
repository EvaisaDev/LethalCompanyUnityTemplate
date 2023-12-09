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

	public GameObject KeybindsPanel;

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

	[Header("Debug menu")]
	public GameObject[] doorGameObjects;

	public Collider outOfBoundsCollider;

	public GameObject debugMenuUI;

	public SelectableLevel testAllEnemiesLevel;

	[Space(3f)]
	private int enemyToSpawnId;

	[Space(3f)]
	private int enemyTypeId;

	[Space(3f)]
	private int itemToSpawnId;

	[Space(3f)]
	private int numberEnemyToSpawn;

	public Transform[] debugEnemySpawnPositions;

	public TMP_Dropdown debugEnemyDropdown;

	public TMP_Dropdown allItemsDropdown;

	private void Start()
	{
	}

	public void Debug_SetAllItemsDropdownOptions()
	{
	}

	public void Debug_SpawnItem()
	{
	}

	public void Debug_SetItemToSpawn(int itemId)
	{
	}

	public void Debug_ToggleTestRoom()
	{
	}

	public void Debug_ToggleAllowDeath()
	{
	}

	public void Debug_SetEnemyType(int enemyType)
	{
	}

	private void Debug_SetEnemyDropdownOptions()
	{
	}

	public void Debug_SetEnemyToSpawn(int enemyId)
	{
	}

	public void Debug_SetNumberToSpawn(string numString)
	{
	}

	public void Debug_SpawnEnemy()
	{
	}

	private bool CanEnableDebugMenu()
	{
		return false;
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
