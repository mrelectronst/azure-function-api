using AzureSqlServerWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AzureSqlServerWebAPI.Core
{
    public class APIDbContext: DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options) { }

        public DbSet<WalletDTO> Wallets { get; set; }

    }
}
