using BudgetTracker.DataAccessLayer.Data;
using BudgetTracker.DataAccessLayer.Interfaces;
using BudgetTracker.DataAccessLayer.Models;

namespace BudgetTracker.DataAccessLayer.Repositories;

public class BudgetRepository : BaseRepository<Budget>, IBudgetRepository
{
    public BudgetRepository(AppDbContext context) : base(context)
    {
    }
}