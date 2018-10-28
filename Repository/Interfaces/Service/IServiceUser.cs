using Repository.Interfaces.Repositories;

namespace Repository.Interfaces.Service
{
    public interface IServiceUser : ServiceBase
    {
        IRepositoryUser RepositoryUser { get; }
    }
}
