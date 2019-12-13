#### VAapps 
# MyVault

This Project was Built On
* Angular CLI 8.3.14
* Docker Multistage Build
* Nginx 1.17

## Installed NPM Packages
```
npm install bootstrap jquery popper --save

npm install @fortawesome/fontawesome-svg-core --save
npm install @fortawesome/free-solid-svg-icons --save
npm install @fortawesome/angular-fontawesome --save

npm install ngx-device-detector --save

ng add @angular/pwa
```


## Add bootstrap to the angular.json
```
"styles": [
              "node_modules/bootstrap/dist/css/bootstrap.min.css",
              "src/styles.css"
            ],
```

## Features Added
App Version Info
 \
Device Info
 \
PWA

## Upgrade To Latest Version Angular
Upgrade all your dependencies and dev dependencies in package.json that includes typeScript,RxJS etc
```
npm install -g @angular/cli@latest
ng update @angular/cli
``` 

## Lessons Learned
* nginx.conf is modified to support PWA, mime type application/manifest+json  webmanifest;


## Most Used AngularCLI Commands
`ng serve --open`
 \
`ng build --prod`
 \
`ng test`
 \
`ng e2e`
 \
Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.
 \
To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI README](https://github.com/angular/angular-cli/blob/master/README.md).

