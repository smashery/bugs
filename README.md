Bugs
====

This project was made for a SecTalks presentation. It contains intentionally buggy C# code. The theme of the bugs is "Oh, I didn't realise <fundamental data structure> worked like that. If you're coding in a language, it's good to understand how your abstractions work under the covers

Bug #0 is just a demo of a particular bug to give the idea. After that, there are clear aims for each one that should be obvious from reading the code.

Getting the code running
========================

I've tested this on Windows 10, as well as a recent Kali version.

The git repo contains two Visual Studio projects that both run exactly the same code under different configurations
- BugsFramework: A standard .NET Framework 2.0 project
- BugsCore: A .NET Core 2.0 project

Running from Windows
--------------------

I've provided a pre-built binary for .NET Framework 2.0 at <repo>\BugsFramework\BugsFramework.exe. If you trust me, you can just run that. It should "just work" on at least Vista or newer.

If you'd rather run from source, I totally get that.
If you have Visual Studio 2017, you should be able to launch it in that and run from source.
If you don't have VS2017, but do have the relevant SDK installs, you could use csc to compile the .NET Framework version.
If you have .NET Core 2.0 Runtime installed, you could run it from that.

Running from Kali
-----------------

".NET Core" is a subset of the .NET framework that is cross-platform. To run it on Kali, there are instructions online, but it requires a ~134MB download. So we've got USB sticks that you can use to get that.

Alternatively, if you've got Mono installed, that should be able to run the pre-made binary. I can't guarantee that the bugs will behave in exactly the same way; but if Mono's version of the CLR is to-spec, then it should be fine.

If you want to run it under .NET Core, I've configured it to run with version 2.0. Instructions for installing are here:

https://www.microsoft.com/net/core#linuxdebian

The summary is:
- sudo apt-get install curl libunwind8 gettext # Install .NET Core dependencies
- Get dotnet.tar.gz off a USB stick (or if you really want to download it, - curl -sSL -o dotnet.tar.gz https://aka.ms/dotnet-sdk-2.0.0-linux-x64)
- mkdir -p ~/dotnet && tar zxf dotnet.tar.gz -C ~/dotnet # Make a directory for your .NET Core install
- export PATH=$PATH:$HOME/dotnet # Add the .NET Core programs to your path variable
- cd <wherever you downloaded this git repo>
- cd bugs
- cd Bugs
- dotnet run
- (You should be up and running)
- ('q' is the command to leave a module)

Running from other Linux
------------------------

Like with Kali, you can try running under Mono; or .NET Core, if you have that installed.
Installation instructions for .NET Core are here: https://www.microsoft.com/net/core - but you'll have to do a big download.

Running from Mac
----------------

I've got a .pkg file on the USB sticks. I haven't tested this configuration, but if everything's to spec, then we should be good.