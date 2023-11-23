using System;
using System.Collections.Generic;

[Serializable]
public class PlayerStats
{
	public int profitable;

	public int turnAmount;

	public int jumps;

	public int stepsTaken;

	public int damageTaken;

	public bool isActivePlayer;

	public List<string> playerNotes;
}
