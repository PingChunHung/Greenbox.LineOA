using AutoMapper;
using Greenbox.LineOA.Application.Common.Interfaces.LineBot;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenbox.LineOA.Application.Users.Queries
{
    public record GetUserProfileQuery : IRequest<UserProfileDto>
    {
        public string? UserId { get; init; }
    }

    public class GetUserProfileQueryHandler : IRequestHandler<GetUserProfileQuery, UserProfileDto>
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public GetUserProfileQueryHandler(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<UserProfileDto> Handle(GetUserProfileQuery request, CancellationToken cancellationToken)
        {
            var userProfile = await _userService.GetUserProfile(request.UserId);
            return _mapper.Map<UserProfileDto>(userProfile);
        }
    }
}
