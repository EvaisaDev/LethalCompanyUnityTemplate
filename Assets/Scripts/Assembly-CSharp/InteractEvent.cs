using System;
using GameNetcodeStuff;
using UnityEngine.Events;

[Serializable]
public class InteractEvent : UnityEvent<PlayerControllerB>
{
	public InteractEvent()
	{
	}
}
