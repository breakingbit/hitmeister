$BuildFolder = $env:APPVEYOR_BUILD_FOLDER

$GHPagesFolder = "$BuildFolder\gh-pages"
$GHAccessToken = $env:GithubPersonalAccessToken
$GHUsername = $env:GithubUsername

Push-Location $BuildFolder

Write-Host "- Cloning gh-pages branch"
git clone --quiet --branch=gh-pages https://$($GHUsername):$($GHAccessToken)@github.com/$($env:APPVEYOR_REPO_NAME).git .\gh-pages\
Set-Location ".\gh-pages"

Write-Host "- Setting local git configuration"
git config --local core.autocrlf true
git config --local user.email $env:APPVEYOR_REPO_COMMIT_AUTHOR_EMAIL
git config --local user.name $GHUsername
git config --local push.default matching

git status

Write-Host "- Cleaning gh-pages folder"
Get-ChildItem -Attributes !r | Remove-Item -Recurse -Force

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