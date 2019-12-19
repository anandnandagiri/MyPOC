using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Blob
{
    public static class ClassConstants
    {
        public static string Account = "your account";
        public static string AccountKey = "your key";
        public static string BlobConnection = $"DefaultEndpointsProtocol=https;AccountName={Account};AccountKey={AccountKey};EndpointSuffix=core.windows.net";
        public static string ContainerName = "uploads";
    }
}
