using Repository.Entities;
using System.Collections.Generic;

namespace Repository.Interfaces.Repositories
{
    public interface IRepositoryUser
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
        User Create(User user, string password);
        void Update(User user, string password = null);
        void Delete(int id);
    }
}
