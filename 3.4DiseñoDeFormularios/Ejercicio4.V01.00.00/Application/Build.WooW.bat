REM descomentar esta esta linea para arquitectura amd64
set msBuildDir=C:\Program Files\Microsoft Visual Studio\2022\Community\Msbuild\Current\Bin\amd64

REM descomentar esta esta linea para arquitectura arm64
REM set msBuildDir=C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\arm64

SET WORKDIR=%~2
SET APPDIR=%~3

%1
cd "%WORKDIR%" 

del "Resources\Labels\WooW_Label.Designer.cs" 
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\resgen.exe" "Resources\Labels\WooW_Label.resx" /str:cs,WooW.Resources.Labels /publicclass
copy "Resources\Labels\WooW_Label.cs" "Resources\Labels\WooW_Label.Designer.cs"
del "Resources\Labels\WooW_Label.cs" 

del "Resources\Messages\WooW_Message.Designer.cs" 
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\resgen.exe" "Resources\Messages\WooW_Message.resx" /str:cs,WooW.Resources.Messages /publicclass
copy "Resources\Messages\WooW_Message.cs" "Resources\Messages\WooW_Message.Designer.cs"
del "Resources\Messages\WooW_Message.cs" 

del "Resources\Messages\WooW_Comment.Designer.cs" 
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\resgen.exe" "Resources\Comments\WooW_Comment.resx" /str:cs,WooW.Resources.Comments /publicclass
copy "Resources\Comments\WooW_Comment.cs" "Resources\Comments\WooW_Comment.Designer.cs"
del "Resources\Comments\WooW_Comment.cs" 

del "Resources\ModelData\WooW_ModelData.Designer.cs" 
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\resgen.exe" "Resources\ModelData\WooW_ModelData.resx" /str:cs,WooW.Resources.ModelData /publicclass
copy "Resources\ModelData\WooW_ModelData.cs" "Resources\ModelData\WooW_ModelData.Designer.cs"
del "Resources\ModelData\WooW_ModelData.cs"

del "Resources\ModelComment\WooW_ModelComment.Designer.cs" 
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\resgen.exe" "Resources\ModelComment\WooW_ModelComment.resx" /str:cs,WooW.Resources.ModelComment /publicclass
copy "Resources\ModelComment\WooW_ModelComment.cs" "Resources\ModelComment\WooW_ModelComment.Designer.cs"
del "Resources\ModelComment\WooW_ModelComment.cs"

del "Resources\ModelLabel\WooW_ModelLabel.Designer.cs" 
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\resgen.exe" "Resources\ModelLabel\WooW_ModelLabel.resx" /str:cs,WooW.Resources.ModelLabel /publicclass
copy "Resources\ModelLabel\WooW_ModelLabel.cs" "Resources\ModelLabel\WooW_ModelLabel.Designer.cs"
del "Resources\ModelLabel\WooW_ModelLabel.cs" 


cd "%WORKDIR%\WebService"
call "%msBuildDir%\msbuild.exe" WooW.WebService.sln /p:Configuration=Debug /t:Restore;Build -v:m -flp1:FileLogger,Microsoft.Build.Engine;errorsonly;logfile="%WORKDIR%\WebService\WooW.WebService.Errors.Log" 

cd "%WORKDIR%\WebClient"
call "%msBuildDir%\msbuild.exe" WooW.WebClient.sln /p:Configuration=Debug /t:Restore;Build -v:m -flp1:FileLogger,Microsoft.Build.Engine;errorsonly;logfile="%WORKDIR%\WebClient\WooW.WebClient.Errors.Log" 


set msBuildDir=


rem Copia a pruebas unitarias
copy "%WORKDIR%\WebClient\WooW.WebClient\bin\Debug\net8.0\*.dll" "%WORKDIR%\UnitTest\WooW.UnitTest\WooW.UnitTest\bin\Debug\net8.0"

rem Copia a WooW.SB

copy "%WORKDIR%\WebClient\WooW.WebClient\bin\Debug\net8.0\*.dll" "%APPDIR%"
copy "%WORKDIR%\WebService\WooW.Server\bin\Debug\net8.0\*.dll" "%APPDIR%"

