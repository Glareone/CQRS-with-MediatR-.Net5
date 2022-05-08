using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CQRS_using_MediatR.Common.Infrastructure.ResponseTemplate;
using CQRS_using_MediatR.DAL.Repository;
using CQRS_using_MediatR.Features.User.Dtos;
using MediatR;

namespace CQRS_using_MediatR.Features.User
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, ResponseTemplate<UserDto>>
    {
        private readonly IUserRepository _userRepository;

        public AddUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ResponseTemplate<UserDto>> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var lenght = _userRepository.Users.Count();

            var newUser = new Repository.Domain.User()
            {
                Id = lenght + 1,
                Name = request.Name,
                IsDeleted = request.IsDeleted,
            };

            _userRepository.Users.Add(newUser);

            return new ResponseTemplate<UserDto>(new UserDto
            {
                Id = newUser.Id,
                Name = newUser.Name,
                IsDeleted = newUser.IsDeleted
            });
        }
    }
}
