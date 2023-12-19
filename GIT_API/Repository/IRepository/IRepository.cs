using GIT_API.Data;
using System.Linq.Expressions;

namespace GIT_API.Repository.IRepository
{
    public interface IRepository <T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
    }
}
