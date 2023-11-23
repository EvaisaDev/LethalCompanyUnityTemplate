using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerActions : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
{
	public struct MovementActions
	{
		private PlayerActions m_Wrapper;

		public InputAction Look => null;

		public InputAction Move => null;

		public InputAction Jump => null;

		public InputAction Sprint => null;

		public InputAction OpenMenu => null;

		public InputAction Interact => null;

		public InputAction Crouch => null;

		public InputAction Use => null;

		public InputAction ActivateItem => null;

		public InputAction Discard => null;

		public InputAction SwitchItem => null;

		public InputAction QEItemInteract => null;

		public InputAction EnableChat => null;

		public InputAction SubmitChat => null;

		public InputAction ReloadBatteries => null;

		public InputAction SetFreeCamera => null;

		public InputAction InspectItem => null;

		public InputAction SpeedCheat => null;

		public InputAction PingScan => null;

		public InputAction VoiceButton => null;

		public InputAction Emote1 => null;

		public InputAction Emote2 => null;

		public InputAction BuildMode => null;

		public InputAction ConfirmBuildMode => null;

		public InputAction Delete => null;

		public bool enabled => false;

		public InputActionMap Get()
		{
			return null;
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public static implicit operator InputActionMap(MovementActions set)
		{
			return null;
		}

		public void AddCallbacks(IMovementActions instance)
		{
		}

		private void UnregisterCallbacks(IMovementActions instance)
		{
		}

		public void RemoveCallbacks(IMovementActions instance)
		{
		}

		public void SetCallbacks(IMovementActions instance)
		{
		}
	}

	public interface IMovementActions
	{
		void OnLook(InputAction.CallbackContext context);

		void OnMove(InputAction.CallbackContext context);

		void OnJump(InputAction.CallbackContext context);

		void OnSprint(InputAction.CallbackContext context);

		void OnOpenMenu(InputAction.CallbackContext context);

		void OnInteract(InputAction.CallbackContext context);

		void OnCrouch(InputAction.CallbackContext context);

		void OnUse(InputAction.CallbackContext context);

		void OnActivateItem(InputAction.CallbackContext context);

		void OnDiscard(InputAction.CallbackContext context);

		void OnSwitchItem(InputAction.CallbackContext context);

		void OnQEItemInteract(InputAction.CallbackContext context);

		void OnEnableChat(InputAction.CallbackContext context);

		void OnSubmitChat(InputAction.CallbackContext context);

		void OnReloadBatteries(InputAction.CallbackContext context);

		void OnSetFreeCamera(InputAction.CallbackContext context);

		void OnInspectItem(InputAction.CallbackContext context);

		void OnSpeedCheat(InputAction.CallbackContext context);

		void OnPingScan(InputAction.CallbackContext context);

		void OnVoiceButton(InputAction.CallbackContext context);

		void OnEmote1(InputAction.CallbackContext context);

		void OnEmote2(InputAction.CallbackContext context);

		void OnBuildMode(InputAction.CallbackContext context);

		void OnConfirmBuildMode(InputAction.CallbackContext context);

		void OnDelete(InputAction.CallbackContext context);
	}

	private readonly InputActionMap m_Movement;

	private List<IMovementActions> m_MovementActionsCallbackInterfaces;

	private readonly InputAction m_Movement_Look;

	private readonly InputAction m_Movement_Move;

	private readonly InputAction m_Movement_Jump;

	private readonly InputAction m_Movement_Sprint;

	private readonly InputAction m_Movement_OpenMenu;

	private readonly InputAction m_Movement_Interact;

	private readonly InputAction m_Movement_Crouch;

	private readonly InputAction m_Movement_Use;

	private readonly InputAction m_Movement_ActivateItem;

	private readonly InputAction m_Movement_Discard;

	private readonly InputAction m_Movement_SwitchItem;

	private readonly InputAction m_Movement_QEItemInteract;

	private readonly InputAction m_Movement_EnableChat;

	private readonly InputAction m_Movement_SubmitChat;

	private readonly InputAction m_Movement_ReloadBatteries;

	private readonly InputAction m_Movement_SetFreeCamera;

	private readonly InputAction m_Movement_InspectItem;

	private readonly InputAction m_Movement_SpeedCheat;

	private readonly InputAction m_Movement_PingScan;

	private readonly InputAction m_Movement_VoiceButton;

	private readonly InputAction m_Movement_Emote1;

	private readonly InputAction m_Movement_Emote2;

	private readonly InputAction m_Movement_BuildMode;

	private readonly InputAction m_Movement_ConfirmBuildMode;

	private readonly InputAction m_Movement_Delete;

	public InputActionAsset asset
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public InputBinding? bindingMask
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ReadOnlyArray<InputDevice>? devices
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ReadOnlyArray<InputControlScheme> controlSchemes => default(ReadOnlyArray<InputControlScheme>);

	public IEnumerable<InputBinding> bindings => null;

	public MovementActions Movement => default(MovementActions);

	public void Dispose()
	{
	}

	public bool Contains(InputAction action)
	{
		return false;
	}

	public IEnumerator<InputAction> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public void Enable()
	{
	}

	public void Disable()
	{
	}

	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
	{
		return null;
	}

	public int FindBinding(InputBinding bindingMask, out InputAction action)
	{
		action = null;
		return 0;
	}
}
