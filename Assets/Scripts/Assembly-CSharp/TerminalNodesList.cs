using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/TerminalNodesList", order = 2)]
public class TerminalNodesList : ScriptableObject
{
	public List<TerminalNode> specialNodes;

	public List<TerminalNode> terminalNodes;

	public TerminalKeyword[] allKeywords;
}
