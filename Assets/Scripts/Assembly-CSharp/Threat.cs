using System;
using UnityEngine;

[Serializable]
public class Threat
{
	public IVisibleThreat threatScript;

	public Vector3 lastSeenPosition;

	public int threatLevel;

	public ThreatType type;

	public int focusLevel;

	public float timeLastSeen;

	public float distanceToThreat;

	public float distanceMovedTowardsBaboon;

	public int interestLevel;

	public bool hasAttacked;
}
