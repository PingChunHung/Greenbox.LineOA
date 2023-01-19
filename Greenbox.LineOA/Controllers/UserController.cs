using Greenbox.LineOA.Application.Users.Queries;
using Greenbox.LineOA.Infrastructure.Log;
using Microsoft.AspNetCore.Mvc;

namespace Greenbox.LineOA.Controllers
{
    public class UserController : ApiControllerBase
    {
        private readonly ILogHelper _logger;

        public UserController(ILogHelper logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<UserProfileDto>> GetUserProfile([FromQuery] GetUserProfileQuery query)
        {
            return await Mediator.Send(query);
        }

        [HttpGet("List")]
        public async Task<ActionResult<UserListDto>> GetUserList([FromQuery] GetUserListQuery query)
        {
            return await Mediator.Send(query);
        }

    }
}
