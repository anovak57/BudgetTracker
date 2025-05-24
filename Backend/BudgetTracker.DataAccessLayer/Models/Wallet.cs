using BudgetTracker.Common.Enums;

namespace BudgetTracker.DataAccessLayer.Models;

public class Wallet
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Balance { get; set; }
    public WalletType Type { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }

    public ICollection<Transaction>? Transactions { get; set; }
    public ICollection<RecurringTransaction>? RecurringTransactions { get; set; }
}
