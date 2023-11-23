namespace DunGen.Adapters
{
	public abstract class CullingAdapter : BaseAdapter
	{
		public CullingAdapter()
		{
		}

		protected abstract void PrepareForCulling(DungeonGenerator generator, Dungeon dungeon);

		protected override void Run(DungeonGenerator generator)
		{
		}
	}
}
