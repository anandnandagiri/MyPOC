#### NMAP (Network Mapper)

Most Used Commands
```
nmap --script-updatedb
nmap 192.168.1.10
nmap -sV 192.168.1.10
```

#### NSE NMAP Script Enginee

NSE Script Categories
* Auth
* Brute
* Discovery
* DOS
* Exploit
* Fuzzer
* Malware

Path /usr/share/nmap/scripts

Most Used Commands
```
nmap --script banner 192.168.1.10
nmap --script http-headers 192.168.1.10
nmap --script http-enum 192.168.1.10
nmap -sV --script ssl-enum-ciphers -p 443 192.168.1.10
nmap --script dns-brute 192.168.1.10
```


