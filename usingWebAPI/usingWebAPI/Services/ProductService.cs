using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using usingWebAPI.Data;
using usingWebAPI.Models;

namespace usingWebAPI.Services
{
    public class ProductService : IProductService
    {
        private NatustechDbContext dbContext;

        public ProductService(NatustechDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Products> GetProduct(int id)
        {
            return await dbContext.Products.FindAsync(id);
        }

        public async Task<IList<Products>> GetProducts()
        {
            return await dbContext.Products.AsNoTracking().ToListAsync();
        }

    }
}
