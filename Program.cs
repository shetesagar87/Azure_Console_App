using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Azure.Storage;
//using Microsoft.Azure.Storage.Blob;
using Azure.Storage.Blobs;


namespace Azure_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectioString = "DefaultEndpointsProtocol=https;AccountName=csg10037ffe8d415449;AccountKey=9SpbWMWZcmcsFwLlQLdWGFs1SoyYtc9cUWOMuTdsv2grtQIIkGX+yzI/bzM9cAhrHJpjXyaj7FgJjwl204fCog==;EndpointSuffix=core.windows.net";

            BlobServiceClient blobClient = new BlobServiceClient(connectioString);


        }
    }
}
