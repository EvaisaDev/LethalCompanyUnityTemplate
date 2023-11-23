using System;
using UnityEngine;

[Serializable]
public class RandomAudioClip
{
	public AudioClip audioClip;

	[Range(0f, 100f)]
	public int chance;
}
