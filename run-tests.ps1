param(
    [string] $location
)

if(!$location){
    $location = $PSScriptRoot;
}

Invoke-Expression -Command "${location}\packages\NUnit.Console.3.0.0\tools\nunit3-console.exe Seleniflow\bin\Debug\Seleniflow.dll"