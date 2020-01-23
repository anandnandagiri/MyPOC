
#### Install Python Packages
%userprofile%/AppData/Local/Programs/Python/Python37-32
```
python.exe -m pip install -U pylint --user
python.exe -m pip install --upgrade pip
pip install pywin32
```

#### Usage
In libglobalvariables.py set proxy values
```
PROXY = "http://pac.zscaler.net/xyz.com/xyz.pac"
```

### How To Run

```
python.exe proxy ON
python.exe proxy OFF
```