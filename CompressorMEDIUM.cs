using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Strategy
{
	internal class CompressorMEDIUM : ICompressor
	{
		public void Compress()
		{
			Console.WriteLine("I'm applying a medium compressor");
		}
	}
}
