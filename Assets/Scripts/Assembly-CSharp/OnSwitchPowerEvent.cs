using System;
using UnityEngine.Events;

[Serializable]
public class OnSwitchPowerEvent : UnityEvent<bool>
{
	public OnSwitchPowerEvent()
	{
	}
}
