using Repository.Interfaces.Repositories;

namespace Repository.Implementations.Repositories
{
    public class RepositorySongAlbum : IRepositorySongAlbum
    {
        private AppDbContext _context;

        public RepositorySongAlbum(AppDbContext context)
        {
            _context = context;
        }
    }
}
