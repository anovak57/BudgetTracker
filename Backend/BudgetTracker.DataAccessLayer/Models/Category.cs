using BudgetTracker.Common.Enums;

namespace BudgetTracker.DataAccessLayer.Models;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public CategoryType Type { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }

    public ICollection<Transaction> Transactions { get; set; }
    public ICollection<Budget> Budgets { get; set; }
}