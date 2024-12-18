using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Strategy
{
	internal class SpatialFilterDISABLE : ISpatialFilter
	{
		public void Apply()
		{
			Console.WriteLine("The spatial filter is disable");
		}
	}
}
