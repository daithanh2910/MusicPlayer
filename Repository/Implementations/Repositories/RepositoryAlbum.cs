using Repository.Interfaces.Repositories;

namespace Repository.Implementations.Repositories
{
    public class RepositoryAlbum : IRepositoryAlbum
    {
        private AppDbContext _context;

        public RepositoryAlbum(AppDbContext context)
        {
            _context = context;
        }
    }
}
