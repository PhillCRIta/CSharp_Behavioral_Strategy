using Behavioral_Strategy;
/*
 The Strategy pattern is useful to pass different algorithms or behaviors to a specific object.
 For example, in the next code I will create a simulation of VST Audio Instrument where I apply many type of filter,
 like compression, distorsion, delay, ecc. Like a cubase or logic soundtrack mixer.
Is useful for the same algorithm to apply varius type of if statement. The various logics can be extracted into a separate class that implement the same interface.
The context delegate the all work to this concrete class, instead of him work

You can change the algorithm inside of the same object
You need to pass the correct algorith to use
If there are a few algorithm that rarely change , the Strategy patter may be over-engineering.
 */

//create a channel strip of mixer

MixerChannelStrip channel1 = new MixerChannelStrip(new CompressorHEAVY(), new SpatialFilterDISABLE());
channel1.MixSound("Kick sound");
Console.WriteLine("*********");
Console.WriteLine("Change the route of channel for a new purpose");
channel1.SetCompressor(new CompressorSOFT());
channel1.SetSpatialFilter(new SpatialFilterREVERB());
channel1.MixSound("Lead sound");