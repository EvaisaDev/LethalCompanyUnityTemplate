using Unity.Netcode;

public struct ServerAnimAndAudio : INetworkSerializable
{
	public string animationString;

	public NetworkObjectReference animatorObj;

	public NetworkObjectReference audioObj;

	public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
	{
	}
}
