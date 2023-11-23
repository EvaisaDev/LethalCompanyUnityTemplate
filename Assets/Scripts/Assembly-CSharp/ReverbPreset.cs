using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/ReverbPreset", order = 1)]
public class ReverbPreset : ScriptableObject
{
	public bool changeDryLevel;

	[Range(-10000f, 0f)]
	public float dryLevel;

	public bool changeHighFreq;

	[Range(-10000f, 0f)]
	public float highFreq;

	public bool changeLowFreq;

	[Range(-10000f, 0f)]
	public float lowFreq;

	public bool changeDecayTime;

	[Range(0f, 35f)]
	public float decayTime;

	public bool changeRoom;

	[Range(-10000f, 0f)]
	public float room;
}
