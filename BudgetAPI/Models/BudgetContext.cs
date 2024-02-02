using Microsoft.EntityFrameworkCore;

namespace BudgetAPI.Models
{
    public class BudgetContext : DbContext
    {
        public BudgetContext(DbContextOptions<BudgetContext> options) : base(options) { }

        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<TransactionModel> Transactions { get; set; }
    }
}
