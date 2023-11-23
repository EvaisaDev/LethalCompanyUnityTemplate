namespace DunGen
{
	public enum TilePlacementResult
	{
		None = 0,
		NoFromDoorway = 1,
		NoTilesWithMatchingDoorway = 2,
		NoValidTile = 3,
		TemplateIsNull = 4,
		NoMatchingDoorwayInTile = 5,
		TileIsColliding = 6,
		NewTileIsNull = 7,
		OutOfBounds = 8
	}
}
