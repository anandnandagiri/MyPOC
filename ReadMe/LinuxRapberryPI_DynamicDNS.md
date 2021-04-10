#### Google Dynamic DNS
This will have security issues since URL include username and password
```
curl https://<username>:<password>@domains.google.com/nic/update?hostname=<domain>&myip=<Public IP>
```

#### Raspberry PI Host NGINX with Docker
```
docker run --rm --name mynginx -p 80:80 arm32v7/nginx 
```

#### Raspberry PI Connect using putty
```
putty.exe <username>@<Host Name or IP> -pw <password>
```
