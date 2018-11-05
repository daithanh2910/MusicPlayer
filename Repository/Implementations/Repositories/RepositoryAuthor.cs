using Repository.Interfaces.Repositories;

namespace Repository.Implementations.Repositories
{
    public class RepositoryAuthor : IRepositoryAuthor
    {
        private AppDbContext _context;

        public RepositoryAuthor(AppDbContext context)
        {
            _context = context;
        }
    }
}
