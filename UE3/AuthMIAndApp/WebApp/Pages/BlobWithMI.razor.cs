using Azure.Identity;
using Azure.Storage.Blobs;
using System.Text;

namespace WebApp.Pages;

public partial class BlobWithMI
{
    protected string ImageUrl { get; set; }
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        string containerEndpoint = string.Format("https://{0}.blob.core.windows.net/{1}", "fhtgo", "images");

        BlobContainerClient containerClient = new BlobContainerClient(new Uri(containerEndpoint), new DefaultAzureCredential());
        BlobClient blobClient = containerClient.GetBlobClient("easter.jpg");
        var bytes = blobClient.DownloadContent().Value.Content.ToArray();

        ImageUrl = $"data:image/jpeg;base64,{Convert.ToBase64String(bytes)}";
    }
}
