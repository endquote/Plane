Plane
============

There have been a couple of attempts to create a reusable perspective transform in WPF, but I found them both lacking. The main problem I had with existing solutions is that I needed my psuedo-3D element to play perfectly well with the WPF layout system, and I also needed my text to look perfect when the object was not rotated at some strange angle. So I started with those examples, and along with some help from David Teitlebaum and my co-worker Joel Pryde, created a class simply called “Plane”.

In addition to the features illustrated in the test application, Plane lets you specify differently-sized content for the front and back sides, renders content in regular 2D when rotated to an angle parallel to the display, and has no trouble existing in the same layout with regular 2D objects.

This solution also includes an example of using Plane to flip over ScatterViewItems, as shown in this video: https://vimeo.com/385845179
