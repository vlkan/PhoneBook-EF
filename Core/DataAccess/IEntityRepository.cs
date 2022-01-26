using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint
    //class referance type
    //we can insert just IEntity or impelemntations class type
    //just can be new
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool >> filter = null); //for search

        T Get(Expression<Func<T, bool >> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
