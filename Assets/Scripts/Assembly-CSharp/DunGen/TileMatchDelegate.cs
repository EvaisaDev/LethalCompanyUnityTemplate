namespace DunGen
{
	public delegate bool TileMatchDelegate(TileProxy previousTile, TileProxy potentialNextTile, ref float weight);
}
