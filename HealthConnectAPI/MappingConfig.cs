using AutoMapper;
using HealthConnectAPI.Models;
using HealthConnectAPI.Models.Dto;

namespace HealthConnectAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
 
            CreateMap<ApplicationUser, UserDTO>().ReverseMap();
        }
    }
}
