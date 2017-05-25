# Must be executed from the Tools folder

$devenv = "C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\devenv"

$nuget = ".\nuget.exe"

& $nuget restore "..\GameWork.Core.sln"
& $devenv "..\GameWork.Core.sln" /build