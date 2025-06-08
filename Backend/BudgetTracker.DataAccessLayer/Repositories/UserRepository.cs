using BudgetTracker.DataAccessLayer.Data;
using BudgetTracker.DataAccessLayer.Interfaces;
using BudgetTracker.DataAccessLayer.Models;

namespace BudgetTracker.DataAccessLayer.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {
        
    }
}