using Unity.Netcode;

public struct ServerAudio : INetworkSerializable
{
	public NetworkObjectReference audioObj;

	public bool oneshot;

	public bool looped;

	public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
	{
	}
}
