# clean-vssolution.ps1
#
# Cleans Visual Studio Solution folder
# removing .suo, .user, build and obj folders

# Param ($folder = ".")


$folders = @("Commande")

$include = @("*.suo", "*.user", "*.cache", "bin", "obj", "build")
$exclude = @()

foreach ($folder in $folders) {
    $folder = $PSScriptRoot + "\" + $folder 
    write-host "Folder : $($folder)" -foregroundcolor "magenta"
    
    if ($folder -ne "")
    {
	    Get-ChildItem $folder -Recurse -Force -Include $include -Exclude $exclude | % {
		    Remove-Item $_.FullName -Force -Recurse -ErrorAction SilentlyContinue
	    }
    }
    else
    {
	    Write-Error "Syntax: clean-vssolution <directory>";
    }
}