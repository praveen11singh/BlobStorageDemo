using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using System;

namespace BlobStorageDemo
{
    public static class ConnectionString
    {
        static string account = CloudConfigurationManager.GetSetting("arena11storage");
        static string key = CloudConfigurationManager.GetSetting("jV1YbiOkX06nmDyNkyJvl5raNMeGa+URoQc+g7BaY5CAMv4gRWer5hwhgvjrI/8VhuSgCtZvRiTekjqFZWxv1Q==");

        public static CloudStorageAccount GetConnectionString()
        {
            string connectionString = string.Format(@"DefaultEndpointsProtocol=https;AccountName=arena11storage;AccountKey=jV1YbiOkX06nmDyNkyJvl5raNMeGa+URoQc+g7BaY5CAMv4gRWer5hwhgvjrI/8VhuSgCtZvRiTekjqFZWxv1Q==;EndpointSuffix=core.windows.net");
            return CloudStorageAccount.Parse(connectionString);
        }
    }
}