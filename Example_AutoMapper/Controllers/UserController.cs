using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public UserDto Get()
        {
            var user = new User 
            {
                Id = 0,
                FirstName= "Test",
                LastName= "Test",
                isActive= true,
            }; 

            var userDto = _mapper.Map<UserDto>(user);

            return userDto;
        }
    }
}
