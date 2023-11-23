using System.Runtime.CompilerServices;

namespace DigitalRuby.ThunderAndLightning
{
	public class SingleLineClampAttribute : SingleLineAttribute
	{
		public double MinValue
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public double MaxValue
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public SingleLineClampAttribute(string tooltip, double minValue, double maxValue)
			: base(null)
		{
		}
	}
}
