using AutoMapper;
using WebApplication1.Entities;

namespace WebApplication1.Mappings
{
    /// <summary>
    /// Manage NuGet --> AutoMapper, AutoMapper.Extensions.Microsoft.DependencyInjection
    /// </summary>
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        { 
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.Name, operation => operation.MapFrom(source => source.FirstName + " " + source.LastName))
                .ForMember(dest => dest.Status, operation => operation.MapFrom(source => ((UserStatusEnum)Convert.ToInt32(source.isActive)).ToString()));
        }
    }
}
