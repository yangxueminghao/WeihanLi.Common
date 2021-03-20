$versionPath=$PSScriptRoot+"/version.props"
$versionXml=([xml](Get-Content $versionPath))
$versionProperty=$versionXml.Project.PropertyGroup
$ReleaseVersion=$versionProperty.VersionMajor+"."+$versionProperty.VersionMinor+"."+$versionProperty.VersionPatch
$ReleaseVersion
Write-Output "ReleaseVersion=${ReleaseVersion}" >> $Env.GITHUB_ENV
Write-Output "ReleaseVersion1=${ReleaseVersion}" >> $Env.$GITHUB_ENV
Write-Output "ReleaseVersion2=${ReleaseVersion}" >> $GITHUB_ENV