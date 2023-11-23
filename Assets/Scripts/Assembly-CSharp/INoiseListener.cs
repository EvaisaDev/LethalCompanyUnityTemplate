using UnityEngine;

public interface INoiseListener
{
	void DetectNoise(Vector3 noisePosition, float noiseLoudness, int timesPlayedInOneSpot, int noiseID);
}
