using LabSecureApi.Model;
using LabSecureApi.ViewModel;
using AutoMapper;

namespace LabSecureApi.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
