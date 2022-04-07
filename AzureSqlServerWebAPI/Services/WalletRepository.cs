using AzureSqlServerWebAPI.Infrastructure;
using AzureSqlServerWebAPI.Models;

namespace AzureSqlServerWebAPI.Services
{
    public class WalletRepository : IWalletRepository
    {
        private readonly APIDbContext _dbContext;

        public WalletRepository(APIDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<WalletDTO> GetWalletByIdAsync(int Id)
        {
            return await _dbContext.Wallets.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<IReadOnlyList<WalletDTO>> GetWalletsAsync()
        {
            return await _dbContext.Wallets.ToListAsync();
        }
    }
}
