```
string fileName = "Penguin.jpg";
string pathName = "1/Penguin.jpg";
CloudStorageAccount account = CloudStorageAccount.Parse("<your storage key>");
CloudBlobClient blobClient = account.CreateCloudBlobClient();
string strContainerName = "<your container name>";
CloudBlobContainer container = blobClient.GetContainerReference(strContainerName);
CloudBlob blob = container.GetBlobReference(pathName);
var memoryStream = new MemoryStream();
blob.DownloadToStream(memoryStream, null);
return File(memoryStream.ToArray(), "application/octet-stream", fileName);
```
