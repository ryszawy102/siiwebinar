using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Queue;
using MockupForBusiness.Models;
using Newtonsoft.Json;

namespace MockupForBusiness.Controllers
{
    public class AzureController : Controller
    {
        [HttpGet("blob-upload")]
        public IActionResult BlobUpload()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> FileUpload(IFormFile file)
        {
            var uri = await UploadFileToStorage(file.OpenReadStream(), file.FileName);

            return Ok(uri);
        }

        [HttpGet("azure-queue")]
        public IActionResult AzureQueue()
        {
            return View(new QueueVm());
        }

        [HttpPost("azure-queue")]
        public IActionResult AzureQueue(QueueVm model)
        {
                // Retrieve storage account from connection string.
                var storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=storageaccountsii98a7;AccountKey=MyX3i4pRFpQdipD4EOSxUQNEEk37L8OJ94nM0pqkKIDGYfY4JvRaDCmdCA5tc+3ElfNBZJVzPyLs8bX/s6RJXg==;EndpointSuffix=core.windows.net");
                // Create the queue client.
                var queueClient = storageAccount.CreateCloudQueueClient();
                // Retrieve a reference to a container.
                var queue = queueClient.GetQueueReference("myfirstqueue");
                // Create the queue if it doesn't already exist
                queue.CreateIfNotExistsAsync();

                var message = new CloudQueueMessage(JsonConvert.SerializeObject(model));
                queue.AddMessageAsync(message);

                return Content("Email wrzucony na kolejke");
        }

        public async Task<string> UploadFileToStorage(Stream stream, string uploadName)
        {
            var fileStream = stream;
            var fileName = uploadName;
            var accountName = "storageaccountsii98a7";
            var accountKey = "MyX3i4pRFpQdipD4EOSxUQNEEk37L8OJ94nM0pqkKIDGYfY4JvRaDCmdCA5tc+3ElfNBZJVzPyLs8bX/s6RJXg==";
            var imageCointainer = "testimagecontainar";


            // Create storagecredentials object by reading the values from the configuration (appsettings.json)
            var storageCredentials = new StorageCredentials(accountName, accountKey);

            // Create cloudstorage account by passing the storagecredentials
            var storageAccount = new CloudStorageAccount(storageCredentials, true);

            // Create the blob client.
            var blobClient = storageAccount.CreateCloudBlobClient();

            // Get reference to the blob container by passing the name by reading the value from the configuration (appsettings.json)
            var container = blobClient.GetContainerReference(imageCointainer);

            // Get the reference to the block blob from the container
            var blockBlob = container.GetBlockBlobReference(fileName);

            // Upload the file
            await blockBlob.UploadFromStreamAsync(fileStream);

            // return await Task.FromResult(true);
            return blockBlob.Uri.ToString();
        }
    }
}