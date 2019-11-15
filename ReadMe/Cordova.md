
# Cordova

### Prerequisite
NodeJS & Android SDK
```
npm install -g cordova
npm install -g cordova-simulate
```
Install android SDK
```
%userprofile%\.android
```

Register Path variable with below
```
%userprofile%\AppData\Roaming\npm
%userprofile%
```
Create New Cordova Project with geolocation plugin
```
cordova create tracker com.vaapps.tracker tracker
cd tracker
cordova plugin add cordova-plugin-geolocation --save
cordova platform add android --save
simulate android --target=chrome
```
Additional Cordova Plugin
```
cordova platform add browser
cordova run browser
cordova platform remove browser

cordova plugin add cordova-plugin-browsersync
cordova run -- --live-reload

cordova plugin add cordova-plugin-camera --save
cordova plugin remove  cordova-plugin-camera
```
\
APK File Generated Location
```
..\platforms\android\app\build\outputs\apk\debug\app-debug.apk
```
