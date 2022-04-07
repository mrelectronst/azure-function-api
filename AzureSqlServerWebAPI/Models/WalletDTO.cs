using System.ComponentModel.DataAnnotations;

namespace AzureSqlServerWebAPI.Models
{
    public class WalletDTO
    {
        [Key]
        public int Id { get; set; }

        public decimal? Amount { get; set; }

        public string? Direction { get; set; }

        public int? Account { get; set; }
    }
}
