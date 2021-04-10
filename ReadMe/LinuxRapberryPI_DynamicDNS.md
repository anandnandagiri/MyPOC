#### Google Dynamic DNS
This will have security issues since URL include username and password
```
curl https://<username>:<password>@domains.google.com/nic/update?hostname=<domain>&myip=<Public IP>
```


#### Raspberry PI Configure Headless
This help connect using putty remotely without keyboard/monitor only power cable will be connected. Follow below setup
* Assuming Raspberry PI already working as expected
* Power Off Rasberry PI and Remove SSD
* In SSD
* create ssh file on Raspberry



#### Raspberry PI Host NGINX with Docker
```
docker run --rm --name mynginx -p 80:80 arm32v7/nginx 
```

#### Raspberry PI Connect using putty
```
putty.exe <username>@<Host Name or IP> -pw <password>
```
