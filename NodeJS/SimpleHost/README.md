#### SimpleHost
This for hosting small scale vm to test on Cloud
```
node server.js
docker build -t nodepoc .
docker run -p 8000:8080 nodepoc
```

Available On Docker HUB
```
docker pull anandnandagiri/simplehost
docker run --name ansh -d -p 8080:8080 anandnandagiri/simplehost
```
