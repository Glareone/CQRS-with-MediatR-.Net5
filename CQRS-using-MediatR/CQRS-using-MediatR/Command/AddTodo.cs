using CQRS_using_MediatR.Repository.Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using CQRS_using_MediatR.Repository;

namespace CQRSTest.Commands
{
    public static class AddTodo
    {
        // Command
        public class Command : IRequest<int> 
        {
            public Command()
            {

            }
            public Command(string name)
            {
                Name = name;
            }

            public string Name { get; set; }
        }

        // Handler
        public class Handler : IRequestHandler<Command, int>
        {
            private readonly FooRepository repository;

            public Handler(FooRepository repository)
            {
                this.repository = repository;
            }

            public async Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                var newId = repository.Todos.Count + 1;
                repository.Todos.Add(new Todo { Id = newId, Name = request.Name });
                return newId;
            }
        }
    }
}