using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameNetcodeStuff;
using Unity.Netcode;
using UnityEngine;

public class DepositItemsDesk : NetworkBehaviour, INoiseListener
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass68_0
	{
		public PlayerControllerB playerDying;

		public float startTime;

		internal bool _003CAnimationGrabPlayer_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CAnimationGrabPlayer_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DepositItemsDesk _003C_003E4__this;

		public int monsterAnimationID;

		public int playerID;

		private _003C_003Ec__DisplayClass68_0 _003C_003E8__1;

		private Animator _003CmonsterAnimator_003E5__2;

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
		public _003CAnimationGrabPlayer_003Ed__68(int _003C_003E1__state)
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
	private sealed class _003CcloseDoorAfterDelay_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DepositItemsDesk _003C_003E4__this;

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
		public _003CcloseDoorAfterDelay_003Ed__70(int _003C_003E1__state)
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
	private sealed class _003CdelayedAcceptanceOfItems_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DepositItemsDesk _003C_003E4__this;

		public int profit;

		public GrabbableObject[] objectsOnDesk;

		public int newGroupCredits;

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
		public _003CdelayedAcceptanceOfItems_003Ed__59(int _003C_003E1__state)
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
	private sealed class _003CwaitForRoundToStart_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CompanyMood mood;

		public DepositItemsDesk _003C_003E4__this;

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
		public _003CwaitForRoundToStart_003Ed__46(int _003C_003E1__state)
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

	public bool inGrabbingObjectsAnimation;

	public bool attacking;

	public bool doorOpen;

	private float noiseBehindWallVolume;

	[Space(3f)]
	public CompanyMood[] allMoodPresets;

	public CompanyMood currentMood;

	public float patienceLevel;

	public float timesHearingNoise;

	[Space(3f)]
	public float grabObjectsWaitTime;

	private float grabObjectsTimer;

	[Space(5f)]
	public NetworkObject deskObjectsContainer;

	public BoxCollider triggerCollider;

	public InteractTrigger triggerScript;

	public List<GrabbableObject> itemsOnCounter;

	public List<NetworkObject> itemsOnCounterNetworkObjects;

	public int itemsOnCounterAmount;

	public Animator depositDeskAnimator;

	private NetworkObject lastObjectAddedToDesk;

	private Coroutine acceptItemsCoroutine;

	private int angerSFXindex;

	private int clientsRecievedSellItemsRPC;

	private float updateInterval;

	private System.Random CompanyLevelRandom;

	[Header("AUDIOS")]
	public AudioSource deskAudio;

	[Header("AUDIOS")]
	public AudioSource wallAudio;

	[Header("AUDIOS")]
	public AudioSource constantWallAudio;

	[Header("AUDIOS")]
	public AudioSource doorWindowAudio;

	public AudioClip[] microphoneAudios;

	public AudioClip[] rareMicrophoneAudios;

	public AudioClip doorOpenSFX;

	public AudioClip doorShutSFX;

	public AudioClip rumbleSFX;

	public AudioClip rewardGood;

	public AudioClip rewardBad;

	public AudioSource rewardsMusic;

	public AudioSource speakerAudio;

	[Header("Attack animations")]
	public MonsterAnimation[] monsterAnimations;

	public float killAnimationTimer;

	public float timeSinceAttacking;

	public int playersKilled;

	private float timeSinceMakingWarningNoise;

	private float waitingWithDoorOpenTimer;

	private float timeSinceLoweringPatience;

	private bool inSellingItemsAnimation;

	private void Start()
	{
	}

	private void SetCompanyMood(CompanyMood mood)
	{
	}

	[IteratorStateMachine(typeof(_003CwaitForRoundToStart_003Ed__46))]
	private IEnumerator waitForRoundToStart(CompanyMood mood)
	{
		return null;
	}

	public void PlaceItemOnCounter(PlayerControllerB playerWhoTriggered)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void AddObjectToDeskServerRpc(NetworkObjectReference grabbableObjectNetObject)
	{
	}

	[ClientRpc]
	public void AddObjectToDeskClientRpc(NetworkObjectReference grabbableObjectNetObject)
	{
	}

	private void Update()
	{
	}

	private void UpdateEffects()
	{
	}

	private void TakeItemsOffCounterOnServer()
	{
	}

	[ClientRpc]
	public void TakeObjectsClientRpc()
	{
	}

	public void SellItemsOnServer()
	{
	}

	[ClientRpc]
	public void SellItemsClientRpc(int itemProfit, int newGroupCredits, int itemsSold, float buyingRate)
	{
	}

	private void SellAndDisplayItemProfits(int profit, int newGroupCredits)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void CheckAllPlayersSoldItemsServerRpc()
	{
	}

	[ClientRpc]
	public void FinishSellingItemsClientRpc()
	{
	}

	[IteratorStateMachine(typeof(_003CdelayedAcceptanceOfItems_003Ed__59))]
	private IEnumerator delayedAcceptanceOfItems(int profit, GrabbableObject[] objectsOnDesk, int newGroupCredits)
	{
		return null;
	}

	private void PlayRewardEffects(int profit)
	{
	}

	private void MicrophoneSpeak()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void AttackPlayersServerRpc()
	{
	}

	[ClientRpc]
	public void AttackPlayersClientRpc()
	{
	}

	public void Attack()
	{
	}

	public void CollisionDetect(int monsterAnimationID)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void CheckAnimationGrabPlayerServerRpc(int monsterAnimationID, int playerID)
	{
	}

	[ClientRpc]
	public void ConfirmAnimationGrabPlayerClientRpc(int monsterAnimationID, int playerID)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimationGrabPlayer_003Ed__68))]
	private IEnumerator AnimationGrabPlayer(int monsterAnimationID, int playerID)
	{
		return null;
	}

	public void FinishKillAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CcloseDoorAfterDelay_003Ed__70))]
	private IEnumerator closeDoorAfterDelay()
	{
		return null;
	}

	void INoiseListener.DetectNoise(Vector3 noisePosition, float noiseLoudness = 0.5f, int timesPlayedInOneSpot = 0, int noiseID = 0)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SetPatienceServerRpc(float valueChange)
	{
	}

	[ClientRpc]
	public void MakeWarningNoiseClientRpc()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SetTimesHeardNoiseServerRpc(float valueChange)
	{
	}

	[ClientRpc]
	public void OpenShutDoorClientRpc(bool open = true)
	{
	}

	public void OpenShutDoor(bool open)
	{
	}

	public void MakeLoudNoise(int noise)
	{
	}
}
