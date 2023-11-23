using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class MeshHelper
	{
		private Mesh mesh;

		private int[] triangles;

		private Vector3[] vertices;

		private Vector3[] normals;

		private float[] normalizedAreaWeights;

		public Mesh Mesh => null;

		public int[] Triangles => null;

		public Vector3[] Vertices => null;

		public Vector3[] Normals => null;

		public MeshHelper(Mesh mesh)
		{
		}

		public void GenerateRandomPoint(ref RaycastHit hit, out int triangleIndex)
		{
			triangleIndex = default(int);
		}

		public void GetRaycastFromTriangleIndex(int triangleIndex, ref RaycastHit hit)
		{
		}

		private float[] CalculateSurfaceAreas(out float totalSurfaceArea)
		{
			totalSurfaceArea = default(float);
			return null;
		}

		private void CalculateNormalizedAreaWeights()
		{
		}

		private int SelectRandomTriangle()
		{
			return 0;
		}

		private Vector3 GenerateRandomBarycentricCoordinates()
		{
			return default(Vector3);
		}
	}
}
