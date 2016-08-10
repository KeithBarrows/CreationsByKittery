using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sol3.Site.Repository
{
    public interface IRepository<TEntity, in TPrimaryKey> where TEntity : class
    {
        TEntity Get(TPrimaryKey primaryKey);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(params Expression<Func<TEntity, bool>>[] filters);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        TEntity Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void Delete(TPrimaryKey primaryKey);
        void DeleteRange(IEnumerable<TEntity> entities);
    }
}
