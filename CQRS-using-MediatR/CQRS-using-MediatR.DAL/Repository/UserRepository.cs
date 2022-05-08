using CQRS_using_MediatR.Repository.Domain;
using System.Collections.Generic;

namespace CQRS_using_MediatR.DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> Users { get; } = new List<User>
        {
            new() {Id = 1, Name = "Alex", IsCompleted = false},
            new() { Id = 2, Name = "Vaidas", IsCompleted = false },
            new() { Id = 3, Name = "Donatas", IsCompleted = false },
            new() { Id = 4, Name = "Andrew", IsCompleted = false },
            new() { Id = 5, Name = "Aleksandr", IsCompleted = false },
            new() { Id = 6, Name = "Dzmitry", IsCompleted = false },
            new() { Id = 7, Name = "Grzegorz", IsCompleted = false },
        };
    }
}
