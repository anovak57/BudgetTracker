namespace BudgetTracker.DataAccessLayer.Models;

public class Budget
{
    public Guid Id { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }

    public decimal Limit { get; set; }
    public DateTime Period { get; set; }
}