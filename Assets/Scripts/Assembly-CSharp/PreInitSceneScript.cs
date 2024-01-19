using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PreInitSceneScript : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CloadSceneDelayed_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool online;

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
		public _003CloadSceneDelayed_003Ed__22(int _003C_003E1__state)
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
	private sealed class _003CrestartGameDueToCorruptedFile_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PreInitSceneScript _003C_003E4__this;

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
		public _003CrestartGameDueToCorruptedFile_003Ed__27(int _003C_003E1__state)
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

	public AudioSource mainAudio;

	public AudioClip hoverSFX;

	public AudioClip selectSFX;

	private bool choseLaunchOption;

	[Header("Other initial launch settings")]
	public Slider gammaSlider;

	public GameObject continueButton;

	public Animator blackTransition;

	public GameObject OnlineModeButton;

	public GameObject[] LaunchSettingsPanels;

	public int currentLaunchSettingPanel;

	public TextMeshProUGUI headerText;

	private bool clickedDeleteFiles;

	public GameObject FileCorruptedPanel;

	public GameObject FileCorruptedDialoguePanel;

	public GameObject FileCorruptedRestartButton;

	public GameObject restartingGameText;

	public GameObject launchSettingsPanelsContainer;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void PressContinueButton()
	{
	}

	public void HoverButton()
	{
	}

	public void ChooseLaunchOption(bool online)
	{
	}

	[IteratorStateMachine(typeof(_003CloadSceneDelayed_003Ed__22))]
	private IEnumerator loadSceneDelayed(bool online)
	{
		return null;
	}

	public void SetLaunchPanelsEnabled()
	{
	}

	public void SkipToFinalSetting()
	{
	}

	public void EnableFileCorruptedScreen()
	{
	}

	public void EraseFileAndRestart()
	{
	}

	[IteratorStateMachine(typeof(_003CrestartGameDueToCorruptedFile_003Ed__27))]
	private IEnumerator restartGameDueToCorruptedFile()
	{
		return null;
	}
}
