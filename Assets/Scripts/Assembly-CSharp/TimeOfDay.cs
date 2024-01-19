using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering.HighDefinition;

public class TimeOfDay : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CfadeOutEffect_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeatherEffect effect;

		public Vector3 moveFromPosition;

		public TimeOfDay _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CfadeOutEffect_003Ed__80(int _003C_003E1__state)
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
	private sealed class _003CplaySoundDelayed_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public TimeOfDay _003C_003E4__this;

		public AudioClip clip;

		public bool playRandomDaytimeMusic;

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
		public _003CplaySoundDelayed_003Ed__79(int _003C_003E1__state)
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

	[Header("Time")]
	public SelectableLevel currentLevel;

	public float globalTimeSpeedMultiplier;

	public float currentDayTime;

	public int hour;

	private int previousHour;

	public float normalizedTimeOfDay;

	[Space(5f)]
	public float globalTime;

	public float globalTimeAtEndOfDay;

	public bool movingGlobalTimeForward;

	[Space(10f)]
	private bool reachedQuota;

	public QuotaSettings quotaVariables;

	public int profitQuota;

	public int quotaFulfilled;

	public int timesFulfilledQuota;

	public float timeUntilDeadline;

	public int daysUntilDeadline;

	public int hoursUntilDeadline;

	[Space(5f)]
	public float lengthOfHours;

	public int numberOfHours;

	public float totalTime;

	public const int startingGlobalTime = 100;

	[Space(3f)]
	public float shipLeaveAutomaticallyTime;

	[Space(5f)]
	public bool currentDayTimeStarted;

	private bool timeStartedThisFrame;

	public StartOfRound playersManager;

	public Animator sunAnimator;

	public Light sunIndirect;

	public Light sunDirect;

	public bool insideLighting;

	public DayMode dayMode;

	private DayMode dayModeLastTimePlayerWasOutside;

	public AudioClip[] timeOfDayCues;

	public AudioSource TimeOfDayMusic;

	private HDAdditionalLightData indirectLightData;

	[Header("Weather")]
	public WeatherEffect[] effects;

	public LevelWeatherType currentLevelWeather;

	public float currentWeatherVariable;

	public float currentWeatherVariable2;

	[Space(4f)]
	public CompanyMood currentCompanyMood;

	public CompanyMood[] CommonCompanyMoods;

	[Space(4f)]
	private float changeHUDTimeInterval;

	private float nextTimeSync;

	public bool shipLeavingAlertCalled;

	public DialogueSegment[] shipLeavingSoonDialogue;

	public DialogueSegment[] shipLeavingEarlyDialogue;

	private bool shipLeavingOnMidnight;

	private bool shipFullCapacityAtMidnightMessage;

	private Coroutine playDelayedMusicCoroutine;

	public int votesForShipToLeaveEarly;

	public bool votedShipToLeaveEarlyThisRound;

	public UnityEvent onTimeSync;

	public static TimeOfDay Instance
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

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void MoveGlobalTime()
	{
	}

	public float CalculatePlanetTime(SelectableLevel level)
	{
		return 0f;
	}

	public float CalculatePlanetTimeClampToEndOfDay(SelectableLevel level)
	{
		return 0f;
	}

	private void MoveTimeOfDay()
	{
	}

	public void SetInsideLightingDimness(bool doNotLerp = false, bool setValueTo = false)
	{
	}

	private int RoundUpToNearestTen(float x)
	{
		return 0;
	}

	private void SyncGlobalTimeOnNetwork()
	{
	}

	[ClientRpc]
	public void SyncTimeClientRpc(float time, int deadline)
	{
	}

	public void TimeOfDayEvents()
	{
	}

	public void SetNewProfitQuota()
	{
	}

	[ClientRpc]
	public void SyncNewProfitQuotaClientRpc(int newProfitQuota, int overtimeBonus, int fulfilledQuota)
	{
	}

	public void UpdateProfitQuotaCurrentTime()
	{
	}

	[ClientRpc]
	public void SetShipToLeaveOnMidnightClientRpc()
	{
	}

	public void VoteShipToLeaveEarly()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SetShipLeaveEarlyServerRpc()
	{
	}

	[ClientRpc]
	public void AddVoteForShipToLeaveEarlyClientRpc()
	{
	}

	[ClientRpc]
	public void SetShipLeaveEarlyClientRpc(float timeToLeaveEarly, int votes)
	{
	}

	[ClientRpc]
	public void ShipFullCapacityMidnightClientRpc()
	{
	}

	public DayMode GetDayPhase(float time)
	{
		return default(DayMode);
	}

	private void PlayerSeesNewTimeOfDay()
	{
	}

	public void PlayTimeMusicDelayed(AudioClip clip, float delay, bool playRandomDaytimeMusic = false)
	{
	}

	[IteratorStateMachine(typeof(_003CplaySoundDelayed_003Ed__79))]
	private IEnumerator playSoundDelayed(AudioClip clip, float delay, bool playRandomDaytimeMusic)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CfadeOutEffect_003Ed__80))]
	private IEnumerator fadeOutEffect(WeatherEffect effect, Vector3 moveFromPosition)
	{
		return null;
	}

	private void SetWeatherEffects()
	{
	}

	private void DisableWeatherEffect(WeatherEffect effect)
	{
	}

	public void DisableAllWeather(bool deactivateObjects = false)
	{
	}

	public void RefreshClockUI()
	{
	}

	public void OnHourChanged(int amount = 1)
	{
	}

	public void OnDayChanged()
	{
	}

	public void SetCompanyMood()
	{
	}

	public void SetBuyingRateForDay()
	{
	}
}
