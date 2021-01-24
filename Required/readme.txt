-------------------------------------------------------------------------------
-----------H----H--X----X-----CCCCC-----22222----0000-----0000-----11----------
----------H----H----X-X-----C--------------2---0----0---0----0---1-1-----------
---------HHHHHH-----X------C----------22222---0----0---0----0-----1------------
--------H----H----X--X----C----------2-------0----0---0----0-----1-------------
-------H----H---X-----X---CCCCC-----22222----0000-----0000----11111------------
-------------------------------------------------------------------------------
-- Contact: hxc2001<at>hxc2001.com ---------------------- http://hxc2001.com --
-------------------------------------------------------------------------------
HxC Floppy Emulator project
(c) 2006-2017 Jean-François DEL NERO / (c) HxC2001
-------------------------------------------------------------------------------

Windows version of the HxC Floppy Emulator manager.

Command line :

HXCFEMNG.exe -help to get the command line options

Options:
  -help                                 : This help
  -verbose                              : Verbose mode
  -disk:[path]                          : Path to the drive to mount
  -getslots:[filename.txt]              : Get the slot list
  -setslots:[filename.txt]              : Set the slot list
  -fixslots                             : Fix the bad slot(s)
  -populateslots                        : Scan all supported file and auto add them into the slots
  -clearslots                           : Clear the slots
  -cortex 				: Cortex Firmware mode

Examples :

(F: is your SD / USB stick)

Get all my current slot setting into mylist.txt

HXCFEMNG.exe -disk:F:  -getslots:mylist.txt

Set mylist.txt slot setting into the cfg file

HXCFEMNG.exe -disk:F:  -setslots:mylist.txt


Note 1:
Since the software do raw access to the SD/USB Stick, the executable can't be launched from these drive.
Depending of your setup, you may need to start the software in administrator mode.

Note 2:
The Linux version is available on github :

https://github.com/jfdelnero/HXCFE_file_selector

Checkout the repository and do a make into the sdl subfolder.

Jeff / HxC2001
26/12/2016
