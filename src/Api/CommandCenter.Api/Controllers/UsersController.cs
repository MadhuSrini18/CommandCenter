using AutoMapper;
using CommandCenter.Application.Dtos;
using CommandCenter.Application.Persistence.IRespositories;
using CommandCenter.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CommandCenter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IServiceProvider _serviceProvider;
        public readonly IMapper _mapper;

        public UsersController(IServiceProvider serviceProvider, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("AddUsers")]
        public async Task<ActionResult> AddUsers(UsersDto userDto)
        {
            try
            {
                if (userDto == null)
                {
                    return StatusCode(400);
                }
               var scope = _serviceProvider.CreateScope();
               var repoWrapper = scope.ServiceProvider.GetRequiredService<IRepositoryWrapper>();
                var user = _mapper.Map<Users>(userDto);
                repoWrapper.UserRepository.AddUser(user);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error Caught on GetAdminPrinterStatuses API. Exception Detail: {ex}");
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        [Route("ValidateUser")]
        public async Task<ActionResult> ValidateUser(string username, string password)
        {
            try
            {
                if (username == null || password == null)
                {
                    return StatusCode(400);
                }



                return StatusCode(200);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error Caught on GetAdminPrinterStatuses API. Exception Detail: {ex}");
                return StatusCode(500, ex);
            }
        }

    }
}
