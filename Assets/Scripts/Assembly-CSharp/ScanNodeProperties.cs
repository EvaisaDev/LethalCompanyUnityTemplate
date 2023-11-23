using UnityEngine;

public class ScanNodeProperties : MonoBehaviour
{
	public int maxRange;

	public int minRange;

	public bool requiresLineOfSight;

	[Space(5f)]
	public string headerText;

	public string subText;

	public int scrapValue;

	[Space(5f)]
	public int creatureScanID;

	[Space(3f)]
	public int nodeType;
}
