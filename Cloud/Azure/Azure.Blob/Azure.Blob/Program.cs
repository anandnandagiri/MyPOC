//using Microsoft.WindowsAzure.Storage;
//using Microsoft.WindowsAzure.Storage.Blob;

using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;
using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Net;

namespace Azure.Blob
{
    class Program
    {
        static void Main1(string[] args)
        {

            string BlobName = string.Empty;
            string URL = string.Empty;
            string subFolderAzure = "Images";        

            CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse(ClassConstants.BlobConnection);
            CloudBlobClient cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();
            string strContainerName = "uploads";
            Console.WriteLine( cloudBlobClient.GetContainerReference(strContainerName).GetBlobReference(subFolderAzure + "/" + BlobName).Exists().ToString());

            //string pathPrefix = subFolderAzure + "/";
            //CloudBlobDirectory blobDirectory = cloudBlobContainer.GetDirectoryReference(pathPrefix);

            //CloudBlockBlob blockBlob = blobDirectory.GetBlockBlobReference(BlobName);
            //URL = blockBlob.StorageUri.PrimaryUri.AbsoluteUri;

            //byte[] data;
            //using (WebClient client = new WebClient())
            //{
            //    Uri uri = new Uri()
            //    data = client.DownloadData(URL);
            //}
            //File.WriteAllBytes(@"C:\Users\anand\Desktop\ananda.JPG", data);


            Console.WriteLine("Please press any key to exit...");
           Console.ReadKey();
        }


        public static bool BlobExistsOnCloud(CloudBlobClient client,
    string containerName, string key)
        {
            return client.GetContainerReference(containerName)
                         .GetBlockBlobReference(key)
                         .Exists();
        }
    }
}
