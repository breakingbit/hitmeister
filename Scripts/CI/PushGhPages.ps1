$BuildFolder = $env:APPVEYOR_BUILD_FOLDER
$BranchName = $env:APPVEYOR_REPO_BRANCH

$GHPagesFolder = "$BuildFolder\gh-pages\$BranchName\"
$GHAccessToken = $env:GithubPersonalAccessToken
$GHUsername = $env:GithubUsername

Push-Location $BuildFolder

Write-Host "- Cloning gh-pages branch"
git clone --quiet --branch=gh-pages https://$($GHUsername):$($GHAccessToken)@github.com/$($env:APPVEYOR_REPO_NAME).git .\gh-pages\
Set-Location ".\gh-pages"

Write-Host "- Setting global git configuration"
git config --global core.autocrlf true
git config --global user.email $env:APPVEYOR_REPO_COMMIT_AUTHOR_EMAIL
git config --global user.name $GHUsername
git config --global push.default matching

git status

If(Test-Path -Path ".\$BranchName")
{
    Write-Host "- Deleting existing branch folder"
    Remove-Item -Recurse -Force ".\$BranchName"
}
Write-Host "- Creating empty branch folder"
New-Item -ItemType Directory -Force -Path ".\$BranchName"

Pop-Location

Write-Host "- Copying documentation"
Copy-Item -Path .\Documentation\_site\* -Destination $GHPagesFolder -Recurse

Push-Location $GHPagesFolder

$hasPendingChanges = git status | select-string -pattern "Changes not staged for commit:","Untracked files:" -simplematch
if ($hasPendingChanges -ne $null) { 
    Write-host "- Committing changes"
    git add --all
    git status
    git commit -m "CI Documentation Generation ($($env:APPVEYOR_REPO_COMMIT))"
    git status
    Write-Host "- Pushing changes"
    git push --quiet
} 
else { 
    Write-Host "- No changes to commit"
}

Pop-Location