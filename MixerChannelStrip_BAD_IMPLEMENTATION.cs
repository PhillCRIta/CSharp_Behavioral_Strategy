using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Strategy
{
	public class MixerChannelStrip_BAD_IMPLEMENTATION
	{
		private CompressorType _compressorType;
		private SpatialFilterType _spatialFilterType;

		public MixerChannelStrip_BAD_IMPLEMENTATION(CompressorType compressorType, SpatialFilterType spatialFilterType = SpatialFilterType.DISABLE)
		{
			_compressorType = compressorType;
			_spatialFilterType = spatialFilterType;
		}

		public void SetCompressor(CompressorType compressor)
		{
			_compressorType = compressor;
		}
		public void SetSpatialFilter(SpatialFilterType spFilter)
		{
			_spatialFilterType = spFilter;
		}
		/*
		 * This type of implementation violate the open-closed principle, you need open the class to add new compressor or spatial filter in the branching
		 */ 
		public void MixSound(string channelStripName)
		{
			if (_compressorType == CompressorType.HEAVY)
			{
				Console.WriteLine("I'm applying heavy compression on the channel");
			}
			else if (_compressorType == CompressorType.MEDIUM)
			{
				Console.WriteLine("I'm applying medium compression on the channel");
			}
			else if (_compressorType == CompressorType.SOFT)
			{
				Console.WriteLine("I'm applying soft compression on the channel");
			}
			else if (_compressorType == CompressorType.DISABLE)
			{
				Console.WriteLine("The compression is disable");
			}
			//
			if (_spatialFilterType == SpatialFilterType.DISABLE)
			{
				Console.WriteLine("The spatial filter is disable");
			}
			else if (_spatialFilterType == SpatialFilterType.ECHO)
			{
				Console.WriteLine("I'm applying echo spatial filter on the channel");
			}
			else if (_spatialFilterType == SpatialFilterType.DELAY)
			{
				Console.WriteLine("I'm applying delay spatial filter on the channel");
			}
			else if (_spatialFilterType == SpatialFilterType.REVERBER)
			{
				Console.WriteLine("I'm applying reverber spatial filter on the channel");
			}

			Console.WriteLine("I'm playing ");
		}
	}
}
