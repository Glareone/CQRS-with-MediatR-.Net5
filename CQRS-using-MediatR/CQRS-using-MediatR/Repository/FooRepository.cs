using CQRS_using_MediatR.Repository.Domain;
using System.Collections.Generic;

namespace CQRS_using_MediatR.Repository
{
    public class FooRepository
    {
        public List<Todo> Todos { get; } = new List<Todo>
        {
            new Todo { Id = 1, Name = "Do something", IsCompleted = false },
            new Todo { Id = 2, Name = "Do something else", IsCompleted = false },
            new Todo { Id = 3, Name = "Do coding", IsCompleted = false },
            new Todo { Id = 4, Name = "Do gaming", IsCompleted = false },
            new Todo { Id = 5, Name = "Do mechwarrior", IsCompleted = false },
            new Todo { Id = 6, Name = "Do something useful for entire mankind", IsCompleted = false },
        };
    }
}
