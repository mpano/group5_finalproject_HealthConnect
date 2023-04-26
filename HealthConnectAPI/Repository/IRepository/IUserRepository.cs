using HealthConnectAPI.Models;
using HealthConnectAPI.Models.Dto;

namespace HealthConnectAPI.Repository.IRepository
{
   
        public interface IUserRepository
        {
            bool IsUniqueUser(string username);
            Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
            Task<UserDTO> Register(RegisterationRequestDTO registerationRequestDTO);
        }
    
}
