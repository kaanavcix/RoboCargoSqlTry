using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepositoryDal<T> where T : class,IEntity // Type 
    {
        List<T> GetAll(Expression<Func<T,bool>> expression);
        void Update(T entity);
        void Delete(T entity);
        void Add(T entity);
        T Get(Expression<Func<T,bool>> expression );
       

    }
}



