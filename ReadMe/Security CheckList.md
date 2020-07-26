# Security checklist while deploying Web Applications
* #### HTTP Header
    * Add X-FRAME-OPTIONS DENY
    * Add X-Content-Type-Options NOSNIFF
    * Add X-XSS-Protection 1; mode=block
    * Remove X-Powered-By
    * Remove Server Name and Version

* #### Enable HSTS
* #### Secure Cookie with HTTP Only
```
 Application will be using HTTP Only cookies
```
* #### Enable CORS at IIS level
```
Note: If using reverse proxy implement CORS policy in Web Application
```
* #### IIS Application Pool
    * Isolate Application Pool for web apps
    * Application pool should be provided with Low privilege
    
* #### NFTS File Privilege
     * Application will deployed as read only and provide IIS account with proper privileges on NTFS

* #### Disable Web Application Debugging

* #### Disable Directory Browsing 

* #### Firewall
    * Deny All Outbound Request
    * Allow Only 443 Inbound Request
    * Enable DDOS Protection
```
Note: Some firewalls you may need to enable outbound for 443 for response 
```
* #### Avoid Search Engine Crawl with robot.txt 
* #### Web Application
    * Encrypt all DB Connection String or Use Azure Key Vault
    * Implement XSS & CSRF
    * Implement CSP (Content-Security-Policy)
    * Implement Role Based Authentication
    * Implement User Account Lock After 3 invalid attempts to avoid Brute force/Dictionary attack
    * Implement Captcha for Open Forms
    * In some case use Server.Transfer instead of Response.Redirect to avoid session hijack when your using session ID in request query string (This will be performance issue but security is priority)
    * File Upload Case: Best approach is rename file name to GUID without extension, save map info GUID with file name in DB to retrieve later. In this approach we can avoid certain File Inclusion attack
    * Avoid SQL Injection using store procedure or Entity Framework
    * Avoid cache for secure data
* #### Server Configuration
    * Disable all Less than TLS 1.2
    * Web Server Internal IP Address/Internal Network Name Disclosure Vulnerability
* #### Security Monitor/Log
    * Every Login and invalid login attempt will be captured in web application along with Client Public IP
    * Every File Upload and download will be captured in web application along with Client Public IP
    * Log All Global Exception to capture any miscellaneous activities on web.
    
* #### Implement Security Process
	* Certificate Renewal Every 3 Months (Lets Encrypt)
	* Password
		* Password Change Every 3 Months
		* Allow Password With Strong Password
		* Don't Implement Default Password Concepts
      
* #### Other Reference
    * [ASP.NET Security Web.config](https://github.com/anandnandagiri/MyPOC/blob/master/ReadMe/Security%20ASP.NET%20Web.config.md)
    
