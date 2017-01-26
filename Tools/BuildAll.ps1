# Must be executed from the Tools folder

$msbuild = "C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe"

$nuget = ".\nuget.exe"

& $nuget restore "..\GameWork.Core.sln"
& $msbuild "..\GameWork.Core.sln"