using Northwind.Domain.Base;
using Northwind.Domain.Repository;
using Northwind.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Persistence.Base
{
    public class RepositoryManager : IRepositoryManager
    {
        private NorthwindContext _dbContext;
        private ICategoryRepository _categoryRepository;

        public RepositoryManager (NorthwindContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (_categoryRepository == null)
                {
                    _categoryRepository = new CategoryRepository(_dbContext);
                }
                return _categoryRepository;
            }
        }

        public void Save() => _dbContext.SaveChanges();

        public async Task SaveAsync()=> await _dbContext.SaveChangesAsync();
       
    }
}
