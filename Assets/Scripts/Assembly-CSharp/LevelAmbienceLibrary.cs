using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/LevelAmbience", order = 2)]
public class LevelAmbienceLibrary : ScriptableObject
{
	public AudioClip[] insanityMusicAudios;

	public AudioClip[] insideAmbience;

	public RandomAudioClip[] insideAmbienceInsanity;

	[Space(15f)]
	public AudioClip[] shipAmbience;

	public RandomAudioClip[] shipAmbienceInsanity;

	[Space(15f)]
	public AudioClip[] outsideAmbience;

	public RandomAudioClip[] outsideAmbienceInsanity;
}
