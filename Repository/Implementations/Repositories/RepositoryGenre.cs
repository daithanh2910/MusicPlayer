using Repository.Interfaces.Repositories;

namespace Repository.Implementations.Repositories
{
    public class RepositoryGenre : IRepositoryGenre
    {
        private AppDbContext _context;

        public RepositoryGenre(AppDbContext context)
        {
            _context = context;
        }
    }
}
