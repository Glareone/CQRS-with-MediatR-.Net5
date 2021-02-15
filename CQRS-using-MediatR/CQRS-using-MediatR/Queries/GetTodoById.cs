using CQRS_using_MediatR.Repository;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_using_MediatR.Queries
{
    public static class GetTodoById
    {
        // Query / Command
        // All the data we need to execute
        public class Query: IRequest<Response>
        {
            public Query(int id)
            {
                Id = id;
            }
            public int Id { get; }
        }

        // Handler
        // All the business logic to execute. Returns a response.
        public class Handler : IRequestHandler<Query, Response>
        {
            private FooRepository fooRepository;

            public Handler(FooRepository fooRepository)
            {
                this.fooRepository = fooRepository;
            }

            public async Task<Response> Handle(Query request, CancellationToken cancellationToken)
            {
                // All the business logic.
                var todo = fooRepository.Todos.FirstOrDefault(x => x.Id == request.Id);
                return todo == null ? null : new Response(todo.Id, todo.Name, todo.IsCompleted);
            }
        }

        // Response
        // The data we want to return
        public class Response
        {
            public Response(int id, string name, bool isCompleted)
            {
                Id = id;
                Name = name;
                IsCompleted = isCompleted;
            }

            public int Id { get; }
            public string Name { get; }
            public bool IsCompleted { get; }
        }
    }
}
