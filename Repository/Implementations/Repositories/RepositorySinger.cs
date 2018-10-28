using Repository.Interfaces.Repositories;

namespace Repository.Implementations.Repositories
{
    public class RepositorySinger : IRepositorySinger
    {
        private AppDbContext _context;

        public RepositorySinger(AppDbContext context)
        {
            _context = context;
        }
    }
}
