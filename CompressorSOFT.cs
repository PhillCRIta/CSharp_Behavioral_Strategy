using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Strategy
{
	internal class CompressorSOFT : ICompressor
	{
		public void Compress()
		{
			Console.WriteLine("I'm applying a soft compression");
		}
	}
}
