using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Unlockables", order = 2)]
public class UnlockablesList : ScriptableObject
{
	public List<UnlockableItem> unlockables;
}
