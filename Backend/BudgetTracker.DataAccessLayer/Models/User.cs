namespace BudgetTracker.DataAccessLayer.Models;

public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; }

    public ICollection<Wallet>? Wallets { get; set; }
    public ICollection<Category>? Categories { get; set; }
    public ICollection<Budget>? Budgets { get; set; } 
}