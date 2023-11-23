namespace DunGen
{
	public sealed class TileConnectionRule
	{
		public enum ConnectionResult
		{
			Allow = 0,
			Deny = 1,
			Passthrough = 2
		}

		public delegate ConnectionResult CanTilesConnectDelegate(Tile tileA, Tile tileB, Doorway doorwayA, Doorway doorwayB);

		public int Priority;

		public CanTilesConnectDelegate Delegate;

		public TileConnectionRule(CanTilesConnectDelegate connectionDelegate, int priority = 0)
		{
		}
	}
}
