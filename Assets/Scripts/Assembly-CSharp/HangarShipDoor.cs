using TMPro;
using UnityEngine;

public class HangarShipDoor : MonoBehaviour
{
	public InteractTrigger triggerScript;

	public TextMeshProUGUI doorPowerDisplay;

	private StartOfRound playersManager;

	public Animator shipDoorsAnimator;

	public bool buttonsEnabled;

	public float doorPower;

	public float doorPowerDuration;

	public bool overheated;

	public bool doorsOpenedInGameOverAnimation;

	public GameObject hydraulicsDisplay;

	private bool hydraulicsScreenDisplayed;

	public void Update()
	{
	}

	private void SetScreenDisplay()
	{
	}

	public void PlayDoorAnimation(bool closed)
	{
	}

	public void SetDoorClosed()
	{
	}

	public void SetDoorOpen()
	{
	}

	public void SetDoorButtonsEnabled(bool doorButtonsEnabled)
	{
	}

	private void Start()
	{
	}
}
