using AutoMapper;
using Repository.Entities;
using Repository.ViewModel;

namespace WebApplication.Data
{
    public class MusicPlayerProfile : Profile
    {
        public MusicPlayerProfile()
        {
            CreateMap<User, UserView>().ReverseMap();
        }
    }
}
