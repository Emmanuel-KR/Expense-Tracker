using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Expense_Tracker.Repositories
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        //public DbSet<Transaction>
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
