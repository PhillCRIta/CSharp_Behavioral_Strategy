### Please note before start reading
Those code examples about design pattern have the purpose of personal use, to easily remember the patters; it's like a notepad. I took the following examples from Youtube and some web articles.

The major source of the examples is a Youtube channel of [DoableDanny](https://www.youtube.com/@doabledanny/videos), he's a very good developer. I suggest to all to buy 📒his book about design pattern 📒 , it's very clear.

# Strategy pattern
 The Strategy pattern is useful to pass different algorithms or behaviors to a specific object. \
 For example, in the next code I will create a simulation of VST Audio Instrument where I apply many type of filter, like compression, distorsion, delay, ecc. \
 Like a cubase or logic soundtrack mixer. \
Is useful for the same algorithm to apply varius type of if statement. \
The various logics can be extracted into a separate class that implement the same interface. \
The context delegate the all work to this concrete class, instead of him work.

You can change the algorithm inside of the same object. \
You need to pass the correct algorith to use. \
If there are a few algorithm that rarely change , the Strategy patter may be over-engineering.