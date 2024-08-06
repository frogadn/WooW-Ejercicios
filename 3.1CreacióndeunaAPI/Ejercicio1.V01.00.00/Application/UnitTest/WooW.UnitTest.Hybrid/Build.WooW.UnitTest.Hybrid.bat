REM you'll have to find the "latest" version of where msbuild.exe resides on your machine.. here are some popular versions/locations
REM set msBuildDir=%WINDIR%\Microsoft.NET\Framework\v2.0.50727
REM set msBuildDir=%WINDIR%\Microsoft.NET\Framework\v3.5
REM set msBuildDir=%WINDIR%\Microsoft.NET\Framework\v4.0.30319
REM set msBuildDir=C:\Program Files (x86)\MSBuild\12.0\Bin

REM descomentar esta esta linea para arquitectura amd64
set msBuildDir=C:\Program Files\Microsoft Visual Studio\2022\Community\Msbuild\Current\Bin\amd64


REM descomentar esta esta linea para arquitectura arm64
REM set msBuildDir=C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\arm64


call "%msBuildDir%\msbuild.exe" WooW.UnitTest.Hybrid.sln /p:Configuration=Debug -v:m -flp1:FileLogger,Microsoft.Build.Engine;errorsonly;logfile="WooW.Errors.Log" 

set msBuildDir=