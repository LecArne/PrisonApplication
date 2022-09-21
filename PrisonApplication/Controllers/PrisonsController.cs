using MediatR;
using Microsoft.AspNetCore.Mvc;
using PrisonApplication.Contracts.Commands;
using PrisonApplication.Contracts.Queries.PrisonGroups;
using PrisonApplication.Contracts.Queries.Prisons;

namespace PrisonApplication.Web.Controllers
{
    public class PrisonsController : ApiControllerBase
    {
        public PrisonsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetPrisons()
        {
            return await ExecuteRequest(new GetAllPrisonsQuery());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPrisonById(string id)
        {
            return await ExecuteRequest(new GetPrisonByIdQuery(Guid.Parse(id)));
        }

        [HttpPost]
        public async Task<IActionResult> PostPrison(AddPrisonCommand command)
        {
            if (command == null) return BadRequest();
            return await ExecuteRequest(command);
        }
    }
}
