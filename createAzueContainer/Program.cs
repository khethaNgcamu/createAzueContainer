using Azure.Storage.Blobs;

namespace createAzueContainer
{
    internal class Program
    {
        private static string containerName = "music-container";
        private static string connectionString = "DefaultEndpointsProtocol=https;AccountName=ngcamustorage;AccountKey=0+12n5JiyaMKIZnDTj1ABDuiskBnZIKxjVlyVD6IfN69Tc46Z99NCiD8UXYwWdsCiGXNvNYXDINY+ASt3KDeuA==;EndpointSuffix=core.windows.net";
        private static string blobName = "Smanga.cv";
        private static string blobLocation = "C:\\Users\\Khetha\\Downloads\\Smanga_Ngcamu_cv.pdf";
        static void Main(string[] args)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
            //blobServiceClient.CreateBlobContainer(containerName);
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
            BlobClient blobClient = containerClient.GetBlobClient(blobName);
            blobClient.Upload(blobLocation);
            Console.WriteLine("Blob has been uploaded");
            Console.ReadKey();
        }
    }
}