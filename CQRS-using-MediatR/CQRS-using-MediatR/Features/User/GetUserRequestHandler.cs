using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CQRS_using_MediatR.Common.Infrastructure.ErrorHandlers;
using CQRS_using_MediatR.Common.Infrastructure.ResponseTemplate;
using CQRS_using_MediatR.DAL.Repository;
using CQRS_using_MediatR.Features.User.Dtos;
using MediatR;

namespace CQRS_using_MediatR.Features.User
{
    public class GetUserRequestHandler: IRequestHandler<GetUserRequestQuery, ResponseTemplate<UserDto>>
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
            var user = _userRepository.Users.SingleOrDefault(u => u.Id == query.UserId);
            
            if (user == null)
            {
                return ErrorHandlingUtils.GetResponseTemplate<UserDto>(ErrorCode.Input);
            }
            
            return new ResponseTemplate<UserDto>(new UserDto
            {
                Id = user.Id, Name = user.Name, IsCompleted = user.IsCompleted
            });
        }
    }
}
