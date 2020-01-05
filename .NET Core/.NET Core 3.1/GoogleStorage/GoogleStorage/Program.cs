using Google.Cloud.Storage.V1;
using System;
using System.IO;
using System.Reflection;

namespace GoogleStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            string exepath = Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath);
            string jsonpath = Path.Combine(exepath, "disco-bedrock-238412-18955f7057ef.json");
            string projectID = "disco-bedrock-238412";

            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", jsonpath);
            Console.WriteLine(Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS"));
            Console.WriteLine("Storage List");

            var storage = StorageClient.Create();


            string downloadpath = exepath + @"\downloads\";
            Directory.CreateDirectory(downloadpath);
            foreach (var bucket in storage.ListBuckets(projectID))
            {                                                 

                if (!bucket.Name.ToLower().Contains("artifacts"))
                {
                    string bucketpath = downloadpath + bucket.Name ;
                    Directory.CreateDirectory(bucketpath);
                    Console.WriteLine("");
                    Console.WriteLine(bucket.Name);
                    string storageobjpath = bucketpath;
                    foreach (var storageObject in storage.ListObjects(bucket.Name, ""))
                    {
                        //Console.WriteLine("StorageObject {0}", storageObject);
                        //GenerateSignedUrl(bucket.Name, storageObject.Name);

                        string file = Path.GetFileName(storageObject.Name);
                        if (!string.IsNullOrEmpty(file))
                        {

                            string fileName = bucketpath + @"\" + storageObject.Name.Replace('/', '\\');
                            string dirName = Path.GetDirectoryName(fileName);
                            Directory.CreateDirectory(dirName);
                            Console.WriteLine($"{fileName}");
                            using (var outputFile = File.OpenWrite(fileName))
                            {
                                storage.DownloadObject(bucket.Name, storageObject.Name, outputFile);
                            }
                            //Console.WriteLine($"{Path.GetFileName(storageObject.Name)}  -> {dirName}");
                        }
                        else
                        {
                            Directory.CreateDirectory(bucketpath + @"\" + storageObject.Name + @"\");
                            storageobjpath = bucketpath + @"\" + storageObject.Name + @"\";
                        }
                    }
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("Press Any Key To Exit....");
            Console.ReadKey();
        }

        private void DownloadObject(StorageClient storage,string bucketName, string objectName, string localPath = null)
        {                                             
            localPath = localPath ?? Path.GetFileName(objectName);
            using (var outputFile = File.OpenWrite(localPath))
            {
                storage.DownloadObject(bucketName, objectName, outputFile);
            }
            Console.WriteLine($"downloaded {objectName} to {localPath}.");
        }

        private static void GenerateSignedUrl(string bucketName, string objectName)
        {
            UrlSigner urlSigner = UrlSigner.FromServiceAccountPath(Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS"));
            string url = urlSigner.Sign(bucketName, objectName, TimeSpan.FromHours(1), null);
            Console.WriteLine(url);
        }
    }
}
