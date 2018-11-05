using Repository.Interfaces.Repositories;

namespace Repository.Interfaces.Service
{
    public interface IServiceSong : ServiceBase
    {
        IRepositorySong RepositorySong { get; }
    }
}
