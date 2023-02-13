@echo off
cd /d %~dp0
start "" "C:\Program Files (x86)\Microsoft Visual Studio\2021\Community\Common7\IDE\devenv.exe" MainForm.cs /run
pause
