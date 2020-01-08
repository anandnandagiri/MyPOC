# ReadMe Git Commands

Clone Git to your local
```
git clone https://github.com/anandnandagiri/MyPOC.git
```

Get Git Help On Commands
```
git -help
git clone -help
```


Add All Files for check-in
```
git add -A
git add .
git add -u
```

Undo Files
```
git checkout -- <file>
```

Commit Locally
```
git commit -m "Initial Check IN"
```

Push to GitHub
```
git push --all
```

Pull latest code from GitHub
```
git pull
```

Private Repository to add/set-url remote or clone
```
git remote add <some remote name> https://<USERNAME>:<PASSWORD>@github.com/anandnandagiri/MyPOC.git
git remote set-url <some remote name> https://<USERNAME>:<PASSWORD>@github.com/anandnandagiri/MyPOC.git

git clone https://<USERNAME>:<PASSWORD>@github.com/anandnandagiri/MyPOC.git
```
#### Note 
If you have trouble or special character in username or password better uninstall creditial-manager and install above command won't work.  Also to remove remote use below command
```
git credential-manager uninstall
git credential-manager install

git remote rm <given remote name>
```
## Troubleshoot

remote: Repository not found.
```
git remote rm origin
git remote add origin  https://USERNAME:PASSWORD@github.com/username/reponame.git
```
Above didn't Solved
Goto Control Panel\All Control Panel Items\Credential Manager clear all the credential stored

 \
Add Git Ignore File(On Windows OS)
   * Create file ignore.txt
   * **Open command prompt** 
   * execute command
        ```
        ren ignore.txt .gitignore
        ```
