using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    interface ICategoryRepository
    {
        public IEnumerable<Category> GetCategories();
        public Category GetCategory(int id);
        public void InsertCategory(string categoryName);
        public void UpdateCategory(Category category);
        public void DeleteCategory(Category category);

    }
}
