using PersonalFinanceControl.Model;
using System.Collections.Generic;

namespace PersonalFinanceControl.Services
{
    public interface ICategoryService
    {
        Category Create(Category category);
        Category FindByID(long id);
        List<Category> FindAll();
        Category Update(Category category);
        void Delete(long id);
    }
}
