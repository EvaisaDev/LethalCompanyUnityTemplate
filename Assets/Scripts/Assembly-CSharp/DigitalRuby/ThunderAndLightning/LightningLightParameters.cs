using System;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	[Serializable]
	public class LightningLightParameters
	{
		[Tooltip("Light render mode - leave as auto unless you have special use cases")]
		[HideInInspector]
		public LightRenderMode RenderMode;

		[Tooltip("Color of the light")]
		public Color LightColor;

		[Tooltip("What percent of segments should have a light? For performance you may want to keep this small.")]
		[Range(0f, 1f)]
		public float LightPercent;

		[Tooltip("What percent of lights created should cast shadows?")]
		[Range(0f, 1f)]
		public float LightShadowPercent;

		[Tooltip("Light intensity")]
		[Range(0f, 8f)]
		public float LightIntensity;

		[Tooltip("Light multiplier. Can set to a high number (millions) if HDRP (lumens) support is needed.")]
		[Range(0f, 10000000f)]
		public float LightMultiplier;

		[Tooltip("Bounce intensity")]
		[Range(0f, 8f)]
		public float BounceIntensity;

		[Tooltip("Shadow strength, 0 means all light, 1 means all shadow")]
		[Range(0f, 1f)]
		public float ShadowStrength;

		[Tooltip("Shadow bias, 0 - 2")]
		[Range(0f, 2f)]
		public float ShadowBias;

		[Tooltip("Shadow normal bias, 0 - 3")]
		[Range(0f, 3f)]
		public float ShadowNormalBias;

		[Tooltip("The range of each light created")]
		public float LightRange;

		[Tooltip("Only light objects that match this layer mask")]
		public LayerMask CullingMask;

		[Tooltip("Offset from camera position when in orthographic mode")]
		[Range(-1000f, 1000f)]
		public float OrthographicOffset;

		[Tooltip("Increase the duration of light fade in compared to the lightning fade.")]
		[Range(0f, 20f)]
		public float FadeInMultiplier;

		[Tooltip("Increase the duration of light fully lit compared to the lightning fade.")]
		[Range(0f, 20f)]
		public float FadeFullyLitMultiplier;

		[Tooltip("Increase the duration of light fade out compared to the lightning fade.")]
		[Range(0f, 20f)]
		public float FadeOutMultiplier;

		public bool HasLight => false;
	}
}
