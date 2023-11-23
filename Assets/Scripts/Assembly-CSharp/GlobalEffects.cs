using System.Runtime.CompilerServices;
using Unity.Netcode;
using UnityEngine;

public class GlobalEffects : NetworkBehaviour
{
	private StartOfRound playersManager;

	public bool ownedByPlayer;

	public static GlobalEffects Instance
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

	public void PlayAnimAndAudioServer(ServerAnimAndAudio serverAnimAndAudio)
	{
	}

	public void PlayAnimAndAudioServerFromSenderObject(ServerAnimAndAudio serverAnimAndAudio)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void PlayAnimAndAudioServerRpc(ServerAnimAndAudio serverAnimAndAudio)
	{
	}

	[ClientRpc]
	private void PlayAnimAndAudioClientRpc(ServerAnimAndAudio serverAnimAndAudio)
	{
	}

	public void PlayAnimationServer(ServerAnimation serverAnimation)
	{
	}

	public void PlayAnimationServerFromSenderObject(ServerAnimation serverAnimation)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void PlayAnimationServerRpc(ServerAnimation serverAnimation)
	{
	}

	[ClientRpc]
	private void PlayAnimationClientRpc(ServerAnimation serverAnimation)
	{
	}

	public void PlayAudioServer(ServerAudio serverAudio)
	{
	}

	public void PlayAudioServerFromSenderObject(ServerAudio serverAudio)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void PlayAudioServerRpc(ServerAudio serverAudio)
	{
	}

	[ClientRpc]
	private void PlayAudioClientRpc(ServerAudio serverAudio)
	{
	}
}
