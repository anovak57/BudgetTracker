using BudgetTracker.BusinessLogicLayer.Interfaces;
using BudgetTracker.DataAccessLayer.Interfaces;
using BudgetTracker.DataAccessLayer.Models;

namespace BudgetTracker.BusinessLogicLayer.Services;

public class CategoryService : BaseService<Category>, ICategoryService
{
    private readonly ICategoryRepository _repository;

    public CategoryService(ICategoryRepository repository) : base(repository)
    {
        _repository = repository;
    }
}