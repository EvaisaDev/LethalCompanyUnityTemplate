using System.Runtime.CompilerServices;
using Discord;
using UnityEngine;

public class DiscordController : MonoBehaviour
{
	public global::Discord.Discord discord;

	public string status_Details;

	public string status_State;

	public string status_largeText;

	public string status_smallText;

	public string status_largeImage;

	public string status_smallImage;

	public int currentPartySize;

	public int maxPartySize;

	public int timeElapsed;

	public string status_partyId;

	private float timeAtLastStatusUpdate;

	private bool activityEnabled;

	private bool appQuitting;

	public static DiscordController Instance
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

	private void OnDisable()
	{
	}

	private void Application_quitting()
	{
	}

	private void Update()
	{
	}

	public void UpdateStatus(bool clear)
	{
	}
}
