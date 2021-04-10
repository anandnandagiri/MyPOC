#### Google Dynamic DNS
This will have security issues since URL include username and password
```
curl https://<username>:<password>@domains.google.com/nic/update?hostname=<domain>&myip=<Public IP>
```


#### Raspberry PI Configure Headless
This help connect using putty remotely without keyboard/monitor only power cable will be connected. Follow below setup
* Assuming Raspberry PI already working as expected
* Power Off Rasberry PI and Remove SSD
* Attach this SSD to computer
* create ssh file on Raspberry boot image drive
* create file wpa_supplicant.conf with below content
```
country=US
ctrl_interface=DIR=/var/run/wpa_supplicant GROUP=netdev
update_config=1

network={
    ssid="NETWORK-NAME"
    psk="NETWORK-PASSWORD"
}
```



#### Raspberry PI Host NGINX with Docker
```
docker run --rm --name mynginx -p 80:80 arm32v7/nginx 
```

#### Raspberry PI Connect using putty
```
putty.exe <username>@<Host Name or IP> -pw <password>
```
