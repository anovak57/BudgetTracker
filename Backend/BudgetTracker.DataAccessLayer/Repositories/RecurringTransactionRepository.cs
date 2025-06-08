using BudgetTracker.DataAccessLayer.Data;
using BudgetTracker.DataAccessLayer.Interfaces;
using BudgetTracker.DataAccessLayer.Models;

namespace BudgetTracker.DataAccessLayer.Repositories;

public class RecurringTransactionRepository : BaseRepository<RecurringTransaction>, IRecurringTransactionRepository
{
    public RecurringTransactionRepository(AppDbContext context) : base(context)
    {
        
    }
}