# luaLibCreator

A simple program to build modules from C to DLL for Lua using Luarocks.
[LuaRocks](http://www.luarocks.org/)
[Lua](https://www.lua.org/)

Note:

* You must have installed Luarocks and minGW

How to use:

* Run the program and select the .c file

* The module name is taken from the file name,
  the path is also based on the location of the .c file

* After changing the necessary fields, click on "Build lib",
  this will create a file with the extension .rockspec and run Luarocks

* At the exit you will get the generated DLL library for Lua

* Make a test program to test it
