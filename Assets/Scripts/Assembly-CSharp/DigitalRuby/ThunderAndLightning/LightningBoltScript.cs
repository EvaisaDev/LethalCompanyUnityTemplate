using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBoltScript : MonoBehaviour
	{
		[Header("Lightning General Properties")]
		[Tooltip("The camera the lightning should be shown in. Defaults to the current camera, or the main camera if current camera is null. If you are using a different camera, you may want to put the lightning in it's own layer and cull that layer out of any other cameras.")]
		public Camera Camera;

		[Tooltip("Type of camera mode. Auto detects the camera and creates appropriate lightning. Can be overriden to do something more specific regardless of camera.")]
		public CameraMode CameraMode;

		internal CameraMode calculatedCameraMode;

		[Tooltip("True if you are using world space coordinates for the lightning bolt, false if you are using coordinates relative to the parent game object.")]
		public bool UseWorldSpace;

		[Tooltip("Whether to compensate for the parent transform. Default is false. If true, rotation, scale and position are altered by the parent transform. Use this to fix scaling, rotation and other offset problems with the lightning.")]
		public bool CompensateForParentTransform;

		[Tooltip("Lightning quality setting. This allows setting limits on generations, lights and shadow casting lights based on the global quality setting.")]
		public LightningBoltQualitySetting QualitySetting;

		[Tooltip("Whether to use multi-threaded generation of lightning. Lightning will be delayed by about 1 frame if this is turned on, but this can significantly improve performance.")]
		public bool MultiThreaded;

		[Range(0f, 1000f)]
		[Tooltip("If non-zero, the Camera property is used to get distance of lightning from camera. Lightning generations is reduced for each distance from camera. For example, if LevelOfDetailDistance was 100 and the lightning was 200 away from camera, generations would be reduced by 2, to a minimum of 1.")]
		public float LevelOfDetailDistance;

		[Tooltip("True to use game time, false to use real time")]
		public bool UseGameTime;

		[Header("Lightning 2D Settings")]
		[Tooltip("Sort layer name")]
		public string SortLayerName;

		[Tooltip("Order in sort layer")]
		public int SortOrderInLayer;

		[Header("Lightning Rendering Properties")]
		[Tooltip("Soft particles factor. 0.01 to 3.0 are typical, 100.0 to disable.")]
		[Range(0.01f, 100f)]
		public float SoftParticlesFactor;

		[Tooltip("The render queue for the lightning. -1 for default.")]
		public int RenderQueue;

		[Tooltip("Lightning material for mesh renderer - glow")]
		public Material LightningMaterialMesh;

		[Tooltip("Lightning material for mesh renderer - bolt")]
		public Material LightningMaterialMeshNoGlow;

		[Tooltip("The texture to use for the lightning bolts, or null for the material default texture.")]
		public Texture2D LightningTexture;

		[Tooltip("The texture to use for the lightning glow, or null for the material default texture.")]
		public Texture2D LightningGlowTexture;

		[Tooltip("Particle system to play at the point of emission (start). 'Emission rate' particles will be emitted all at once.")]
		public ParticleSystem LightningOriginParticleSystem;

		[Tooltip("Particle system to play at the point of impact (end). 'Emission rate' particles will be emitted all at once.")]
		public ParticleSystem LightningDestinationParticleSystem;

		[Tooltip("Tint color for the lightning")]
		public Color LightningTintColor;

		[Tooltip("Tint color for the lightning glow")]
		public Color GlowTintColor;

		[Tooltip("Allow tintint the main trunk differently than forks.")]
		public Color MainTrunkTintColor;

		[Tooltip("Source blend mode. Default is SrcAlpha.")]
		public BlendMode SourceBlendMode;

		[Tooltip("Destination blend mode. Default is One. For additive blend use One. For alpha blend use OneMinusSrcAlpha.")]
		public BlendMode DestinationBlendMode;

		[Tooltip("Source blend mode. Default is SrcAlpha.")]
		public BlendMode SourceBlendModeGlow;

		[Tooltip("Destination blend mode. Default is One. For additive blend use One. For alpha blend use OneMinusSrcAlpha.")]
		public BlendMode DestinationBlendModeGlow;

		[Header("Lightning Movement Properties")]
		[Tooltip("Jitter multiplier to randomize lightning size. Jitter depends on trunk width and will make the lightning move rapidly and jaggedly, giving a more lively and sometimes cartoony feel. Jitter may be shared with other bolts depending on materials. If you need different jitters for the same material, create a second script object.")]
		public float JitterMultiplier;

		[Tooltip("Built in turbulance based on the direction of each segment. Small values usually work better, like 0.2.")]
		public float Turbulence;

		[Tooltip("Global turbulence velocity for this script")]
		public Vector3 TurbulenceVelocity;

		[Tooltip("Flicker intensity, causes lightning to pop in and out rapidly. X = intensity, Y = speed.")]
		public Vector2 IntensityFlicker;

		public static float TimeScale;

		private static bool needsTimeUpdate;

		private Texture2D lastLightningTexture;

		private Texture2D lastLightningGlowTexture;

		private readonly List<LightningBolt> activeBolts;

		private readonly LightningBoltParameters[] oneParameterArray;

		private readonly List<LightningBolt> lightningBoltCache;

		private readonly List<LightningBoltDependencies> dependenciesCache;

		private LightningThreadState threadState;

		private static int shaderId_MainTex;

		private static int shaderId_TintColor;

		private static int shaderId_JitterMultiplier;

		private static int shaderId_Turbulence;

		private static int shaderId_TurbulenceVelocity;

		private static int shaderId_SrcBlendMode;

		private static int shaderId_DstBlendMode;

		private static int shaderId_InvFade;

		private static int shaderId_LightningTime;

		private static int shaderId_IntensityFlicker;

		private static int shaderId_RenderMode;

		public Action<LightningBoltParameters, Vector3, Vector3> LightningStartedCallback
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

		public Action<LightningBoltParameters, Vector3, Vector3> LightningEndedCallback
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

		public Action<Light> LightAddedCallback
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

		public Action<Light> LightRemovedCallback
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

		public bool HasActiveBolts => false;

		public static Vector4 TimeVectorSinceStart
		{
			[CompilerGenerated]
			get
			{
				return default(Vector4);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float TimeSinceStart
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

		public static float DeltaTime
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

		internal Material lightningMaterialMeshInternal
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

		internal Material lightningMaterialMeshNoGlowInternal
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

		public virtual void CreateLightningBolt(LightningBoltParameters p)
		{
		}

		public void CreateLightningBolts(ICollection<LightningBoltParameters> parameters)
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual LightningBoltParameters OnCreateParameters()
		{
			return null;
		}

		protected LightningBoltParameters CreateParameters()
		{
			return null;
		}

		protected virtual void PopulateParameters(LightningBoltParameters parameters)
		{
		}

		private Coroutine StartCoroutineWrapper(IEnumerator routine)
		{
			return null;
		}

		private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		private LightningBoltDependencies CreateLightningBoltDependencies(ICollection<LightningBoltParameters> parameters)
		{
			return null;
		}

		private void ReturnLightningDependenciesToCache(LightningBoltDependencies d)
		{
		}

		internal void OnLightAdded(Light l)
		{
		}

		internal void OnLightRemoved(Light l)
		{
		}

		internal void AddActiveBolt(LightningBolt bolt)
		{
		}

		private void UpdateShaderIds()
		{
		}

		private void UpdateMaterialsForLastTexture()
		{
		}

		private void UpdateTexture()
		{
		}

		private void SetMaterialPerspective()
		{
		}

		private void SetMaterialOrthographicXY()
		{
		}

		private void SetMaterialOrthographicXZ()
		{
		}

		private void SetupMaterialCamera()
		{
		}

		private void UpdateShaderParameters()
		{
		}

		private void CheckCompensateForParentTransform()
		{
		}

		private void UpdateCamera()
		{
		}

		private LightningBolt GetOrCreateLightningBolt()
		{
			return null;
		}

		private void UpdateActiveBolts()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void Cleanup()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}
	}
}
