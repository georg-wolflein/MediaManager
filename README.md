[MediaManager](http://georgw777.github.io/MediaManager/)
============

CD organization made easy. 

Click [here](#installing) for installation instructions. 


## About
MediaManager is an application, where you can enter in your CD and DVD information. You can print stickers with QR codes that you can attach to your CDs in order to always find them. The media database can be edited directly in the application or in Microsoft Office Excel. 


### CD/DVD Information
Currently, you can store the following information in the media database: 
- Media ID
- Name
- Volume number
- Volume name
- Number of CDs/DVDs (if it is a pack)
- Artist
- Location (if you have several shelves)
- Comments


## Installing
Please note that this application was programmed in Visual Basic and therefore only works on the Windows operating system. 


### Setup
If you want to do a full setup (install it on your computer) open [INSTALL](INSTALL) and execute [setup.exe](INSTALL/setup.exe). This will correctly install it on your machine. Alternatly, you can download `MediaManager-{latest-version}.zip` from the latest [release](../../releases). 


### Executable Only
If you do not want a full installation and just want to test it, navigate to [INSTALL/Application Files](INSTALL/Application Files) and open the latest version of MediaManager. Then, execute MediaManager.exe. Have fun! As mentioned above, you can download `MediaManager-{latest-version}.zip` from the latest [release](../../releases). 


### Problems
If you are encountering problems during the installation, it's probably because you did not download the whole [INSTALL](INSTALL) folder. The [setup.exe](INSTALL/setup.exe) file has to be able to access the [Application Files](INSTALL/Application Files) folder. 

Another problem might be that you cannot start the application. If this is the case, make sure that the DLL [Main.dll](Main.dll) is located in the same directory as GamingBot.exe. 


## To-Do List
- Add a "create default/sample media database function"
- Create an updater (as an external executable)
- Save settings without having to restart manually
- Add a restart feature


## Libraries
The following libraries were used in this project: 
- [QrCode.Net](http://qrcodenet.codeplex.com/): an easy-to-use QR code library for the .NET framework
- [Windows API Code Pack 1.1](http://archive.msdn.microsoft.com/WindowsAPICodePack): access to Windows functions like TaskDialogs, which are not possible through the .NET framework
- [Main.dll](MediaManager/libs/Main.dll): my own DLL for main application methods, ensuring consistent application behaviour


## Licence
This project is licensed under the [MIT License](http://opensource.org/licenses/MIT): 
```
Copyright (c) 2013 by Georg Wölflein

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
```
