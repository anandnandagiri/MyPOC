

Step 1. This is for RaspberryPI compile option
dotnet publish -c Release -r  linux-musl-arm64 --self-contained false

Step 2. Copy Dockerfile
Please copy Dockerfile to ..\SQLite\SQLite\bin\Release\net6.0\linux-musl-arm64\publish

Step 3. Copy publish folder to Raspberry PI
copy completed folder ..\SQLite\SQLite\bin\Release\net6.0\linux-musl-arm64\publish to PI using pscp.exe or any other methods

Step 4. Docker Build
docker build -t sqlite .

Step 5. Docker run
docker run -it --name sqlite -p 80:80 --cpus .5 --cpu-shares 500 -e ASPNETCORE_ENVIRONMENT=PI sqlite

Step 6. Use Swagger UI to post data you will receive error

http://<your pi Ip>/swagger/index.html
eg: http://192.168.0.35/swagger/index.html




