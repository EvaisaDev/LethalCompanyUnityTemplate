using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public static class PathGenerator
	{
		public const int MinPointsForSpline = 4;

		public static bool Is2D;

		private const float curveMultiplier = 3f;

		private const float splineMultiplier1 = -3f;

		private const float splineMultiplier2 = 3f;

		private const float splineMultiplier3 = 2f;

		private const float splineDistanceClamp = 1f;

		private const float splineEpsilon = 0.0001f;

		public static float SquareRoot(float x)
		{
			return 0f;
		}

		private static float Distance2D(ref Vector3 point1, ref Vector3 point2)
		{
			return 0f;
		}

		private static float Distance3D(ref Vector3 point1, ref Vector3 point2)
		{
			return 0f;
		}

		private static void GetCurvePoint2D(ref Vector3 start, ref Vector3 end, ref Vector3 ctr1, ref Vector3 ctr2, float t, out Vector3 point)
		{
			point = default(Vector3);
		}

		private static void GetCurvePoint3D(ref Vector3 start, ref Vector3 end, ref Vector3 ctr1, ref Vector3 ctr2, float t, out Vector3 point)
		{
			point = default(Vector3);
		}

		private static void CalculateNonuniformCatmullRom(float p1, float p2, float p3, float p4, float distance1, float distance2, float distance3, out Vector4 point)
		{
			point = default(Vector4);
		}

		private static float CalculatePolynomial(ref Vector4 point, float t)
		{
			return 0f;
		}

		private static void ClampSplineDistances(ref float distance1, ref float distance2, ref float distance3)
		{
		}

		private static void GetSplinePoint2D(ref Vector3 point1, ref Vector3 point2, ref Vector3 point3, ref Vector3 point4, float t, out Vector3 point)
		{
			point = default(Vector3);
		}

		private static void GetSplinePoint3D(ref Vector3 point1, ref Vector3 point2, ref Vector3 point3, ref Vector3 point4, float t, out Vector3 point)
		{
			point = default(Vector3);
		}

		public static float CreateCurve(ICollection<Vector3> path, Vector3 start, Vector3 end, Vector3 ctr1, Vector3 ctr2, int numberOfSegments, float startT)
		{
			return 0f;
		}

		public static bool CreateSpline(ICollection<Vector3> path, IList<Vector3> points, int numberOfSegments, bool closePath)
		{
			return false;
		}

		public static bool CreateSplineWithSegmentDistance(ICollection<Vector3> path, IList<Vector3> points, float distancePerSegment, bool closePath)
		{
			return false;
		}
	}
}
