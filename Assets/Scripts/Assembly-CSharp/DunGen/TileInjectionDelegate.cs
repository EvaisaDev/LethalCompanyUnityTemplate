using System.Collections.Generic;

namespace DunGen
{
	public delegate void TileInjectionDelegate(RandomStream randomStream, ref List<InjectedTile> tilesToInject);
}
