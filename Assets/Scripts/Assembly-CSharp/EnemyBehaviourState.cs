using System;
using UnityEngine;

[Serializable]
public class EnemyBehaviourState
{
	public string name;

	[Space(5f)]
	public AudioClip VoiceClip;

	public bool playOneShotVoice;

	public AudioClip SFXClip;

	public bool playOneShotSFX;

	[Space(5f)]
	public bool IsAnimTrigger;

	public string parameterString;

	public bool boolValue;
}
