using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Strategy
{
	internal class MixerChannelStrip
	{
		private ICompressor _compressorType;
		private ISpatialFilter _spatialFilterType;

		public MixerChannelStrip(ICompressor compressorType, ISpatialFilter spatialFilterType)
		{
			_compressorType = compressorType;
			_spatialFilterType = spatialFilterType;
		}
		public void SetCompressor(ICompressor compressor)
		{
			_compressorType = compressor;
		}
		public void SetSpatialFilter(ISpatialFilter spFilter)
		{
			_spatialFilterType = spFilter;
		}

		public void MixSound(string channelStripName)
		{
			//the channel strip doesn't know wich type of compress or spatial filter is applicated
			_compressorType.Compress();
			_spatialFilterType.Apply();
			Console.WriteLine("I'm mixing the " + channelStripName);
		}
	}
}
