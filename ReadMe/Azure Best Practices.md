#### There are many Best Practices in Azure this depends on certain factors like Security, Performance and Cost
Below are most common Best Practices
#### Security
*  Use Azure KeyVault Service and Avoid Hard Code Connection String in Applications
*  Use Azure Bastion Host Service for connecting Azure VM
*  Use L7 Load Balance (eg: Application Gateway) instead of L3/L4 Load Balancer which has inbuilt Web Application Firewall for public facing web applications 
*  First place to consider Azure VNET in Architectural Design, Enable DDOS Protection, use subnets and Plan IP addressing(CIDR Range)
*  Enable and Configure Application Security Group on Azure VM.
*  Enable HTTPS Only and Minimum TLS version 1.2 in Azure App Services (CORS if applicable)

  [More On Azure Documentation](https://docs.microsoft.com/en-us/azure/security/fundamentals/best-practices-and-patterns)
 	
#### Performance
*  Use L3/L4 Load Balancer for Web Service if hosted for internal VNET communication
*  Would Recommend Azure VM ScaleSet instead deploying multiple Azure VMs
*  Use VNET Peering for connecting Multiple Location by using Azure Backbone network infrastructure
*  Prefer Azure CDN for Static based Web Sites by deploying web pages to Azure Blob Storage
*  Consider Azure SQL Elastic Pool if you’re having multiple Azure SQL Database for unexpected spike and balance Azure resource utilization
*  Enable ARR (Application Request Routing) on Azure Load Balancer
	
 	
#### Cost Saving
*  Always Set Budget Cost Alert on Azure Subscription better with atleast three stage eg: 40%,70%,90%
*  Use Azure Reservations where ever applicable for long run
*  Use Tag on Azure Resource to differentiate cost based on departments or operational group for better visibility
*  Azure VM
    * Use Azure Hybrid Benefit for using existing Windows Server License (This will save upto 49% cost benefit)
    * Use Non INTEL Processor(eg: AMD) based VM for Non - Production
    * Configure Auto Shutdown on Developer Machines
		
#### General
*  Recommended to use different Azure Subscription for Production Environment rather than Azure Resource Group
*  Always Maintain 3 Deployment Slots in Azure App Service 
	*  Slot 1:  Last Well Known Release
	*  Slot 2:  Stage 
	*  Slot 3:  Production
	


