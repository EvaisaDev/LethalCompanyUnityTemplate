using System;
using UnityEngine;

[Serializable]
public class MonsterAnimation
{
	public Animator monsterAnimator;

	public Transform monsterAnimatorGrabTarget;

	public Transform monsterAnimatorGrabPoint;

	public bool animatorCollidedOnClient;
}
