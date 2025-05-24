using BudgetTracker.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetTracker.DataAccessLayer.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    public DbSet<Budget> Budgets { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Wallet> Wallets { get; set; }
    public DbSet<RecurringTransaction> RecurringTransactions { get; set; }
}