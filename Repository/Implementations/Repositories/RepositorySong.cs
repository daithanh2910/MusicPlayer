using Repository.Interfaces.Repositories;

namespace Repository.Implementations.Repositories
{
    public class RepositorySong : IRepositorySong
    {
        private AppDbContext _context;

        public RepositorySong(AppDbContext context)
        {
            _context = context;
        }
    }
}
