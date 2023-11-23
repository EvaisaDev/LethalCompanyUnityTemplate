namespace DunGen.Adapters
{
	public abstract class NavMeshAdapter : BaseAdapter
	{
		public struct NavMeshGenerationProgress
		{
			public float Percentage;

			public string Description;
		}

		public delegate void OnNavMeshGenerationProgress(NavMeshGenerationProgress progress);

		public OnNavMeshGenerationProgress OnProgress;

		protected override void Run(DungeonGenerator generator)
		{
		}

		public abstract void Generate(Dungeon dungeon);
	}
}
