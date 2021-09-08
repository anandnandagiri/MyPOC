## This will be helpfull when you debug with chrome 
Nice URL for List of Chromium Command Line Switches [Click Here](https://peter.sh/experiments/chromium-command-line-switches)

#### Chrome Installation Path
```
C:\Program Files\Google\Chrome\Application
C:\Program Files (x86)\Google\Chrome\Application
```

#### Below command will list all the chrome commands
chrome://about/

#### Below are most used
chrome://version \
chrome://settings \
chrome://downloads \
chrome://flags \
chrome://ntp-tiles-internals \
chrome://net-internals/#dns

#### Run Chrome With Disable Security
Note: 
1. It is for better security isolation for running chrome, you Create folder MyChromeSession in c:\ and use it chrome parameter args
2. Open CMD and change directory to Chrome installation path which mentioned above to execute below command
```
chrome.exe  --disable-site-isolation-trials --disable-web-security --user-data-dir="C:\MyChromeSession"
```
