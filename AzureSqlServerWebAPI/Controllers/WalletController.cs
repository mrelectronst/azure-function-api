using AzureSqlServerWebAPI.Infrastructure;
using AzureSqlServerWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AzureSqlServerWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        private readonly IWalletRepository _walletRepository;

        public WalletController(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        [HttpGet]
        public async Task<IReadOnlyList<WalletDTO>> GetAllWallets()
        {
            var wallets = await _walletRepository.GetWalletsAsync();

            return wallets;
        }

        [HttpGet("{Id}")]
        public async Task<WalletDTO> GetWalletById(int Id)
        {
            var wallet = await _walletRepository.GetWalletByIdAsync(Id);

            return wallet;
        }
    }
}
