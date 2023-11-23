using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBolt
	{
		public class LineRendererMesh
		{
			private const int defaultListCapacity = 2048;

			private static readonly Vector2 uv1;

			private static readonly Vector2 uv2;

			private static readonly Vector2 uv3;

			private static readonly Vector2 uv4;

			private readonly List<int> indices;

			private readonly List<Vector3> vertices;

			private readonly List<Vector4> lineDirs;

			private readonly List<Color32> colors;

			private readonly List<Vector3> ends;

			private readonly List<Vector4> texCoordsAndGlowModifiers;

			private readonly List<Vector4> fadeLifetimes;

			private const int boundsPadder = 1000000000;

			private int currentBoundsMinX;

			private int currentBoundsMinY;

			private int currentBoundsMinZ;

			private int currentBoundsMaxX;

			private int currentBoundsMaxY;

			private int currentBoundsMaxZ;

			private Mesh mesh;

			private MeshFilter meshFilterGlow;

			private MeshFilter meshFilterBolt;

			private MeshRenderer meshRendererGlow;

			private MeshRenderer meshRendererBolt;

			public GameObject GameObject
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public Material MaterialGlow
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public Material MaterialBolt
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public MeshRenderer MeshRendererGlow => null;

			public MeshRenderer MeshRendererBolt => null;

			public int Tag
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public Action<LightningCustomTransformStateInfo> CustomTransform
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

			public Transform Transform
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public bool Empty => false;

			public LineRendererMesh(LightningBoltDependencies dependencies)
			{
			}

			public void PopulateMesh()
			{
			}

			public bool PrepareForLines(int lineCount)
			{
				return false;
			}

			public void BeginLine(Vector3 start, Vector3 end, float radius, Color32 color, float colorIntensity, Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity)
			{
			}

			public void AppendLine(Vector3 start, Vector3 end, float radius, Color32 color, float colorIntensity, Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity)
			{
			}

			public void Reset()
			{
			}

			private void PopulateMeshInternal()
			{
			}

			private void UpdateBounds(ref Vector3 point1, ref Vector3 point2)
			{
			}

			private void AddIndices()
			{
			}

			private void AppendLineInternal(ref Vector3 start, ref Vector3 end, ref Vector4 dir, ref Vector4 dirPrev1, ref Vector4 dirPrev2, Color32 color, float colorIntensity, ref Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CEnableLastRendererCoRoutine_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LightningBolt _003C_003E4__this;

			private LineRendererMesh _003ClineRenderer_003E5__2;

			private int _003Ctag_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CEnableLastRendererCoRoutine_003Ed__39(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CGenerateParticleCoRoutine_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public ParticleSystem p;

			public Vector3 pos;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGenerateParticleCoRoutine_003Ed__54(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CNotifyBolt_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LightningBoltParameters p;

			public LightningBoltDependencies dependencies;

			public Vector3 start;

			public Vector3 end;

			public Transform transform;

			private float _003ClifeTime_003E5__2;

			private LightningCustomTransformStateInfo _003Cstate_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CNotifyBolt_003Ed__42(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public static int MaximumLightCount;

		public static int MaximumLightsPerBatch;

		private DateTime startTimeOffset;

		private LightningBoltDependencies dependencies;

		private float elapsedTime;

		private float lifeTime;

		private float maxLifeTime;

		private bool hasLight;

		private float timeSinceLevelLoad;

		private readonly List<LightningBoltSegmentGroup> segmentGroups;

		private readonly List<LightningBoltSegmentGroup> segmentGroupsWithLight;

		private readonly List<LineRendererMesh> activeLineRenderers;

		private static int lightCount;

		private static readonly List<LineRendererMesh> lineRendererCache;

		private static readonly List<LightningBoltSegmentGroup> groupCache;

		private static readonly List<Light> lightCache;

		public float MinimumDelay
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool HasGlow
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsActive => false;

		public CameraMode CameraMode
		{
			[CompilerGenerated]
			get
			{
				return default(CameraMode);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void SetupLightningBolt(LightningBoltDependencies dependencies)
		{
		}

		public bool Update()
		{
			return false;
		}

		public void Cleanup()
		{
		}

		public LightningBoltSegmentGroup AddGroup()
		{
			return null;
		}

		public static void ClearCache()
		{
		}

		private void CleanupLight(Light l)
		{
		}

		private void EnableLineRenderer(LineRendererMesh lineRenderer, int tag)
		{
		}

		[IteratorStateMachine(typeof(_003CEnableLastRendererCoRoutine_003Ed__39))]
		private IEnumerator EnableLastRendererCoRoutine()
		{
			return null;
		}

		private LineRendererMesh GetOrCreateLineRenderer()
		{
			return null;
		}

		private void RenderGroup(LightningBoltSegmentGroup group, LightningBoltParameters p)
		{
		}

		[IteratorStateMachine(typeof(_003CNotifyBolt_003Ed__42))]
		private static IEnumerator NotifyBolt(LightningBoltDependencies dependencies, LightningBoltParameters p, Transform transform, Vector3 start, Vector3 end)
		{
			return null;
		}

		private void ProcessParameters(LightningBoltParameters p, RangeOfFloats delay, LightningBoltDependencies depends)
		{
		}

		private void ProcessAllLightningParameters()
		{
		}

		private void EnableCurrentLineRendererFromThread(bool inDestroy)
		{
		}

		private void EnableCurrentLineRenderer()
		{
		}

		private void RenderParticleSystems(Vector3 start, Vector3 end, float trunkWidth, float lifeTime, float delaySeconds)
		{
		}

		private Transform RenderLightningBolt(LightningBoltQualitySetting quality, int generations, int startGroupIndex, int endGroupIndex, LightningBoltParameters parameters)
		{
			return null;
		}

		private void CreateLightsForGroup(LightningBoltSegmentGroup group, LightningLightParameters lp, LightningBoltQualitySetting quality, int maxLights)
		{
		}

		private bool AddLightToGroup(LightningBoltSegmentGroup group, LightningLightParameters lp, int segmentIndex, int nthLight, int nthShadows, ref int maxLights, ref int nthShadowCounter)
		{
			return false;
		}

		private Light GetOrCreateLight(LightningLightParameters lp)
		{
			return null;
		}

		private void UpdateLight(LightningLightParameters lp, IEnumerable<Light> lights, float delay, float peakStart, float peakEnd, float lifeTime)
		{
		}

		private void UpdateLights()
		{
		}

		[IteratorStateMachine(typeof(_003CGenerateParticleCoRoutine_003Ed__54))]
		private IEnumerator GenerateParticleCoRoutine(ParticleSystem p, Vector3 pos, float delay)
		{
			return null;
		}

		private void CheckForGlow(IEnumerable<LightningBoltParameters> parameters)
		{
		}
	}
}
