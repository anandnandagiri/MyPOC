
#### Method 1: Own Proxy Server using free VM t2.micro

	Create a free VM with proxy enabled	
		Select Free Amazon Machine Image(AMI): Ubuntu Server 18.04 LTS (HVM), SSD Volume Type
		Select Instance Type: t2.micro
		Select Location: us-east-1,us-east-2,us-west-1,us-west-2,eu-central-1,eu-west-1,eu-west-2,eu-west-3,eu-south-1,sa-east-1

	Install Squid Proxy Server and Configure to use
		sudo -s
		apt update && apt upgrade
		apt install squid	
		cd /etc/squid
		cp squid.conf squid.conf.bak
		rm -rf squid.conf
		nano squid.conf
			http_access allow all
			http_port 6798
		systemctl restart squid
			
	Note: Make Sure your VM Security Outbound and Inbound are open for port 6798	
			
	
#### Method 2: Use TOR Service

	tor.exe –service install
	
	tor.exe --service install -options -f "torrc"
	tor.exe --service start
	tor.exe --service stop
	
	Note: 
	1. Tor Support SOCK 9050. Change Proxy Setting from Control Panel > Internet Option > Connection > Lan Setting
	2. Tor Service Change IP for every 10 Minutes
	3. Page Load Will Be slow & Few Sites Block with Captcha
	
	More info
	https://deepdarkweb.github.io/how-to-install-tor-on-windows-without-the-tor-browser-running-tutorial/
	https://miloserdov.org/?p=2062
	https://miloserdov.org/?p=1839
	

#### Method 3: Get Free Proxy List https://hidemy.name/en/proxy-list/
	
	While Getting list of Free Proxy Provider List ---> Proxy IP & Port
		Proxy Speed : <800ms
		Proxy Type : http,https, Socks 4, Socks 5
		Anonymity : High
		
