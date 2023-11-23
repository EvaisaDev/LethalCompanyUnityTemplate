using System;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningGenerator
	{
		internal const float oneOver255 = 0.003921569f;

		internal const float mainTrunkMultiplier = 0.003921569f;

		public static readonly LightningGenerator GeneratorInstance;

		private void GetPerpendicularVector(ref Vector3 directionNormalized, out Vector3 side)
		{
			side = default(Vector3);
		}

		protected virtual void OnGenerateLightningBolt(LightningBolt bolt, Vector3 start, Vector3 end, LightningBoltParameters parameters)
		{
		}

		public bool ShouldCreateFork(LightningBoltParameters parameters, int generation, int totalGenerations)
		{
			return false;
		}

		public void CreateFork(LightningBolt bolt, LightningBoltParameters parameters, int generation, int totalGenerations, Vector3 start, Vector3 midPoint)
		{
		}

		public void GenerateLightningBoltStandard(LightningBolt bolt, Vector3 start, Vector3 end, int generation, int totalGenerations, float offsetAmount, LightningBoltParameters parameters)
		{
		}

		public Vector3 RandomDirection3D(System.Random random)
		{
			return default(Vector3);
		}

		public Vector3 RandomDirection2D(System.Random random)
		{
			return default(Vector3);
		}

		public Vector3 RandomDirection2DXZ(System.Random random)
		{
			return default(Vector3);
		}

		public void RandomVector(LightningBolt bolt, ref Vector3 start, ref Vector3 end, float offsetAmount, System.Random random, out Vector3 result)
		{
			result = default(Vector3);
		}

		public void GenerateLightningBolt(LightningBolt bolt, LightningBoltParameters parameters)
		{
		}

		public void GenerateLightningBolt(LightningBolt bolt, LightningBoltParameters parameters, out Vector3 start, out Vector3 end)
		{
			start = default(Vector3);
			end = default(Vector3);
		}
	}
}
