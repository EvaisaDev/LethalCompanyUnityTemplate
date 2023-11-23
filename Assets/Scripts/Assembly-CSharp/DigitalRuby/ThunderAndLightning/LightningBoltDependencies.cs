using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBoltDependencies
	{
		public GameObject Parent;

		public Material LightningMaterialMesh;

		public Material LightningMaterialMeshNoGlow;

		public ParticleSystem OriginParticleSystem;

		public ParticleSystem DestParticleSystem;

		public Vector3 CameraPos;

		public bool CameraIsOrthographic;

		public CameraMode CameraMode;

		public bool UseWorldSpace;

		public float LevelOfDetailDistance;

		public string SortLayerName;

		public int SortOrderInLayer;

		public ICollection<LightningBoltParameters> Parameters;

		public LightningThreadState ThreadState;

		public Func<IEnumerator, Coroutine> StartCoroutine;

		public Action<Light> LightAdded;

		public Action<Light> LightRemoved;

		public Action<LightningBolt> AddActiveBolt;

		public Action<LightningBoltDependencies> ReturnToCache;

		public Action<LightningBoltParameters, Vector3, Vector3> LightningBoltStarted;

		public Action<LightningBoltParameters, Vector3, Vector3> LightningBoltEnded;
	}
}
