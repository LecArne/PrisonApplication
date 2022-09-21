using MediatR;
using Microsoft.AspNetCore.Mvc;
using PrisonApplication.Contracts.Commands;
using PrisonApplication.Contracts.Queries.PrisonGroups;

namespace PrisonApplication.Web.Controllers
{
    public class PrisonGroupsController : ApiControllerBase
    {
        public PrisonGroupsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetPrisonGroups()
        {
            return await ExecuteRequest(new GetAllPrisongroupsQuery());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPrisonGroupById(string id)
        {
            return await ExecuteRequest(new GetPrisongroupByIdQuery(Guid.Parse(id)));
        }

        [HttpPost]
        public async Task<IActionResult> PostPrisonGroup(AddPrisonGroupCommand command)
        {
            if (command == null) return BadRequest();
            return await ExecuteRequest(command);
        }
    }
}
