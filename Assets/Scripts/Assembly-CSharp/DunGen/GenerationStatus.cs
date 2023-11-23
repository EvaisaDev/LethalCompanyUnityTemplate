namespace DunGen
{
	public enum GenerationStatus
	{
		NotStarted = 0,
		PreProcessing = 1,
		TileInjection = 2,
		MainPath = 3,
		Branching = 4,
		PostProcessing = 5,
		Complete = 6,
		Failed = 7
	}
}
