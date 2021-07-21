
#### Display All Subscription with SubscriptionID
```
az account list --output table
az account subscription list --query "[].[displayName]" --out tsv
```

#### Display All App Services in By Specifying Subscription
```
az resource list --subscription <your subscription> --query "[?type=='Microsoft.Web/sites' || type=='Microsoft.Logic/workflows'].[name,kind,type,resourceGroup,location]" --out tsv
```

#### Set Subscription to default
```
az account set --subscription <Your Subscription Name>
```

#### Display All App Services or Logic Apps in Default Subscription
```
az resource list --query "[].[name,kind,type,resourceGroup,location]" --out tsv
az resource list --query "[?type=='Microsoft.Web/sites' || type=='Microsoft.Logic/workflows']" --out tsv
az resource list --query "[?type=='Microsoft.Web/sites' || type=='Microsoft.Logic/workflows'].[name,kind,type,resourceGroup,location,status]" --out tsv
az resource list --query "[?type=='Microsoft.Web/sites' || type=='Microsoft.Logic/workflows']"
```

#### Display App Services Running/Stop Status
```
az resource show --resource-group "<Your Resource Group Name>"   --name "<Your Resource Name>" --resource-type "Microsoft.Web/sites"
az resource show -g "<Your Resource Group Name>"   -n "<Your Resource Name>" --resource-type "Microsoft.Web/sites" --query "[name,properties.state]" -o tsv
```

#### Display Roles Default Subscription
```
az role assignment list --query "[].[principalName,principalType,roleDefinitionName,id]" -o tsv
```

#### Display Registered Resource Provider Default Subscription
```
az provider list --query "[?registrationState=='Registered'].[namespace,registrationPolicy,registrationState]" -o tsv
az provider list --query "[?contains(registrationState, 'Registered')].[namespace,registrationPolicy,registrationState]" -o tsv
```

#### Most Common Resource Types
```
Microsoft.Compute/virtualMachines
Microsoft.Compute/availabilitySets
Microsoft.Web/sites
Microsoft.Web/sites/slots
Microsoft.Storage/storageAccounts
Microsoft.ClassicStorage/storageAccounts
Microsoft.Sql/servers/databases
Microsoft.Sql/servers/elasticpools
Microsoft.Logic/workflows
Microsoft.Network/publicIPAddresses
Microsoft.Network/networkInterfaces
Microsoft.Network/networkSecurityGroups
Microsoft.Network/loadBalancers
Microsoft.Network/networkWatchers
Microsoft.Cache/Redis
Microsoft.RecoveryServices/vaults
microsoft.insights/activityLogAlerts
microsoft.insights/components
```
