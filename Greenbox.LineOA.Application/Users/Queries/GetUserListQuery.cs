using AutoMapper;
using Greenbox.LineOA.Application.Common.Interfaces;
using MediatR;

namespace Greenbox.LineOA.Application.Users.Queries
{
    public record GetUserListQuery : IRequest<UserListDto>
    {
        public int Limit { get; set; }
        public string? Start { get; set; }
    }

    public class GetUserListQueryHandler : IRequestHandler<GetUserListQuery, UserListDto>
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public GetUserListQueryHandler(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<UserListDto> Handle(GetUserListQuery request, CancellationToken cancellationToken)
        {
            var userList = await _userService.GetLineOAFriendUserList(request.Limit, request.Start);
            return _mapper.Map<UserListDto>(userList);
        }
    }
}
