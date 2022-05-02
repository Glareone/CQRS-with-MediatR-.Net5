using System.Collections.Generic;
using CQRS_using_MediatR.Repository.Domain;

namespace CQRS_using_MediatR.Repository
{
    public interface IUserRepository
    {
        public IEnumerable<User> Users { get; }
    }
}
