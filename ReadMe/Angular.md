Angular CLI Command
```
npm install -g @angular/cli@latest 
ng version
```
Create New Project
```
ng new <ProjectName>
```
To add node_modules, Run or Build
```
npm install 
ng server
ng build --prod --aot          //To Build Under Prod and AOT
```
Create Component
```
ng g c orders --spec=false -s
ng g c orders/order --spec=false -s
ng g c orders/order-items --spec=false -s
```
Create Services
```
ng g s shared/order --spec=false
ng g s shared/customer --spec=false
```
Create Model
```
ng g m shared/customer --type=model
```
Install Bootstrap Related
```
npm install --save ng-showdown
npm install --save @ng-bootstrap/ng-bootstrap
npm install bootstrap@4.3.1
```
#### Angular Cli WebLinks

https://angular.io/guide/releases \
https://www.npmjs.com/package/@angular/cli \
https://github.com/angular/angular-cli

