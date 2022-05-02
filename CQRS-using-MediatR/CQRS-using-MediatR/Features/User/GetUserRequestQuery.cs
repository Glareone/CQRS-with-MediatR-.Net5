

namespace CQRS_using_MediatR.Features.User
{
    using CQRS_using_MediatR.Features.User.Dtos;
    using CQRS_using_MediatR.Infrastructure;
    using MediatR;

    public class GetUserRequestQuery : IRequest<ResponseTemplate<UserDto>>
    {
        public GetUserRequestQuery(int userId)
        {
            UserId = userId;
        }

        public int UserId { get; }
    }
}
