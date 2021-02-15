using CQRS_using_MediatR.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRS_using_MediatR.Controllers
{
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IMediator mediator;
        public ToDoController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("/{id}")]
        public async Task<IActionResult> GetTodoById(int id)
        {
            var response = await mediator.Send(new GetTodoById.Query(id));
            return response != null ? Ok(response) : NotFound();
        }

        [HttpPost("")]
        public async Task<IActionResult> AddTodo(CQRSTest.Commands.AddTodo.Command command) 
        {
            return Ok(await mediator.Send(command));
        }
    }
}
