using Natustech.Store.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Natustech.Store.DataAccess
{
   public interface IProductRepository : IRepository<Product>
    {
        IList<Product> GetProductsByName(string name);
    }
}
