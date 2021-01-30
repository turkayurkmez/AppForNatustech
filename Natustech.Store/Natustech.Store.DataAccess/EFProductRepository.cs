using Natustech.Store.DataAccess.Data;
using Natustech.Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Natustech.Store.DataAccess
{
    public class EFProductRepository : IProductRepository
    {
        private NatustechDbContext dbContext;

        public EFProductRepository(NatustechDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Product Add(Product entity)
        {
            dbContext.Add(entity);
            dbContext.SaveChanges();
            return entity;
        }

        public Product Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAllEntities()
        {
            return dbContext.Products.ToList();
        }

        public IList<Product> GetAllEntities(Expression<Func<Product, bool>> criteria)
        {
            return dbContext.Products.Where(criteria).ToList();
        }

        public Product GetById(int id)
        {
            return dbContext.Products.Find(id);
        }

        public IList<Product> GetProductsByName(string name)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product entity)
        {
            
            dbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return entity;
        }
    }
}
