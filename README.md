# SignalR broadcast demo
## Finnish MS Techdays 2013

This project demonstrates what it takes to replicate actions - in this case pointer events - to all other clients connected to the same site. 

Technologies used:

- [SignalR](http://signalr.net) [persistent connections](https://github.com/SignalR/SignalR/wiki/PersistentConnection) for fast broadcasting with WebSockets
- HTML Canvas
- [Queue.js by Stephan Morley](http://code.stephenmorley.org/) to optimize canvas rendering queue

To run the demo, open project in Visual Studio, run it, and open multiple browsers to point to the [local site http://localhost:6205/](http://localhost:6205/).

-----
### What should I look for?
Meaningful code can be found from

- BroadCastAllConnection.cs: implements persistent connection
- Views/Home/Index.cshtml: contains client side Javasript logic to draw on canvas and to broadcast actions (intentionally all on one file for easy demonstration)


