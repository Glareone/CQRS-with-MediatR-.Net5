using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CQRS_using_MediatR.Features.User.Dtos;
using CQRS_using_MediatR.Infrastructure;
using CQRS_using_MediatR.Repository;

namespace CQRS_using_MediatR.Features.User
{
    public class GetUserRequestHandler
    {
        private readonly IUserRepository _userRepository;
        // TODO add Mapper

        public GetUserRequestHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ResponseTemplate<UserDto>> Handle(GetUserRequestQuery query,
            CancellationToken cancellationToken)
        {
            // TODO Null checks and error handling

            var user = _userRepository.Users.SingleOrDefault(u => u.Id == query.UserId);
            return new ResponseTemplate<UserDto>(new UserDto
            {
                Id = user.Id, Name = user.Name, IsCompleted = user.IsCompleted
            });

            // TODO mapper.map
        }
    }
}
