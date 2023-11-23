using UnityEngine;

namespace DunGen
{
	public enum AxisDirection
	{
		[InspectorName("+X")]
		PosX = 0,
		[InspectorName("-X")]
		NegX = 1,
		[InspectorName("+Y")]
		PosY = 2,
		[InspectorName("-Y")]
		NegY = 3,
		[InspectorName("+Z")]
		PosZ = 4,
		[InspectorName("-Z")]
		NegZ = 5
	}
}
