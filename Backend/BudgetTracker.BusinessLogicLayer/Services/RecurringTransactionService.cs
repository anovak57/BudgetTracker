using BudgetTracker.BusinessLogicLayer.Interfaces;
using BudgetTracker.DataAccessLayer.Interfaces;
using BudgetTracker.DataAccessLayer.Models;

namespace BudgetTracker.BusinessLogicLayer.Services;

public class RecurringTransactionService : BaseService<RecurringTransaction>, IRecurringTransactionService
{
    private readonly IRecurringTransactionRepository _repository;
    
    public RecurringTransactionService(IRecurringTransactionRepository repository) : base(repository)
    {
        _repository = repository;
    }
}