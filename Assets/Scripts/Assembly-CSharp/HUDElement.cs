using System;
using UnityEngine;

[Serializable]
public class HUDElement
{
	public CanvasGroup canvasGroup;

	public float targetAlpha;

	public Coroutine fadeCoroutine;
}
