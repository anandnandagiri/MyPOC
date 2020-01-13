# GCP Start VM Using Cloud Functions

This application is ment for **restart** and **start** GCP VM using **cloud funtion**.\
**Note:** Reset function can be used but it is better to stop and start vm this will avoid certain issues.
\
\
This application built with NodeJS 8 and Package @google-cloud/compute
```console
npm install @google-cloud/compute --save
```
\
In order to use in Cloud function
* In GCP Console Create function
* Use Source code as Inline editor
* Runtime Nodejs 8
* copy text index.js from this git
* copy text package.json from this git
