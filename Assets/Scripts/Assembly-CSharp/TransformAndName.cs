using System;
using UnityEngine;

[Serializable]
public class TransformAndName
{
	public Transform transform;

	public string name;

	public bool isNonPlayer;

	public TransformAndName(Transform newTransform, string newName, bool nonPlayer = false)
	{
	}
}
