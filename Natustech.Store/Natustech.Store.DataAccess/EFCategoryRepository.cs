using Natustech.Store.DataAccess.Data;
using Natustech.Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Natustech.Store.DataAccess
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private NatustechDbContext natustechDbContext;

        public EFCategoryRepository(NatustechDbContext natustechDbContext)
        {
            this.natustechDbContext = natustechDbContext;
        }
        public Category Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Category> GetAllEntities()
        {
            return natustechDbContext.Categories.ToList();
        }

        public IList<Category> GetAllEntities(Expression<Func<Category, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Category Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
