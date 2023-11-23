using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AISearchRoutine
{
	public List<GameObject> unsearchedNodes;

	public GameObject currentTargetNode;

	public GameObject nextTargetNode;

	public bool waitingForTargetNode;

	public bool choseTargetNode;

	public Vector3 currentSearchStartPosition;

	public bool loopSearch;

	public int timesFinishingSearch;

	public int nodesEliminatedInCurrentSearch;

	public bool inProgress;

	public bool calculatingNodeInSearch;

	[Space(5f)]
	public float searchWidth;

	public float searchPrecision;

	public bool randomized;

	public float GetCurrentDistanceOfSearch()
	{
		return 0f;
	}
}
