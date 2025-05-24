using BudgetTracker.Common.Enums;

namespace BudgetTracker.DataAccessLayer.Models;

public class Transaction
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }

    public TransactionType Type { get; set; }

    public Guid WalletId { get; set; }
    public Wallet Wallet { get; set; }

    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}