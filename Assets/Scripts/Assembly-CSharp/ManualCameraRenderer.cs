using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class ManualCameraRenderer : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CupdateMapTarget_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ManualCameraRenderer _003C_003E4__this;

		public int setRadarTargetIndex;

		public bool calledFromRPC;

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
		public _003CupdateMapTarget_003Ed__45(int _003C_003E1__state)
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

	public Camera cam;

	public CameraView[] cameraViews;

	public int cameraViewIndex;

	public bool currentCameraDisabled;

	[Space(5f)]
	public MeshRenderer mesh;

	public Material offScreenMat;

	public Material onScreenMat;

	public int materialIndex;

	private bool isScreenOn;

	public bool overrideCameraForOtherUse;

	public bool renderAtLowerFramerate;

	public float fps;

	private float elapsed;

	public PlayerControllerB targetedPlayer;

	public List<TransformAndName> radarTargets;

	public int targetTransformIndex;

	public Camera mapCamera;

	public Light mapCameraLight;

	public Animator mapCameraAnimator;

	private bool mapCameraMaxFramerate;

	private Coroutine updateMapCameraCoroutine;

	private bool syncingTargetPlayer;

	private bool syncingSwitchScreen;

	private bool screenEnabledOnLocalClient;

	private Vector3 targetDeathPosition;

	public Transform mapCameraStationaryUI;

	public Transform shipArrowPointer;

	public GameObject shipArrowUI;

	private void Start()
	{
	}

	private void Awake()
	{
	}

	public void SwitchScreenButton()
	{
	}

	public void SwitchScreenOn(bool on = true)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SwitchScreenOnServerRpc(bool on)
	{
	}

	[ClientRpc]
	public void SwitchScreenOnClientRpc(bool on)
	{
	}

	public void SwitchCameraView(bool switchForward = true, int switchToView = -1)
	{
	}

	public string AddTransformAsTargetToRadar(Transform newTargetTransform, string targetName, bool isNonPlayer = false)
	{
		return null;
	}

	public void ChangeNameOfTargetTransform(Transform t, string newName)
	{
	}

	public void SyncOrderOfRadarBoostersInList()
	{
	}

	public void FlashRadarBooster(int targetId)
	{
	}

	public void PingRadarBooster(int targetId)
	{
	}

	public void RemoveTargetFromRadar(Transform removeTransform)
	{
	}

	public void SwitchRadarTargetForward(bool callRPC)
	{
	}

	public void SwitchRadarTargetAndSync(int switchToIndex)
	{
	}

	private int GetRadarTargetIndexPlusOne(int index)
	{
		return 0;
	}

	private int GetRadarTargetIndexMinusOne(int index)
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CupdateMapTarget_003Ed__45))]
	private IEnumerator updateMapTarget(int setRadarTargetIndex, bool calledFromRPC = true)
	{
		return null;
	}

	[ServerRpc(RequireOwnership = false)]
	public void SwitchRadarTargetServerRpc(int targetIndex)
	{
	}

	[ClientRpc]
	public void SwitchRadarTargetClientRpc(int switchToIndex)
	{
	}

	private void MapCameraFocusOnPosition(Vector3 pos)
	{
	}

	private void Update()
	{
	}

	private bool MeetsCameraEnabledConditions(PlayerControllerB player)
	{
		return false;
	}
}
