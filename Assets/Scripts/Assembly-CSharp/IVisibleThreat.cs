using UnityEngine;

public interface IVisibleThreat
{
	ThreatType type { get; }

	int GetThreatLevel(Vector3 seenByPosition);

	int GetInterestLevel();

	Transform GetThreatLookTransform();

	Transform GetThreatTransform();

	Vector3 GetThreatVelocity();

	float GetVisibility();
}
