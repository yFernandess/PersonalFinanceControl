using PersonalFinanceControl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PersonalFinanceControl.Services.Implementations
{
    public class CategoryServiceImplementation : ICategoryService
    {
        private volatile int count;

        public Category Create(Category category)
        {
            return category;
        }

        public void Delete(long id)
        {

        }

        public List<Category> FindAll()
        {
            List<Category> categories = new List<Category>();

            for (int i = 0; i <= 2; i++)
            {
                Category category = MockCategory(i);
                categories.Add(category);
            }

            return categories;
        }


        public Category FindByID(long id)
        {
            return new Category
            {
                Id = IncrementAndGet(),
                Description = "Teste"
            };
        }

        public Category Update(Category category)
        {
            return category;
        }

        private Category MockCategory(int i)
        {
            return new Category
            {
                Id = IncrementAndGet(),
                Description = "Teste Categoria" + i
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
