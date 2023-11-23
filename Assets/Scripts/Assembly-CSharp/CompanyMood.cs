using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CompanyMoodPreset", order = 2)]
public class CompanyMood : ScriptableObject
{
	public float timeToWaitBeforeGrabbingItem;

	public float irritability;

	public float judgementSpeed;

	public float startingPatience;

	public bool desiresSilence;

	public bool mustBeWokenUp;

	public int maximumItemsToAnger;

	public float sensitivity;

	[Space(3f)]
	public AudioClip noiseBehindWallSFX;

	[Space(5f)]
	public AudioClip[] grabItemsSFX;

	public AudioClip[] angerSFX;

	public AudioClip[] attackSFX;

	public AudioClip wallAttackSFX;

	public AudioClip insideWindowSFX;

	public AudioClip behindWallSFX;

	public bool stopWallSFXWhenOpening;

	[Space(5f)]
	public CompanyMonster manifestation;

	public int maxPlayersToKillBeforeSatisfied;

	public int[] enableMonsterAnimationIndex;

	public float grabPlayerAnimationTime;
}
