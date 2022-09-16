using Microsoft.EntityFrameworkCore;
using Northwind.Domain.Models;
using Northwind.Domain.Repository;
using Northwind.Persistence.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Persistence.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(NorthwindContext dbContext) : base(dbContext)
        {
        }

        public void Edit(Category category)
        {
            Update(category);
        }

        public void Edit(ICategoryRepository category)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetAllCategory(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(c => c.CategoryName).ToListAsync();
        }

        public Task<IEnumerable<Domain.Enities.Category>> GetAllCAtegory(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> GetCategoryById(int categoryId, bool trackChanges)
        {
            return await FindByCondition(c => c.CategoryId.Equals(categoryId), trackChanges).SingleOrDefaultAsync();
        }

        public void Insert(Category category)
        {
            Create(category);
        }

        public void Insert(ICategoryRepository category)
        {
            throw new NotImplementedException();
        }

        public void Remove(Category category)
        {
            Delete(category);
        }

        public void Remove(ICategoryRepository category)
        {
            throw new NotImplementedException();
        }

        Task<string> ICategoryRepository.GetAllCategory(bool v)
        {
            throw new NotImplementedException();
        }

        Task ICategoryRepository.GetCategoryById(int id, bool v)
        {
            throw new NotImplementedException();
        }
    }
}

