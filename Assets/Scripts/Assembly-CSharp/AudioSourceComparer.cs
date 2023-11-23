using System.Collections.Generic;
using UnityEngine;

internal class AudioSourceComparer : IEqualityComparer<AudioSource>
{
	public bool Equals(AudioSource x, AudioSource y)
	{
		return false;
	}

	public int GetHashCode(AudioSource obj)
	{
		return 0;
	}
}
