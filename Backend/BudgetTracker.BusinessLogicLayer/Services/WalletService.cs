using BudgetTracker.BusinessLogicLayer.Interfaces;
using BudgetTracker.DataAccessLayer.Interfaces;
using BudgetTracker.DataAccessLayer.Models;

namespace BudgetTracker.BusinessLogicLayer.Services;

public class WalletService : BaseService<Wallet>, IWalletService
{
    private readonly IWalletRepository _repository;
    
    public WalletService(IWalletRepository repository) : base(repository)
    {
        _repository = repository;
    }
}