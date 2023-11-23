using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public abstract class LightningBoltPrefabScriptBase : LightningBoltScript
	{
		private readonly List<LightningBoltParameters> batchParameters;

		private readonly System.Random random;

		[Header("Lightning Spawn Properties")]
		[SingleLineClamp("How long to wait before creating another round of lightning bolts in seconds", 0.001, double.MaxValue)]
		public RangeOfFloats IntervalRange;

		[SingleLineClamp("How many lightning bolts to emit for each interval", 0.0, 100.0)]
		public RangeOfIntegers CountRange;

		[Tooltip("Reduces the probability that additional bolts from CountRange will actually happen (0 - 1).")]
		[Range(0f, 1f)]
		public float CountProbabilityModifier;

		public RangeOfFloats DelayRange;

		[SingleLineClamp("For each bolt emitted, how long should it stay in seconds", 0.01, 10.0)]
		public RangeOfFloats DurationRange;

		[Header("Lightning Appearance Properties")]
		[SingleLineClamp("The trunk width range in unity units (x = min, y = max)", 0.0001, 100.0)]
		public RangeOfFloats TrunkWidthRange;

		[Tooltip("How long (in seconds) this game object should live before destroying itself. Leave as 0 for infinite.")]
		[Range(0f, 1000f)]
		public float LifeTime;

		[Tooltip("Generations (1 - 8, higher makes more detailed but more expensive lightning)")]
		[Range(1f, 8f)]
		public int Generations;

		[Tooltip("The chaos factor that determines how far the lightning main trunk can spread out, higher numbers spread out more. 0 - 1.")]
		[Range(0f, 1f)]
		public float ChaosFactor;

		[Tooltip("The chaos factor that determines how far the forks of the lightning can spread out, higher numbers spread out more. 0 - 1.")]
		[Range(0f, 1f)]
		public float ChaosFactorForks;

		[Tooltip("Intensity of the lightning")]
		[Range(0f, 10f)]
		public float Intensity;

		[Tooltip("The intensity of the glow")]
		[Range(0f, 10f)]
		public float GlowIntensity;

		[Tooltip("The width multiplier for the glow, 0 - 64")]
		[Range(0f, 64f)]
		public float GlowWidthMultiplier;

		[Tooltip("What percent of time the lightning should fade in and out. For example, 0.15 fades in 15% of the time and fades out 15% of the time, with full visibility 70% of the time.")]
		[Range(0f, 0.5f)]
		public float FadePercent;

		[Tooltip("Modify the duration of lightning fade in.")]
		[Range(0f, 1f)]
		public float FadeInMultiplier;

		[Tooltip("Modify the duration of fully lit lightning.")]
		[Range(0f, 1f)]
		public float FadeFullyLitMultiplier;

		[Tooltip("Modify the duration of lightning fade out.")]
		[Range(0f, 1f)]
		public float FadeOutMultiplier;

		[Tooltip("0 - 1, how slowly the lightning should grow. 0 for instant, 1 for slow.")]
		[Range(0f, 1f)]
		public float GrowthMultiplier;

		[Tooltip("How much smaller the lightning should get as it goes towards the end of the bolt. For example, 0.5 will make the end 50% the width of the start.")]
		[Range(0f, 10f)]
		public float EndWidthMultiplier;

		[Tooltip("How forked should the lightning be? (0 - 1, 0 for none, 1 for lots of forks)")]
		[Range(0f, 1f)]
		public float Forkedness;

		[Range(0f, 10f)]
		[Tooltip("Minimum distance multiplier for forks")]
		public float ForkLengthMultiplier;

		[Range(0f, 10f)]
		[Tooltip("Fork distance multiplier variance. Random range of 0 to n that is added to Fork Length Multiplier.")]
		public float ForkLengthVariance;

		[Tooltip("Forks have their EndWidthMultiplier multiplied by this value")]
		[Range(0f, 10f)]
		public float ForkEndWidthMultiplier;

		[Header("Lightning Light Properties")]
		[Tooltip("Light parameters")]
		public LightningLightParameters LightParameters;

		[Tooltip("Maximum number of lights that can be created per batch of lightning")]
		[Range(0f, 64f)]
		public int MaximumLightsPerBatch;

		[Header("Lightning Trigger Type")]
		[Tooltip("Manual or automatic mode. Manual requires that you call the Trigger method in script. Automatic uses the interval to create lightning continuously.")]
		public bool ManualMode;

		[Tooltip("Turns lightning into automatic mode for this number of seconds, then puts it into manual mode.")]
		[Range(0f, 120f)]
		public float AutomaticModeSeconds;

		[Header("Lightning custom transform handler")]
		[Tooltip("Custom handler to modify the transform of each lightning bolt, useful if it will be alive longer than a few frames and needs to scale and rotate based on the position of other objects.")]
		public LightningCustomTransformDelegate CustomTransformHandler;

		private float nextLightningTimestamp;

		private float lifeTimeRemaining;

		public System.Random RandomOverride
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void CalculateNextLightningTimestamp(float offset)
		{
		}

		private void CustomTransform(LightningCustomTransformStateInfo state)
		{
		}

		private void CallLightning()
		{
		}

		private void CallLightning(Vector3? start, Vector3? end)
		{
		}

		protected void CreateLightningBoltsNow()
		{
		}

		protected override void PopulateParameters(LightningBoltParameters parameters)
		{
		}

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		protected virtual void OnDrawGizmos()
		{
		}

		public override void CreateLightningBolt(LightningBoltParameters p)
		{
		}

		public void Trigger()
		{
		}

		public void Trigger(float seconds)
		{
		}

		public void Trigger(Vector3? start, Vector3? end)
		{
		}
	}
}
