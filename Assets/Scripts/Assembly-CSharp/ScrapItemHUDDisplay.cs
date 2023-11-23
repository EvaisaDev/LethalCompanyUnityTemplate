using System;
using TMPro;
using UnityEngine;

[Serializable]
public class ScrapItemHUDDisplay
{
	public Animator itemDisplayAnimator;

	public Transform itemObjectContainer;

	public RectTransform UIContainer;

	public TextMeshProUGUI headerText;

	public TextMeshProUGUI valueText;
}
