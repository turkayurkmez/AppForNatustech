using Natustech.Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Natustech.Store.DataAccess
{
   public interface IRepository<T> where T:class, IEntity, new()
    {
        T Add(T entity);
        IList<T> GetAllEntities();
        IList<T> GetAllEntities(Expression<Func<T,bool>> criteria);
        T GetById(int id);
        T Delete(int id);
        T Update(T entity);

    }
}
