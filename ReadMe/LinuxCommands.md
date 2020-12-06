	ls
	ls myfile.exe
	ls -R
	ls -lt
	ls -a
	ls -a -h					#Show all hidden folders and files
	ll							#more info like dir
	nano						#Edit
	cat 						#Type
	cd 
	mkdir
	hostname
	whoami
	ls -al dotnet
	pwd
	ll | more
	popd	
	which
	usermode


Remove ALL Sub Folder forcefully
--------------------------------
	sudo rm -rf dotnet


Find Version
--------------------------
	lsb_release -a
	uname -r
	arch

First Command Once Installed
--------------------------------------------
	sudo apt-get update && sudo apt-get upgrade
	sudp apt-get dist-update //Not Every Time we need to use this. This will remove old and update with new version 

	
Second Add User Commands
--------------------------------------
	sudo usermod -aG sudo $USER    (adding user to sudo group)
	sudo chown $USER:sudo /root -R (adding user to access permission for files) 
	or
	sudo chown -R $USER:$USER /var/www/example.com/public_html

	sudo usermod -aG docker $USER (This will add user to run docker in sudo mode)

	Don't want sudo every time use command sudo -s

	
#### Create Batch File
```
nano myfirstbatch.sh
add below code
	#!/bin/bash 
	echo "Hello World!"
Make file executable
	chmod +x runme.sh
Run the file from terminal:
	./runme.sh
```

#### Install/Unintall Commands
```
sudo apt-get purge packagename
sudo apt-get remove packagename
sudo apt-get autoremove
sudo aptitude remove packagename (Orphand packages)


cat /lib/systemd/system/nginx.service

sudo systemctl status nginx
sudo systemctl restart nginx
sudo systemctl enable nginx
/etc/nginx/sites-available/
```

#### Copy MyWebSite to ReadOnly Place
```
sudo cp -a . /var/mywebsite/
```
#### Copy MyWebSite to ReadOnly Place Recursivelly
```
sudo cp -r . /var/www/html	
```
#### Create MyWebSite
```
sudo cd /lib/systemd/system/
sudo pico mywebsite.service

sudo systemctl daemon-reload
sudo systemctl start mywebsite
sudo systemctl enable mywebsite
```
#### CPU Info
```
cat /proc/cpuinfo
```

#### If you just want the cpu load to continue until you press Ctrl-C:
```
seq 3 | xargs -P0 -n1 md5sum /dev/zero
```
#### Cron JOBs
```
crontab -e
	SHELL=/bin/bash
	PATH=/bin:/sbin:/usr/bin:/usr/sbin:/usr/local/bin:/usr/local/sbin:/home/myfolder
	* * * * * /home/myfolder/cronjob.sh
	* * * * * /bin/echo "cron works" >> /tmp/file
cat /etc/crontab
```
#### Cron JOBS TroubleShoot
```
ps ax | grep cron
pgrep cron
sudo /etc/init.d/cron start
sudo service cron restart
```
