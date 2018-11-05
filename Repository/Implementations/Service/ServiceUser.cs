using Repository.Implementations.Repositories;
using Repository.Interfaces.Repositories;
using Repository.Interfaces.Service;
using System;

namespace Repository.Implementations.Service
{
    public class ServiceUser : IServiceUser
    {
        private readonly AppDbContext _context;
        private IRepositoryUser _userRepository;
        public ServiceUser(AppDbContext context)
        {
            _context = context;
        }
        public IRepositoryUser RepositoryUser
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new RepositoryUser(_context);
                }
                return _userRepository;
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }
    }
}
