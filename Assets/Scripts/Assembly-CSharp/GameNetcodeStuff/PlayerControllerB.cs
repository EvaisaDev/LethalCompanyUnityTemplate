using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dissonance;
using TMPro;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace GameNetcodeStuff
{
	public class PlayerControllerB : NetworkBehaviour, IHittable, IShockableWithGun, IVisibleThreat
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass298_0
		{
			public QuickMenuManager quickMenu;

			internal bool _003CPlayIntroTip_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CGrabObject_003Ed__350 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayerControllerB _003C_003E4__this;

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
			public _003CGrabObject_003Ed__350(int _003C_003E1__state)
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
		private sealed class _003CPlayIntroTip_003Ed__298 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private _003C_003Ec__DisplayClass298_0 _003C_003E8__1;

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
			public _003CPlayIntroTip_003Ed__298(int _003C_003E1__state)
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
		private sealed class _003CPlayerJump_003Ed__374 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayerControllerB _003C_003E4__this;

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
			public _003CPlayerJump_003Ed__374(int _003C_003E1__state)
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
		private sealed class _003CWaitUntilPlayerHasLeftBodyToTeleport_003Ed__458 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayerControllerB _003C_003E4__this;

			public Vector3 newBodyPosition;

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
			public _003CWaitUntilPlayerHasLeftBodyToTeleport_003Ed__458(int _003C_003E1__state)
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
		private sealed class _003CplayQuickSpecialAnimation_003Ed__314 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayerControllerB _003C_003E4__this;

			public float animTime;

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
			public _003CplayQuickSpecialAnimation_003Ed__314(int _003C_003E1__state)
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
		private sealed class _003CspawnPlayerAnimTimer_003Ed__414 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayerControllerB _003C_003E4__this;

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
			public _003CspawnPlayerAnimTimer_003Ed__414(int _003C_003E1__state)
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
		private sealed class _003CtimeSpecialAnimation_003Ed__403 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float time;

			public PlayerControllerB _003C_003E4__this;

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
			public _003CtimeSpecialAnimation_003Ed__403(int _003C_003E1__state)
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
		private sealed class _003CwaitToEndOfFrameToDiscard_003Ed__355 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayerControllerB _003C_003E4__this;

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
			public _003CwaitToEndOfFrameToDiscard_003Ed__355(int _003C_003E1__state)
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

		public bool isTestingPlayer;

		[Header("MODELS / ANIMATIONS")]
		public Transform[] bodyParts;

		public Transform thisPlayerBody;

		public SkinnedMeshRenderer thisPlayerModel;

		public SkinnedMeshRenderer thisPlayerModelLOD1;

		public SkinnedMeshRenderer thisPlayerModelLOD2;

		public SkinnedMeshRenderer thisPlayerModelArms;

		public Transform playerGlobalHead;

		public Transform playerModelArmsMetarig;

		public Transform localArmsRotationTarget;

		public Transform meshContainer;

		public Transform lowerSpine;

		public Camera gameplayCamera;

		public Transform cameraContainerTransform;

		public Transform playerEye;

		public float targetFOV;

		public Camera visorCamera;

		public CharacterController thisController;

		public Animator playerBodyAnimator;

		public MeshFilter playerBadgeMesh;

		public MeshRenderer playerBetaBadgeMesh;

		public int playerLevelNumber;

		public Transform localVisor;

		public Transform localVisorTargetPoint;

		private bool isSidling;

		private bool wasMovingForward;

		public MultiRotationConstraint cameraLookRig1;

		public MultiRotationConstraint cameraLookRig2;

		public Transform playerHudUIContainer;

		public Transform playerHudBaseRotation;

		public ChainIKConstraint rightArmNormalRig;

		public ChainIKConstraint rightArmProceduralRig;

		public Transform rightArmProceduralTarget;

		private Vector3 rightArmProceduralTargetBasePosition;

		public Transform leftHandItemTarget;

		public Light nightVision;

		public int currentSuitID;

		public bool performingEmote;

		public float emoteLayerWeight;

		public float timeSinceStartingEmote;

		public ParticleSystem beamUpParticle;

		public ParticleSystem beamOutParticle;

		public ParticleSystem beamOutBuildupParticle;

		public bool localArmsMatchCamera;

		public Transform localArmsTransform;

		public Collider playerCollider;

		public Collider[] bodyPartSpraypaintColliders;

		[Header("AUDIOS")]
		public AudioSource movementAudio;

		public AudioSource itemAudio;

		public AudioSource statusEffectAudio;

		public AudioSource waterBubblesAudio;

		public int currentFootstepSurfaceIndex;

		private int previousFootstepClip;

		[HideInInspector]
		public Dictionary<AudioSource, AudioReverbTrigger> audioCoroutines;

		[HideInInspector]
		public Dictionary<AudioSource, IEnumerator> audioCoroutines2;

		[HideInInspector]
		public AudioReverbTrigger currentAudioTrigger;

		public AudioReverbTrigger currentAudioTriggerB;

		public float targetDryLevel;

		public float targetRoom;

		public float targetHighFreq;

		public float targetLowFreq;

		public float targetDecayTime;

		public ReverbPreset reverbPreset;

		public AudioListener activeAudioListener;

		public AudioReverbFilter activeAudioReverbFilter;

		public ParticleSystem bloodParticle;

		public bool playingQuickSpecialAnimation;

		private Coroutine quickSpecialAnimationCoroutine;

		[Header("INPUT / MOVEMENT")]
		public float movementSpeed;

		public PlayerActions playerActions;

		private bool isWalking;

		private bool movingForward;

		public Vector2 moveInputVector;

		public Vector3 velocityLastFrame;

		private float sprintMultiplier;

		public bool isSprinting;

		public float sprintTime;

		public Image sprintMeterUI;

		[HideInInspector]
		public float sprintMeter;

		[HideInInspector]
		public bool isExhausted;

		private float exhaustionEffectLerp;

		public float jumpForce;

		private bool isJumping;

		private bool isFallingFromJump;

		private Coroutine jumpCoroutine;

		public float fallValue;

		public bool isGroundedOnServer;

		public bool isPlayerSliding;

		private float playerSlidingTimer;

		public Vector3 playerGroundNormal;

		public float maxSlideFriction;

		private float slideFriction;

		public float fallValueUncapped;

		public bool takingFallDamage;

		public float minVelocityToTakeDamage;

		public bool isCrouching;

		private float timeSinceCrouching;

		private bool isFallingNoJump;

		public int isMovementHindered;

		private int movementHinderedPrev;

		public float hinderedMultiplier;

		public int sourcesCausingSinking;

		public bool isSinking;

		public bool isUnderwater;

		private float syncUnderwaterInterval;

		private bool isFaceUnderwaterOnServer;

		public Collider underwaterCollider;

		private bool wasUnderwaterLastFrame;

		public float sinkingValue;

		public float sinkingSpeedMultiplier;

		public int statusEffectAudioIndex;

		private float cameraUp;

		public float lookSensitivity;

		public bool disableLookInput;

		private float oldLookRot;

		private float targetLookRot;

		private float previousYRot;

		private float targetYRot;

		public Vector3 syncFullRotation;

		private Vector3 walkForce;

		public Vector3 externalForces;

		private Vector3 movementForcesLastFrame;

		public Rigidbody playerRigidbody;

		public float averageVelocity;

		public int velocityMovingAverageLength;

		public int velocityAverageCount;

		public float getAverageVelocityInterval;

		public bool jetpackControls;

		public bool disablingJetpackControls;

		public Transform jetpackTurnCompass;

		private bool startedJetpackControls;

		private float previousFrameDeltaTime;

		private Collider[] nearByPlayers;

		private bool teleportingThisFrame;

		public bool teleportedLastFrame;

		[Header("LOCATION")]
		public bool isInElevator;

		public bool isInHangarShipRoom;

		public bool isInsideFactory;

		[Space(5f)]
		public bool wasInElevatorLastFrame;

		public Vector3 previousElevatorPosition;

		[Header("CONTROL / NETWORKING")]
		public ulong playerClientId;

		public string playerUsername;

		public ulong playerSteamId;

		public ulong actualClientId;

		public bool isPlayerControlled;

		public bool justConnected;

		public bool disconnectedMidGame;

		[Space(5f)]
		private bool isCameraDisabled;

		public StartOfRound playersManager;

		public bool isHostPlayerObject;

		public Vector3 oldPlayerPosition;

		private int previousAnimationState;

		public Vector3 serverPlayerPosition;

		public bool snapToServerPosition;

		private float oldCameraUp;

		public float ladderCameraHorizontal;

		private float updatePlayerAnimationsInterval;

		private float updatePlayerLookInterval;

		private List<int> currentAnimationStateHash;

		private List<int> previousAnimationStateHash;

		private float currentAnimationSpeed;

		private float previousAnimationSpeed;

		private int previousAnimationServer;

		private int oldConnectedPlayersAmount;

		private int playerMask;

		public RawImage playerScreen;

		public VoicePlayerState voicePlayerState;

		public AudioSource currentVoiceChatAudioSource;

		public PlayerVoiceIngameSettings currentVoiceChatIngameSettings;

		private float voiceChatUpdateInterval;

		public bool isTypingChat;

		[Header("DEATH")]
		public int health;

		public float healthRegenerateTimer;

		public bool criticallyInjured;

		public bool hasBeenCriticallyInjured;

		private float limpMultiplier;

		public CauseOfDeath causeOfDeath;

		public bool isPlayerDead;

		[HideInInspector]
		public bool setPositionOfDeadPlayer;

		[HideInInspector]
		public Vector3 placeOfDeath;

		public Transform spectateCameraPivot;

		public PlayerControllerB spectatedPlayerScript;

		public DeadBodyInfo deadBody;

		public GameObject[] bodyBloodDecals;

		private int currentBloodIndex;

		public List<GameObject> playerBloodPooledObjects;

		public bool bleedingHeavily;

		private float bloodDropTimer;

		private bool alternatePlaceFootprints;

		public EnemyAI inAnimationWithEnemy;

		[Header("UI/MENU")]
		public bool inTerminalMenu;

		public QuickMenuManager quickMenuManager;

		public TextMeshProUGUI usernameBillboardText;

		public Transform usernameBillboard;

		public CanvasGroup usernameAlpha;

		public Canvas usernameCanvas;

		private Vector3 tempVelocity;

		[Header("ITEM INTERACTION")]
		public float grabDistance;

		public float throwPower;

		public bool isHoldingObject;

		private bool hasThrownObject;

		public bool twoHanded;

		public bool twoHandedAnimation;

		public float carryWeight;

		public bool isGrabbingObjectAnimation;

		public bool activatingItem;

		public float grabObjectAnimationTime;

		public Transform localItemHolder;

		public Transform serverItemHolder;

		public Transform propThrowPosition;

		public GrabbableObject currentlyHeldObject;

		private GrabbableObject currentlyGrabbingObject;

		public GrabbableObject currentlyHeldObjectServer;

		public GameObject heldObjectServerCopy;

		private Coroutine grabObjectCoroutine;

		private Ray interactRay;

		private int grabbableObjectsMask;

		private int interactableObjectsMask;

		private int walkableSurfacesNoPlayersMask;

		private RaycastHit hit;

		private float upperBodyAnimationsWeight;

		public float doingUpperBodyEmote;

		private float handsOnWallWeight;

		public Light helmetLight;

		public Light[] allHelmetLights;

		private bool grabbedObjectValidated;

		private bool grabInvalidated;

		private bool throwingObject;

		[Space(5f)]
		public GrabbableObject[] ItemSlots;

		public int currentItemSlot;

		private MeshRenderer[] itemRenderers;

		private float timeSinceSwitchingSlots;

		[HideInInspector]
		public bool grabSetParentServer;

		[Header("TRIGGERS AND SPECIAL")]
		public Image cursorIcon;

		public TextMeshProUGUI cursorTip;

		public Sprite grabItemIcon;

		private bool hoveringOverItem;

		public InteractTrigger hoveringOverTrigger;

		public InteractTrigger previousHoveringOverTrigger;

		public InteractTrigger currentTriggerInAnimationWith;

		public bool isHoldingInteract;

		public bool inSpecialInteractAnimation;

		public bool disableSyncInAnimation;

		public float specialAnimationWeight;

		public bool isClimbingLadder;

		public bool enteringSpecialAnimation;

		public float climbSpeed;

		public Vector3 clampCameraRotation;

		public Transform lineOfSightCube;

		public bool voiceMuffledByEnemy;

		[Header("SPECIAL ITEMS")]
		public int shipTeleporterId;

		public EnemyAI redirectToEnemy;

		public MeshRenderer mapRadarDirectionIndicator;

		public Animator mapRadarDotAnimator;

		public bool equippedUsableItemQE;

		public bool IsInspectingItem;

		public bool isFirstFrameLateUpdate;

		public GrabbableObject pocketedFlashlight;

		public bool isFreeCamera;

		public bool isSpeedCheating;

		public bool inShockingMinigame;

		public Transform shockingTarget;

		public Transform turnCompass;

		public Transform smoothLookTurnCompass;

		public float smoothLookMultiplier;

		private bool smoothLookEnabledLastFrame;

		public Camera turnCompassCamera;

		[HideInInspector]
		public Vector3 targetScreenPos;

		[HideInInspector]
		public float shockMinigamePullPosition;

		[Space(5f)]
		public bool speakingToWalkieTalkie;

		public bool holdingWalkieTalkie;

		public float isInGameOverAnimation;

		[HideInInspector]
		public bool hasBegunSpectating;

		private Coroutine timeSpecialAnimationCoroutine;

		private float spectatedPlayerDeadTimer;

		public float insanityLevel;

		public float maxInsanityLevel;

		public float insanitySpeedMultiplier;

		public bool isPlayerAlone;

		public float timeSincePlayerMoving;

		public Scrollbar terminalScrollVertical;

		private bool updatePositionForNewlyJoinedClient;

		private float timeSinceTakingGravityDamage;

		[Space(5f)]
		public float drunkness;

		public float drunknessInertia;

		public float drunknessSpeed;

		public bool increasingDrunknessThisFrame;

		public float timeSinceMakingLoudNoise;

		ThreatType IVisibleThreat.type => default(ThreatType);

		float IVisibleThreat.GetVisibility()
		{
			return 0f;
		}

		int IVisibleThreat.GetThreatLevel(Vector3 seenByPosition)
		{
			return 0;
		}

		Vector3 IVisibleThreat.GetThreatVelocity()
		{
			return default(Vector3);
		}

		int IVisibleThreat.GetInterestLevel()
		{
			return 0;
		}

		Transform IVisibleThreat.GetThreatLookTransform()
		{
			return null;
		}

		Transform IVisibleThreat.GetThreatTransform()
		{
			return null;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CPlayIntroTip_003Ed__298))]
		private IEnumerator PlayIntroTip()
		{
			return null;
		}

		private void InstantiateBloodPooledObjects()
		{
		}

		public void ResetPlayerBloodObjects(bool resetBodyBlood = true)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void OnDestroy()
		{
		}

		private void SpeedCheat_performed(InputAction.CallbackContext context)
		{
		}

		public bool AllowPlayerDeath()
		{
			return false;
		}

		public void DamagePlayer(int damageNumber, bool hasDamageSFX = true, bool callRPC = true, CauseOfDeath causeOfDeath = CauseOfDeath.Unknown, int deathAnimation = 0, bool fallDamage = false, Vector3 force = default(Vector3))
		{
		}

		[ServerRpc]
		public void BreakLegsSFXServerRpc()
		{
		}

		[ClientRpc]
		public void BreakLegsSFXClientRpc()
		{
		}

		public void MakeCriticallyInjured(bool enable)
		{
		}

		[ServerRpc]
		public void DamagePlayerServerRpc(int damageNumber, int newHealthAmount)
		{
		}

		[ClientRpc]
		public void DamagePlayerClientRpc(int damageNumber, int newHealthAmount)
		{
		}

		private void DamageOnOtherClients(int damageNumber, int newHealthAmount)
		{
		}

		public void PlayQuickSpecialAnimation(float animTime)
		{
		}

		[IteratorStateMachine(typeof(_003CplayQuickSpecialAnimation_003Ed__314))]
		private IEnumerator playQuickSpecialAnimation(float animTime)
		{
			return null;
		}

		[ServerRpc]
		public void StartSinkingServerRpc(float sinkingSpeed, int audioClipIndex)
		{
		}

		[ClientRpc]
		public void StartSinkingClientRpc(float sinkingSpeed, int audioClipIndex)
		{
		}

		[ServerRpc]
		public void StopSinkingServerRpc()
		{
		}

		[ClientRpc]
		public void StopSinkingClientRpc()
		{
		}

		[ServerRpc]
		public void MakeCriticallyInjuredServerRpc()
		{
		}

		[ClientRpc]
		public void MakeCriticallyInjuredClientRpc()
		{
		}

		[ServerRpc]
		public void HealServerRpc()
		{
		}

		[ClientRpc]
		public void HealClientRpc()
		{
		}

		public void DropBlood(Vector3 direction = default(Vector3), bool leaveBlood = true, bool leaveFootprint = false)
		{
		}

		private void RandomizeBloodRotationAndScale(Transform blood)
		{
		}

		private void Emote1_performed(InputAction.CallbackContext context)
		{
		}

		private void Emote2_performed(InputAction.CallbackContext context)
		{
		}

		public void PerformEmote(InputAction.CallbackContext context, int emoteID)
		{
		}

		[ServerRpc]
		public void StartPerformingEmoteServerRpc()
		{
		}

		[ClientRpc]
		public void StartPerformingEmoteClientRpc()
		{
		}

		[ServerRpc]
		public void StopPerformingEmoteServerRpc()
		{
		}

		[ClientRpc]
		public void StopPerformingEmoteClientRpc()
		{
		}

		public bool CheckConditionsForSinkingInQuicksand()
		{
			return false;
		}

		private bool CheckConditionsForEmote()
		{
			return false;
		}

		private void ActivateItem_performed(InputAction.CallbackContext context)
		{
		}

		private void ActivateItem_canceled(InputAction.CallbackContext context)
		{
		}

		private bool CanUseItem()
		{
			return false;
		}

		private int FirstEmptyItemSlot()
		{
			return 0;
		}

		private int NextItemSlot(bool forward)
		{
			return 0;
		}

		private void SwitchToItemSlot(int slot, GrabbableObject fillSlotWithItem = null)
		{
		}

		private void ScrollMouse_performed(InputAction.CallbackContext context)
		{
		}

		[ServerRpc]
		private void SwitchItemSlotsServerRpc(bool forward)
		{
		}

		[ClientRpc]
		private void SwitchItemSlotsClientRpc(bool forward)
		{
		}

		private bool InteractTriggerUseConditionsMet()
		{
			return false;
		}

		private void InspectItem_performed(InputAction.CallbackContext context)
		{
		}

		private void QEItemInteract_performed(InputAction.CallbackContext context)
		{
		}

		private void ItemSecondaryUse_performed(InputAction.CallbackContext context)
		{
		}

		private void ItemTertiaryUse_performed(InputAction.CallbackContext context)
		{
		}

		private void Interact_performed(InputAction.CallbackContext context)
		{
		}

		private void BeginGrabObject()
		{
		}

		[IteratorStateMachine(typeof(_003CGrabObject_003Ed__350))]
		private IEnumerator GrabObject()
		{
			return null;
		}

		private void SetSpecialGrabAnimationBool(bool setTrue, GrabbableObject currentItem = null)
		{
		}

		[ServerRpc]
		private void GrabObjectServerRpc(NetworkObjectReference grabbedObject)
		{
		}

		[ClientRpc]
		private void GrabObjectClientRpc(bool grabValidated, NetworkObjectReference grabbedObject)
		{
		}

		private void Discard_performed(InputAction.CallbackContext context)
		{
		}

		[IteratorStateMachine(typeof(_003CwaitToEndOfFrameToDiscard_003Ed__355))]
		private IEnumerator waitToEndOfFrameToDiscard()
		{
			return null;
		}

		public void DespawnHeldObject()
		{
		}

		private void DespawnHeldObjectOnClient()
		{
		}

		[ServerRpc]
		private void DespawnHeldObjectServerRpc()
		{
		}

		[ClientRpc]
		private void DespawnHeldObjectClientRpc()
		{
		}

		public void DiscardHeldObject(bool placeObject = false, NetworkObject parentObjectTo = null, Vector3 placePosition = default(Vector3), bool matchRotationOfParent = true)
		{
		}

		private Vector3 DropItemAheadOfPlayer()
		{
			return default(Vector3);
		}

		[ServerRpc]
		private void ThrowObjectServerRpc(NetworkObjectReference grabbedObject, bool droppedInElevator, bool droppedInShipRoom, Vector3 targetFloorPosition, int floorYRot)
		{
		}

		[ClientRpc]
		private void ThrowObjectClientRpc(bool droppedInElevator, bool droppedInShipRoom, Vector3 targetFloorPosition, NetworkObjectReference grabbedObject, int floorYRot)
		{
		}

		public void SetObjectAsNoLongerHeld(bool droppedInElevator, bool droppedInShipRoom, Vector3 targetFloorPosition, GrabbableObject dropObject, int floorYRot = -1)
		{
		}

		public void SetAllItemsInElevator(bool inShipRoom, bool inElevator)
		{
		}

		public void SetItemInElevator(bool droppedInShipRoom, bool droppedInElevator, GrabbableObject gObject)
		{
		}

		[ServerRpc]
		private void PlaceObjectServerRpc(NetworkObjectReference grabbedObject, NetworkObjectReference parentObject, Vector3 placePositionOffset = default(Vector3), bool matchRotationOfParent = true)
		{
		}

		public void PlaceGrabbableObject(Transform parentObject, Vector3 positionOffset, bool matchRotationOfParent, GrabbableObject placeObject)
		{
		}

		[ClientRpc]
		private void PlaceObjectClientRpc(NetworkObjectReference parentObjectReference, Vector3 placePositionOffset, bool matchRotationOfParent, NetworkObjectReference grabbedObject)
		{
		}

		private void SetFreeCamera_performed(InputAction.CallbackContext context)
		{
		}

		public void ChangeHelmetLight(int lightNumber, bool enable = true)
		{
		}

		private void OpenMenu_performed(InputAction.CallbackContext context)
		{
		}

		private void Jump_performed(InputAction.CallbackContext context)
		{
		}

		[IteratorStateMachine(typeof(_003CPlayerJump_003Ed__374))]
		private IEnumerator PlayerJump()
		{
			return null;
		}

		public void ResetFallGravity()
		{
		}

		private void PlayerLookInput()
		{
		}

		private void SyncFullRotWithClients()
		{
		}

		private void CalculateSmoothLookingInput(Vector2 inputVector)
		{
		}

		private void CalculateNormalLookingInput(Vector2 inputVector)
		{
		}

		private void Look_performed(InputAction.CallbackContext context)
		{
		}

		bool IShockableWithGun.CanBeShocked()
		{
			return false;
		}

		float IShockableWithGun.GetDifficultyMultiplier()
		{
			return 0f;
		}

		NetworkObject IShockableWithGun.GetNetworkObject()
		{
			return null;
		}

		Transform IShockableWithGun.GetShockableTransform()
		{
			return null;
		}

		Vector3 IShockableWithGun.GetShockablePosition()
		{
			return default(Vector3);
		}

		void IShockableWithGun.ShockWithGun(PlayerControllerB shockedByPlayer)
		{
		}

		void IShockableWithGun.StopShockingWithGun()
		{
		}

		public void ForceTurnTowardsTarget()
		{
		}

		private void LookWhileClimbingLadder(Vector2 lookInput)
		{
		}

		private void Crouch_performed(InputAction.CallbackContext context)
		{
		}

		public void Crouch(bool crouch)
		{
		}

		[ServerRpc]
		private void UpdatePlayerRotationServerRpc(short newRot, short newYRot)
		{
		}

		[ClientRpc]
		private void UpdatePlayerRotationClientRpc(short newRot, short newYRot)
		{
		}

		[ServerRpc]
		private void UpdatePlayerRotationFullServerRpc(Vector3 playerEulers)
		{
		}

		[ClientRpc]
		private void UpdatePlayerRotationFullClientRpc(Vector3 playerEulers)
		{
		}

		private void UpdatePlayerAnimationsToOtherClients(Vector2 moveInputVector)
		{
		}

		[ServerRpc]
		private void UpdatePlayerAnimationServerRpc(int animationState, float animationSpeed)
		{
		}

		[ClientRpc]
		private void UpdatePlayerAnimationClientRpc(int animationState, float animationSpeed)
		{
		}

		public void UpdateSpecialAnimationValue(bool specialAnimation, short yVal = 0, float timed = 0f, bool climbingLadder = false)
		{
		}

		public void ResetZAndXRotation()
		{
		}

		[ServerRpc]
		private void IsInSpecialAnimationServerRpc(bool specialAnimation, float timed = 0f, bool climbingLadder = false)
		{
		}

		[ClientRpc]
		private void IsInSpecialAnimationClientRpc(bool specialAnimation, float timed = 0f, bool climbingLadder = false)
		{
		}

		[IteratorStateMachine(typeof(_003CtimeSpecialAnimation_003Ed__403))]
		private IEnumerator timeSpecialAnimation(float time)
		{
			return null;
		}

		public void GetCurrentMaterialStandingOn()
		{
		}

		public void PlayFootstepSound()
		{
		}

		public void PlayFootstepServer()
		{
		}

		public void PlayFootstepLocal()
		{
		}

		[ServerRpc]
		private void UpdatePlayerPositionServerRpc(Vector3 newPos, bool inElevator, bool inShipRoom, bool exhausted, bool isPlayerGrounded)
		{
		}

		[ClientRpc]
		private void UpdatePlayerPositionClientRpc(Vector3 newPos, bool inElevator, bool isInShip, bool exhausted, bool isPlayerGrounded)
		{
		}

		[ServerRpc]
		public void LandFromJumpServerRpc(bool fallHard)
		{
		}

		[ClientRpc]
		public void LandFromJumpClientRpc(bool fallHard)
		{
		}

		public void LimpAnimationSpeed()
		{
		}

		public void SpawnPlayerAnimation()
		{
		}

		[IteratorStateMachine(typeof(_003CspawnPlayerAnimTimer_003Ed__414))]
		private IEnumerator spawnPlayerAnimTimer()
		{
			return null;
		}

		[ServerRpc(RequireOwnership = false)]
		private void SendNewPlayerValuesServerRpc(ulong newPlayerSteamId)
		{
		}

		[ClientRpc]
		private void SendNewPlayerValuesClientRpc(ulong[] playerSteamIds)
		{
		}

		private int GetNumberOfDuplicateNamesInLobby()
		{
			return 0;
		}

		private string NoPunctuation(string input)
		{
			return null;
		}

		public void ConnectClientToPlayerObject()
		{
		}

		private void ChangeAudioListenerToObject(GameObject addToObject)
		{
		}

		private void PlayerHitGroundEffects()
		{
		}

		private void CalculateGroundNormal()
		{
		}

		private bool IsPlayerNearGround()
		{
			return false;
		}

		[ServerRpc]
		public void DisableJetpackModeServerRpc()
		{
		}

		[ClientRpc]
		public void DisableJetpackModeClientRpc()
		{
		}

		public void DisableJetpackControlsLocally()
		{
		}

		private void Update()
		{
		}

		private void SetFaceUnderwaterFilters()
		{
		}

		[ServerRpc]
		private void SetFaceUnderwaterServerRpc()
		{
		}

		[ClientRpc]
		private void SetFaceUnderwaterClientRpc()
		{
		}

		[ServerRpc]
		private void SetFaceOutOfWaterServerRpc()
		{
		}

		[ClientRpc]
		private void SetFaceOutOfWaterClientRpc()
		{
		}

		public void IncreaseFearLevelOverTime(float amountMultiplier = 1f, float cap = 1f)
		{
		}

		public void JumpToFearLevel(float targetFearLevel, bool onlyGoUp = true)
		{
		}

		private void SetPlayerSanityLevel()
		{
		}

		private void SetNightVisionEnabled(bool isNotLocalClient)
		{
		}

		public void ClickHoldInteraction()
		{
		}

		private void StopHoldInteractionOnTrigger()
		{
		}

		public void CancelSpecialTriggerAnimations()
		{
		}

		public void TeleportPlayer(Vector3 pos, bool withRotation = false, float rot = 0f, bool allowInteractTrigger = false, bool enableController = true)
		{
		}

		public void KillPlayer(Vector3 bodyVelocity, bool spawnBody = true, CauseOfDeath causeOfDeath = CauseOfDeath.Unknown, int deathAnimation = 0)
		{
		}

		[ServerRpc]
		private void KillPlayerServerRpc(int playerId, bool spawnBody, Vector3 bodyVelocity, int causeOfDeath, int deathAnimation)
		{
		}

		[ClientRpc]
		private void KillPlayerClientRpc(int playerId, bool spawnBody, Vector3 bodyVelocity, int causeOfDeath, int deathAnimation)
		{
		}

		public void SpawnDeadBody(int playerId, Vector3 bodyVelocity, int causeOfDeath, PlayerControllerB deadPlayerController, int deathAnimation = 0, Transform overridePosition = null)
		{
		}

		public void DestroyItemInSlotAndSync(int itemSlot)
		{
		}

		[ServerRpc]
		public void DestroyItemInSlotServerRpc(int itemSlot)
		{
		}

		[ClientRpc]
		public void DestroyItemInSlotClientRpc(int itemSlot)
		{
		}

		public void DestroyItemInSlot(int itemSlot)
		{
		}

		public void DropAllHeldItems(bool itemsFall = true, bool disconnecting = false)
		{
		}

		public void DropAllHeldItemsAndSync()
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void DropAllHeldItemsServerRpc()
		{
		}

		[ClientRpc]
		public void DropAllHeldItemsClientRpc()
		{
		}

		private bool NearOtherPlayers(PlayerControllerB playerScript = null, float checkRadius = 10f)
		{
			return false;
		}

		private bool PlayerIsHearingOthersThroughWalkieTalkie(PlayerControllerB playerScript = null)
		{
			return false;
		}

		public void DisablePlayerModel(GameObject playerObject, bool enable = false, bool disableLocalArms = false)
		{
		}

		public void SyncBodyPositionWithClients()
		{
		}

		[ClientRpc]
		public void SyncBodyPositionClientRpc(Vector3 newBodyPosition)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitUntilPlayerHasLeftBodyToTeleport_003Ed__458))]
		private IEnumerator WaitUntilPlayerHasLeftBodyToTeleport(Vector3 newBodyPosition)
		{
			return null;
		}

		private void LateUpdate()
		{
		}

		private void RaycastSpectateCameraAroundPivot()
		{
		}

		private void SetHoverTipAndCurrentInteractTrigger()
		{
		}

		public void ShowNameBillboard()
		{
		}

		public bool IsPlayerServer()
		{
			return false;
		}

		private void SpectateNextPlayer()
		{
		}

		public void SetSpectatedPlayerEffects(bool allPlayersDead = false)
		{
		}

		public void AddBloodToBody()
		{
		}

		public void RemoveBloodFromBody()
		{
		}

		bool IHittable.Hit(int force, Vector3 hitDirection, PlayerControllerB playerWhoHit, bool playHitSFX = false)
		{
			return false;
		}

		[ServerRpc(RequireOwnership = false)]
		public void DamagePlayerFromOtherClientServerRpc(int damageAmount, Vector3 hitDirection, int playerWhoHit)
		{
		}

		[ClientRpc]
		public void DamagePlayerFromOtherClientClientRpc(int damageAmount, Vector3 hitDirection, int playerWhoHit, int newHealthAmount)
		{
		}

		public bool HasLineOfSightToPosition(Vector3 pos, float width = 45f, int range = 60, float proximityAwareness = -1f)
		{
			return false;
		}

		public float LineOfSightToPositionAngle(Vector3 pos, int range = 60, float proximityAwareness = -1f)
		{
			return 0f;
		}
	}
}
