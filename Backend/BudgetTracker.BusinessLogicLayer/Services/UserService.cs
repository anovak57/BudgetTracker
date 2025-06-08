using BudgetTracker.BusinessLogicLayer.Interfaces;
using BudgetTracker.DataAccessLayer.Interfaces;
using BudgetTracker.DataAccessLayer.Models;

namespace BudgetTracker.BusinessLogicLayer.Services;

public class UserService : BaseService<User>, IUserService
{
    private readonly IUserRepository _repository;
    
    public UserService(IUserRepository repository) : base(repository)
    {
        _repository = repository;
    }
}