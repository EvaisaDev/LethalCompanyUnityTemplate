using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/TerminalKeyword", order = 3)]
public class TerminalKeyword : ScriptableObject
{
	public string word;

	public bool isVerb;

	public CompatibleNoun[] compatibleNouns;

	public TerminalNode specialKeywordResult;

	[Space(5f)]
	public TerminalKeyword defaultVerb;

	[Space(3f)]
	public bool accessTerminalObjects;
}
