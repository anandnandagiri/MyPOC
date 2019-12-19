
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;
using System;
using System.IO;
using System.Linq;
using System.Collections;

namespace Azure.Blob
{
    class EditBlobProperties
    {
        static void Main(string[] args)
        {              
            CloudStorageAccount storageAccount;
            if( CloudStorageAccount.TryParse(ClassConstants.BlobConnection, out storageAccount))
            {
                var blobClient = storageAccount.CreateCloudBlobClient();
                var container = blobClient.GetContainerReference(ClassConstants.ContainerName);
                var blockBlob = container.ListBlobs(useFlatBlobListing: true).OfType<CloudBlockBlob>();

                foreach (var block in blockBlob)
                {
                    Console.WriteLine(block.Name);
                    //block.Properties.ContentType = "Images/Jpeg";
                    block.Properties.ContentType = "application/octet-stream";
                    block.SetPropertiesAsync();
                }
            }
            else
            {
                Console.WriteLine("Please check Azure Blob Storage Connection String");
            }
            Console.WriteLine("Please press any key to exit...");
           Console.ReadKey();
        }
    }
}
