using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningMeshSurfaceScript : LightningBoltPrefabScriptBase
	{
		[Header("Lightning Mesh Properties")]
		[Tooltip("The mesh filter. You must assign a mesh filter in order to create lightning on the mesh.")]
		public MeshFilter MeshFilter;

		[Tooltip("The mesh collider. This is used to get random points on the mesh.")]
		public Collider MeshCollider;

		[SingleLine("Random range that the point will offset from the mesh, using the normal of the chosen point to offset")]
		public RangeOfFloats MeshOffsetRange;

		[Header("Lightning Path Properties")]
		[SingleLine("Range for points in the lightning path")]
		public RangeOfIntegers PathLengthCount;

		[SingleLine("Range for minimum distance between points in the lightning path")]
		public RangeOfFloats MinimumPathDistanceRange;

		[Tooltip("The maximum distance between mesh points. When walking the mesh, if a point is greater than this, the path direction is reversed. This tries to avoid paths crossing between mesh points that are not actually physically touching.")]
		public float MaximumPathDistance;

		private float maximumPathDistanceSquared;

		[Tooltip("Whether to use spline interpolation between the path points. Paths must be at least 4 points long to be splined.")]
		public bool Spline;

		[Tooltip("For spline. the distance hint for each spline segment. Set to <= 0 to use the generations to determine how many spline segments to use. If > 0, it will be divided by Generations before being applied. This value is a guideline and is approximate, and not uniform on the spline.")]
		public float DistancePerSegmentHint;

		private readonly List<Vector3> sourcePoints;

		private Mesh previousMesh;

		private MeshHelper meshHelper;

		private void CheckMesh()
		{
		}

		protected override LightningBoltParameters OnCreateParameters()
		{
			return null;
		}

		protected virtual void PopulateSourcePoints(List<Vector3> points)
		{
		}

		public void CreateRandomLightningPath(List<Vector3> points)
		{
		}

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}
	}
}
