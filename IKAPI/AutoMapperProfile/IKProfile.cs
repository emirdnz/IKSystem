using AutoMapper;
using Ik.entities.Concrete;
using IKAPI.Areas.Admin.Models;

namespace IKAPI.AutoMapperProfile
{
    public class IKProfile : Profile
    {
        public IKProfile()
        {
            CreateMap<UserCreateDTO, User>();
        }
    }
}
