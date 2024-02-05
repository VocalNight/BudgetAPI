using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Reflection.Emit;

namespace BudgetAPI.Models
{
    public class BudgetContext : DbContext
    {
        public BudgetContext(DbContextOptions<BudgetContext> options) : base(options) { }

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            modelBuilder.Entity<CategoryModel>()
                .HasMany(c => c.Transactions)
                .WithOne(e => e.Category)
                .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<TransactionModel> Transactions { get; set; }
    }
}
