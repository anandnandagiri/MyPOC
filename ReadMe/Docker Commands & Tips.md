 # ReadMe Docker Commands

Docker Install
```
sudo apt-get install docker.io
sudo docker version
sudo service docker start
```


Docker Common Commands	
```
docker version
docker Info
docker pull <Image>
docker push <Repo Image>
docker images -a
docker ps -a
```

Docker Login On GCP
```
export gaut=$(gcloud auth print-access-token)
docker login -u oauth2accesstoken -p $gaut https://gcr.io
```

Docker Run Commands With detach/Interaction/Port/Volume Mount	
```
docker run <image>
docker run --name=<container name> <image>
docker run -d <image>
docker run -d -p <host port>:<container port> <image>
docker run -it <image>
docker run -it -v <path of host>:<path of container> <image>
```

How to push local docker image to docker hub
```
docker login --username=<hub username>
docker build -t <tag name> build .
docker tag <image id> <hub username>/<repo name>
docket push <hub username>/<repo name>
```

Docker Inspect
```	
docker Inspect <ContainerID or Name>
docker inspect --format='{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' <ContainerID or Name>
docker logs <Images ID>
```
	
Docker Start/Stop	
```	
docker start <container name or ID>
docker stop <container name or ID> 
docker kill <container name or ID>	
```
		
Docker Remove Image or Container
```	
docker rm  <container name>
docker rmi <image name>
```	
Docker Build/Commit/Save as tar file/Load
```
docker build <path to docker file>
docker Commit <Container Name Or ID> <new image>
docker save -o <FileName>.tar <Image>
docker load -i <FileName>.tar
```
Docker Custom Network Bridge (ping by hostname)
```
docker network create --driver=bridge <custom network bridge name>
docker network rm  <custom network bridge name or network ID>
docker network ls
```

### Docker Tips
Docker Connect To Running container
```
docker exec -it <container name or ID> cmd 		/* For Windows Image*/
docker exec -it <container name or ID> /bin/bash	/* For ubuntu Image*/
docker exec -it <container name or ID> sh		/* For alpine Image*/
```
Docker Run In Interaction mode and once exit remove container
```
docker run -it --rm <Image> cmd
docker run -it --rm <Image> sh
```
Docker In Interaction mode, once exit remove container and override entrypoint
\
Most of the case this will used to debug broken container
```
docker run -it --rm  --entrypoint=cmd <Image>		/* For Windows Image*/
docker run -it --rm  --entrypoint=/bin/bash <Image>	/* For ubuntu Image*/
docker run -it --rm  --entrypoint=/bin/ash <Image> 	/* For alpine Image*/
```
Docker stop all container and remove
```
docker stop $(docker ps -aq)
docker rm $(docker ps -aq)
(or)
docker rm -f $(docker ps -aq)
```
Docker Remove All Images which are not running
```
docker image prune --all
docker rmi $(docker images --filter "dangling=true" -q --no-trunc)
```
Docker Copy From File From Image
```
docker cp <container name or ID>:<Source File>  <Destination File>
```
