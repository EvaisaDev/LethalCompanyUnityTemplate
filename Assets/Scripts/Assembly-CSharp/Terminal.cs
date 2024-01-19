using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.Video;

public class Terminal : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass91_0
	{
		public QuickMenuManager quickMenu;

		internal bool _003CdisplayReimbursedTipDelay_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CdisplayReimbursedTipDelay_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private _003C_003Ec__DisplayClass91_0 _003C_003E8__1;

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
		public _003CdisplayReimbursedTipDelay_003Ed__91(int _003C_003E1__state)
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
	private sealed class _003CforceScrollbarDown_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Terminal _003C_003E4__this;

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
		public _003CforceScrollbarDown_003Ed__61(int _003C_003E1__state)
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
	private sealed class _003CforceScrollbarUp_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Terminal _003C_003E4__this;

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
		public _003CforceScrollbarUp_003Ed__62(int _003C_003E1__state)
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
	private sealed class _003CloadImageSlowly_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Terminal _003C_003E4__this;

		private float _003CpaddingValue_003E5__2;

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
		public _003CloadImageSlowly_003Ed__70(int _003C_003E1__state)
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
	private sealed class _003CloadTextAnimation_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Terminal _003C_003E4__this;

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
		public _003CloadTextAnimation_003Ed__66(int _003C_003E1__state)
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
	private sealed class _003CselectTextFieldDelayed_003Ed__96 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Terminal _003C_003E4__this;

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
		public _003CselectTextFieldDelayed_003Ed__96(int _003C_003E1__state)
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
	private sealed class _003CwaitUntilFrameEndToSetActive_003Ed__90 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Terminal _003C_003E4__this;

		public bool active;

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
		public _003CwaitUntilFrameEndToSetActive_003Ed__90(int _003C_003E1__state)
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

	public Canvas terminalUIScreen;

	public PlayerActions playerActions;

	public bool terminalInUse;

	public float timeSinceTerminalInUse;

	private InteractTrigger terminalTrigger;

	public RawImage terminalImage;

	public RectMask2D terminalImageMask;

	public RenderTexture videoTexture;

	public VideoPlayer videoPlayer;

	public TMP_InputField screenText;

	public int textAdded;

	public string currentText;

	public TerminalNode currentNode;

	public TerminalNodesList terminalNodes;

	[Space(3f)]
	public Animator terminalUIAnimator;

	public PlaceableShipObject placeableObject;

	private bool usedTerminalThisSession;

	private bool modifyingText;

	public int playerDefinedAmount;

	private RoundManager roundManager;

	public int groupCredits;

	private int totalCostOfItems;

	public AudioSource terminalAudio;

	public AudioClip[] keyboardClips;

	public AudioClip[] syncedAudios;

	private float timeSinceLastKeyboardPress;

	public bool useCreditsCooldown;

	private Coroutine loadImageCoroutine;

	private bool hasGottenNoun;

	private bool hasGottenVerb;

	[Space(7f)]
	private bool broadcastedCodeThisFrame;

	public Animator codeBroadcastAnimator;

	public AudioClip codeBroadcastSFX;

	[Space(5f)]
	public List<int> scannedEnemyIDs;

	public List<TerminalNode> enemyFiles;

	public List<int> newlyScannedEnemyIDs;

	[Space(3f)]
	public List<int> unlockedStoryLogs;

	public List<TerminalNode> logEntryFiles;

	public List<int> newlyUnlockedStoryLogs;

	[Space(7f)]
	public List<TerminalNode> ShipDecorSelection;

	private bool syncedTerminalValues;

	public int numberOfItemsInDropship;

	public Scrollbar scrollBarVertical;

	public TextMeshProUGUI inputFieldText;

	public CanvasGroup scrollBarCanvasGroup;

	public RenderTexture playerScreenTex;

	public RenderTexture playerScreenTexHighRes;

	public TextMeshProUGUI topRightText;

	public SelectableLevel[] moonsCatalogueList;

	[Header("Store-bought player items")]
	public Item[] buyableItemsList;

	public int[] itemSalesPercentages;

	[Space(3f)]
	public List<int> orderedItemsFromTerminal;

	[Space(5f)]
	private Coroutine selectTextFieldCoroutine;

	public AudioClip enterTerminalSFX;

	public AudioClip leaveTerminalSFX;

	public Light terminalLight;

	private Coroutine forceScrollbarCoroutine;

	public bool displayingSteamKeyboard;

	public Texture displayingPersistentImage;

	public int startingCreditsAmount;

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CforceScrollbarDown_003Ed__61))]
	private IEnumerator forceScrollbarDown()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CforceScrollbarUp_003Ed__62))]
	private IEnumerator forceScrollbarUp()
	{
		return null;
	}

	public void LoadNewNode(TerminalNode node)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void PlayTerminalAudioServerRpc(int clipIndex)
	{
	}

	[ClientRpc]
	public void PlayTerminalAudioClientRpc(int clipIndex)
	{
	}

	[IteratorStateMachine(typeof(_003CloadTextAnimation_003Ed__66))]
	private IEnumerator loadTextAnimation()
	{
		return null;
	}

	private string TextPostProcess(string modifiedDisplayText, TerminalNode node)
	{
		return null;
	}

	public void RunTerminalEvents(TerminalNode node)
	{
	}

	public void LoadTerminalImage(TerminalNode node)
	{
	}

	[IteratorStateMachine(typeof(_003CloadImageSlowly_003Ed__70))]
	private IEnumerator loadImageSlowly()
	{
		return null;
	}

	public void OnSubmit()
	{
	}

	private void AttemptLoadCreatureFileNode(TerminalNode node)
	{
	}

	private void AttemptLoadStoryLogFileNode(TerminalNode node)
	{
	}

	private void LoadNewNodeIfAffordable(TerminalNode node)
	{
	}

	private void SyncBoughtItemsWithServer(int[] boughtItems, int numItemsInShip)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void BuyItemsServerRpc(int[] boughtItems, int newGroupCredits, int numItemsInShip)
	{
	}

	[ServerRpc]
	public void SyncGroupCreditsServerRpc(int newGroupCredits, int numItemsInShip)
	{
	}

	[ClientRpc]
	public void SyncGroupCreditsClientRpc(int newGroupCredits, int numItemsInShip)
	{
	}

	private TerminalNode ParsePlayerSentence()
	{
		return null;
	}

	private int CheckForPlayerNameCommand(string firstWord, string secondWord)
	{
		return 0;
	}

	private TerminalKeyword CheckForExactSentences(string playerWord)
	{
		return null;
	}

	private TerminalKeyword ParseWord(string playerWord, int specificityRequired = 2)
	{
		return null;
	}

	private TerminalNode ParseWordOverrideOptions(string playerWord, CompatibleNoun[] options)
	{
		return null;
	}

	public void TextChanged(string newText)
	{
	}

	private string RemovePunctuation(string s)
	{
		return null;
	}

	private void CallFunctionInAccessibleTerminalObject(string word)
	{
	}

	private void PlayBroadcastCodeEffect()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CwaitUntilFrameEndToSetActive_003Ed__90))]
	private IEnumerator waitUntilFrameEndToSetActive(bool active)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CdisplayReimbursedTipDelay_003Ed__91))]
	private IEnumerator displayReimbursedTipDelay()
	{
		return null;
	}

	[ServerRpc(RequireOwnership = false)]
	public void SyncTerminalValuesServerRpc()
	{
	}

	[ClientRpc]
	public void SyncTerminalValuesClientRpc(int newGroupCredits = 0, int numItemsInDropship = 0, int[] scannedEnemies = null, int[] storyLogs = null)
	{
	}

	public void BeginUsingTerminal()
	{
	}

	public void OnGamepadTextInputDismissed_t(bool submitted)
	{
	}

	[IteratorStateMachine(typeof(_003CselectTextFieldDelayed_003Ed__96))]
	private IEnumerator selectTextFieldDelayed()
	{
		return null;
	}

	public void QuitTerminal()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void PressESC(InputAction.CallbackContext context)
	{
	}

	public void RotateShipDecorSelection()
	{
	}

	private void InitializeItemSalesPercentages()
	{
	}

	public void SetItemSales()
	{
	}

	private int RoundToNearestTen(int i)
	{
		return 0;
	}

	public void SetTerminalInUseLocalClient(bool inUse)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SetTerminalInUseServerRpc(bool inUse)
	{
	}

	[ClientRpc]
	public void SetTerminalInUseClientRpc(bool inUse)
	{
	}

	public void SetTerminalNoLongerInUse()
	{
	}
}
