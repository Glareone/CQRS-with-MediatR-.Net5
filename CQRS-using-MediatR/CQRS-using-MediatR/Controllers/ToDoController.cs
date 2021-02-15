using CQRS_using_MediatR.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRS_using_MediatR.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly IMediator mediator;
        public ToDoController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<ActionResult<GetTodoById.Response>> GetTodoById(int id)
        {
            var response = await mediator.Send(new GetTodoById.Query(id));
            return response != null ? Ok(response) : NotFound();
        }
    }
}
