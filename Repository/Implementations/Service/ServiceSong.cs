using Repository.Implementations.Repositories;
using Repository.Interfaces.Repositories;
using Repository.Interfaces.Service;

namespace Repository.Implementations.Service
{
    public class ServiceSong : IServiceSong
    {
        private readonly AppDbContext _context;
        private IRepositorySong _songRepository;
        public ServiceSong(AppDbContext context)
        {
            _context = context;
        }
        public IRepositorySong RepositorySong
        {
            get
            {
                if (_songRepository == null)
                {
                    _songRepository = new RepositorySong(_context);
                }
                return _songRepository;
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Refresh()
        {
            throw new System.NotImplementedException();
        }
    }
}
