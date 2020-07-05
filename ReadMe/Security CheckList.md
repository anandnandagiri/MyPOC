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
    * Implment CSP (Content-Security-Policy)
    * Implement Role Based Authentication
    * Implement User Account Lock After 3 invalid attempts to avoid Brute force/Dictionary attack
    * Implement Captcha for Open Forms
    * In some case use Server.Transfer instead of Response.Redirect to avoid session hijack when your using session ID in request query string (This will be performance issue but security is priority)
    * File Upload Case: Best approach is rename file name to GUID without extension, save map info GUID with file name in DB to retrieve later. In this approach we can avoid certain File Inclusion attack
    * Avoid cache for secure data

* #### Security Monitor/Log
    * Every Login and invalid login attempt will be captured in web application along with Client Public IP
    * Every File Upload and download will be captured in web application along with Client Public IP
    * Log All Global Exception to capture any miscellaneous activities on web.