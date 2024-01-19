using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class SettingsOption : MonoBehaviour
{
	public SettingsOptionType optionType;

	public TextMeshProUGUI textElement;

	public Image toggleImage;

	public Sprite enabledImage;

	public Sprite disabledImage;

	private bool askedForConfirmation;

	[Header("Key rebinding")]
	public InputActionReference rebindableAction;

	public int rebindableActionBindingIndex;

	public bool gamepadOnlyRebinding;

	public bool requireButtonType;

	public GameObject waitingForInput;

	public TextMeshProUGUI currentlyUsedKeyText;

	public void CancelRebinds()
	{
	}

	public void SetBindingToCurrentSetting()
	{
	}

	public void ResetBindingsToDefaultButton()
	{
	}

	public void SetValueToMatchSettings()
	{
	}

	public void SetMasterVolume()
	{
	}

	public void StartRebindKey()
	{
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public void SetSettingsOptionInt(int value)
	{
	}

	public void SetSettingsOptionFloat(float value)
	{
	}

	public void ToggleEnabledImage(int optionType)
	{
	}

	public void ConfirmSettings()
	{
	}

	public void ResetSettingsToDefault()
	{
	}

	public void CancelSettings()
	{
	}
}
