using System;
using UnityEngine;

[Serializable]
public class WeatherEffect
{
	public string name;

	public GameObject effectObject;

	public GameObject effectPermanentObject;

	public bool lerpPosition;

	public bool effectEnabled;

	public string sunAnimatorBool;

	[HideInInspector]
	public bool transitioning;
}
