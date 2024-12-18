using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Strategy
{
	internal class SpatialFilterECHO : ISpatialFilter
	{
		public void Apply()
		{
			Console.WriteLine("I'm applying echo spatial filter");
		}
	}
}
