using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using usingWebAPI.Models;

namespace usingWebAPI.Services
{
   public interface IProductService
    {
        Task<IList<Products>> GetProducts();
        Task<Products> GetProduct(int id);
    }
}
