using BudgetTracker.Common.Enums;

namespace BudgetTracker.DataAccessLayer.Models;

public class RecurringTransaction
{
    public Guid Id { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }
    public FrequencyType Frequency { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public Guid WalletId { get; set; }
    public Wallet Wallet { get; set; }

    public Guid CategoryId { get; set; }
    public Category Category { get; set; }

    public TransactionType Type { get; set; }
}