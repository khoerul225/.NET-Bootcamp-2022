using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Domain;
using Northwind.Domain.Enities;

namespace Northwind.Domain.Repository
{
    public interface ICategoryRepository
    {
     Task<IEnumerable<Category>> GetAllCAtegory(bool trackChanges);

     void Insert (ICategoryRepository category);
     void Edit (ICategoryRepository category);
     void Remove(ICategoryRepository category);

    }
}
