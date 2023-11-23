using System.Collections.Generic;
using UnityEngine;

public class FoliageDetailDistance : MonoBehaviour
{
	public List<MeshRenderer> allBushRenderers;

	private float updateInterval;

	private int bushIndex;

	private Coroutine updateBushesLODCoroutine;

	public Material highDetailMaterial;

	public Material lowDetailMaterial;

	public Transform localPlayerTransform;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
