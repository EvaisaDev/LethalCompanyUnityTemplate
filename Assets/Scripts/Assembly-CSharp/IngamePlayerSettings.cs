using System;
using System.Runtime.CompilerServices;
using Dissonance;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class IngamePlayerSettings : MonoBehaviour
{
	[Serializable]
	public class Settings
	{
		public bool playerHasFinishedSetup;

		public bool startInOnlineMode;

		public float gammaSetting;

		public int lookSensitivity;

		public bool invertYAxis;

		public float masterVolume;

		public int framerateCapIndex;

		public FullScreenMode fullScreenType;

		[Header("MIC SETTINGS")]
		public bool micEnabled;

		public bool pushToTalk;

		public int micDeviceIndex;

		public string micDevice;

		[Header("BINDINGS")]
		public string keyBindings;

		public Settings(bool finishedSetup = true, bool onlineMode = true)
		{
		}

		public void CopySettings(Settings copyFrom)
		{
		}
	}

	public Settings settings;

	public Settings unsavedSettings;

	public AudioSource SettingsAudio;

	public Volume universalVolume;

	private DissonanceComms comms;

	public bool redoLaunchSettings;

	public bool changesNotApplied;

	public InputActionRebindingExtensions.RebindingOperation rebindingOperation;

	private SettingsOption currentRebindingKeyUI;

	public PlayerInput playerInput;

	public bool encounteredErrorDuringSave;

	public static IngamePlayerSettings Instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void Awake()
	{
	}

	private void DisplaySaveFileError(Exception e)
	{
	}

	public void LoadSettingsFromPrefs()
	{
	}

	public void SaveSettingsToPrefs()
	{
	}

	public void UpdateGameToMatchSettings()
	{
	}

	public void SetOption(SettingsOptionType optionType, int value)
	{
	}

	private void SetInvertYAxis()
	{
	}

	private void SetFullscreenMode(int value)
	{
	}

	private void SetFramerateCap(int value)
	{
	}

	public void ChangeGamma(int setTo, float overrideWithFloat = -500f)
	{
	}

	public void ChangeMasterVolume(int setTo)
	{
	}

	public void ChangeLookSens(int setTo)
	{
	}

	public void RefreshAndDisplayCurrentMicrophone(bool saveResult = true)
	{
	}

	public void SetSettingsOptionsText(SettingsOptionType optionType, string setToText)
	{
	}

	public void SwitchMicrophoneSetting()
	{
	}

	public void SetMicrophoneEnabled()
	{
	}

	public void SetMicPushToTalk()
	{
	}

	public void UpdateMicPushToTalkButton()
	{
	}

	public void SetPlayerFinishedLaunchOptions()
	{
	}

	public void SetLaunchInOnlineMode(bool enable)
	{
	}

	public void RebindKey(InputActionReference rebindableAction, SettingsOption optionUI)
	{
	}

	public void CompleteRebind(SettingsOption optionUI)
	{
	}

	public void CancelRebind(SettingsOption optionUI = null)
	{
	}

	public void ResetSettingsToDefault()
	{
	}

	public void SaveChangedSettings()
	{
	}

	public void DisplayConfirmChangesScreen(bool visible)
	{
	}

	public void DiscardChangedSettings()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode loadType)
	{
	}

	private void SetChangesNotAppliedTextVisible(bool visible = true)
	{
	}
}
