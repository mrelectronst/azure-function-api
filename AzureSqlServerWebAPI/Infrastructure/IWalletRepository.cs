using AzureSqlServerWebAPI.Models;

namespace AzureSqlServerWebAPI.Infrastructure
{
    public interface IWalletRepository
    {
        Task<IReadOnlyList<WalletDTO>> GetWalletsAsync();

        Task<WalletDTO> GetWalletByIdAsync(int Id);
    }
}
