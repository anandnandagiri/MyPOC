 # ReadMe Docker Commands

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
docker run --name=<custom name> <image>
docker run -d <image>
docker run -d -p 4000:4000 <image>
docker run -it <image>
docker run -it -v <path of host>:<path of container> <image>
```

Docker Inspect
```	
docker Inspect <ContainerID or Name>
docker inspect --format='{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' cc
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
Docker stop all container and remove
```
docker stop $(docker ps -aq)
docker rm $(docker ps -aq)
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
