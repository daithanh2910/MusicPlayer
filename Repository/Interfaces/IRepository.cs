using Repository.Entities;
using System.Linq;

namespace Repository.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        void Create(T entity);

        void Edit(T entity);

        IQueryable<T> GetAll();

        void Delete(params object[] keyValues);
    }
}
