using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading.Tasks;

namespace AzureFunc
{
    public class GetWalletsFunc
    {
        private readonly HttpClient _client;

        public GetWalletsFunc(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient();
        }

        [FunctionName("GetWallets")]
        public async Task<IActionResult> GetWallets(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "Wallet")] HttpRequest req,
            ILogger log)
        {

            var response = await _client.GetAsync("https://localhost:7264/api/wallet");

            var wallet = response.Content.ReadAsStreamAsync();

            return new OkObjectResult(wallet.Result);
        }

        [FunctionName("GetWalletById")]
        public async Task<IActionResult> GetWalletById(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "Wallet/{Id}")] HttpRequest req,
            ILogger log,int Id)
        {
            var response = await _client.GetAsync($"https://localhost:7264/api/wallet/{Id}");

            var wallet = response.Content.ReadAsStreamAsync();

            return new OkObjectResult(wallet.Result);
        }
    }
}
