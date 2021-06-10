#### Advantages
* Run containers without managing servers
* Increase agility with containers on demand
* Deploy containers to the cloud with unprecedented simplicity and speed—with a single command.
* Secure applications with hypervisor isolation
* Fastest Deployment and Boot Startup is very low than VM

#### Known limitation and Mitigation
* Data won't persist after restart. To mitigate this we need to use Persistent storage such has Azure File Share
* Need make sure small size images need to be choose during development for instance Alpine linux Image as base image
* Ingress Cost may apply will be applicable if we use other than Azure Container Registry(ACR). And storage cost for ACR
* Better use FQDN in DNS CNAME instead of public IP
* For DDOS Protection use Azure VNET Protection
* HTTPS(Certificate) is tricky based on container group we use
* Quotas are applicable https://docs.microsoft.com/en-us/azure/container-instances/container-instances-quotas
* Limited Scalability
