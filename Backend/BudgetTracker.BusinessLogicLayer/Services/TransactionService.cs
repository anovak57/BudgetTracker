using BudgetTracker.BusinessLogicLayer.Interfaces;
using BudgetTracker.DataAccessLayer.Interfaces;
using BudgetTracker.DataAccessLayer.Models;

namespace BudgetTracker.BusinessLogicLayer.Services;

public class TransactionService : BaseService<Transaction>, ITransactionService
{
    private readonly ITransactionRepository _repository;
    
    public TransactionService(ITransactionRepository repository) : base(repository)
    {
        _repository = repository;
    }
}