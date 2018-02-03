param([string]$buildFolder, [string]$email, [string]$username, [string]$personalAccessToken)

Write-Host "- Set config settings...."
git config --global user.email $email
git config --global user.name $username
git config --global push.default matching

Write-Host "- Clone gh-pages branch...."
Set-Location "$($buildFolder)\..\"
New-Item -ItemType Directory gh-pages
git clone --quiet --branch=gh-pages https://$($username):$($personalAccessToken)@github.com/breakingbit/hitmeister.git .\gh-pages\
Set-Location gh-pages
git status

Write-Host "- Clean gh-pages folder...."
Get-ChildItem -Attributes !r | Remove-Item -Recurse -Force

Write-Host "- Copy contents of static-site folder into gh-pages folder...."
Copy-Item -Path ..\static-site\* -Destination $pwd.Path -Recurse

git status
$thereAreChanges = git status | select-string -pattern "Changes not staged for commit:","Untracked files:" -simplematch
if ($thereAreChanges -ne $null) { 
    Write-host "- Committing changes to documentation..."
    git add --all
    git status
    git commit -m "CI Documentation Generation"
    git status
    Write-Host "- Push it...."
    git push --quiet
    Write-Host "- Pushed it good!"
} 
else { 
    Write-Host "- No changes to documentation to commit"
}