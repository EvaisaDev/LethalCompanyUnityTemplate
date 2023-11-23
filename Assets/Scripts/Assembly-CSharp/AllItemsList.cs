using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/ItemsList", order = 2)]
public class AllItemsList : ScriptableObject
{
	public List<Item> itemsList;
}
