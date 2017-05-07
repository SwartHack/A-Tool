# A-Tool
A tool for whatever

#Introduction Welcome to A-Tool applications repository!!! What is "A-Tool"??? - I guess we will all find out as it morphs into whatever.... The primary intended purpose is to provide public access to some of my stuff. I have been managing in VS Team Services and am also working on the "The 2-way link".

A-Tool can be anything, any technology. For posterities sake the first A-Tool is VS 2017 .NET 4.6 WinForm "A Service Controller" See https://defaultwebsite.net for more details

Acknowledgements A-Tool utilizes extended versions of code from these GitHub contributors:
https://github.com/dwmkerr/consolecontrol Haven't hooked it into the app process yet, but plan on doing so. Right now it is just an over glorified output screen...

AServiceController project component frmServiceProcMon.cs and the project ProcessInterface include contribution from an unidentified source(s). Refer to discussion in frmServiceProcMon.cs. I thought the link in the discussion was source, but it was the reference. I will eventually track it down and update accordiningly. All in all some pretty handy stuff, especially these two

/// A ProcessEventHandler is a delegate for process input/output event
public delegate void ProcessEventHanlder(object sender, ProcessEventArgs args);

/// A class the wraps a process, allowing programmatic input and output.
public class ProcessInterface

#Current Tools
"A Service Controller" 
##########WARNING##############
I will discuss the details and look for pertinent comments in source source! A Service Controller requires Administative privileges. It will attempt to access your access and depending on system set-up may prompt/warn you. YOU CONTINUE AT YOUR OWN RISK. This applications dives into Windows Shared, OWN AND Device services! It definately gives a different view to the whole set-up. You can bork your OS with A Service Controller!!!!! Say if you decide to shutdown/disable your "Kernel Streaming Thunks" or Intel Processor device drivers. It may not be able to do it, but it will try to force any process to shutdown. If its a shared or device driver service it will also attempt to disable the service. 
############################################

I don't claim to know what all the services are and/or do. And currently don't know what a Thunk is, but I will find out. Yes its actually a device driver running on my system!! The game is to 1- Create a Restore Point, 2 - Try to figure out what it takes for the bare minimum to run your system. How low can you get the memory? Below 10%, may be 9%??? I originally developed this app for going just that : Overclocking and Benchmarking, see http://hwbot.org/user/swarthack/

#Repository Architecture 
The current contents of the project are Visual Studio 2017 WinForms project directories and a single solution.Everything should work with 2015! As the intention is to include ANY tool, ANY technology. The respository architecture will have to changes. Basically adding base directories per technology/type: MS-WinForm;WebApps;.NET Core etc., then JAVA-Jdeveloper;NetBeans; etc..., then Nodejs- scripts/modules... etc. TODO

#Getting Started There is a set-up project and msi installer as part of the solution. The installer is very simlple, but does require .NET 4.6!!! I am not sure if there is anything that actually requires 4.6. But it should compile back to 3.5.1 I believe, just change the .NET target in your project.

TODO

Installation process
Software dependencies
Latest releases
API references
#Build and Test TODO

#Contribute TODO
