using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Strategy
{
	internal class CompressorDISABLE : ICompressor
	{
		public void Compress()
		{
			Console.WriteLine("The compression is disable");
		}
	}
}
