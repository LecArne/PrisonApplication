using MediatR;
using PrisonApplication.Application.Dxos.PrisonGroups;
using PrisonApplication.Application.Dxos.Prisons;
using PrisonApplication.Contracts.Commands;
using PrisonApplication.Contracts.Dtos.PrisonGroups;
using PrisonApplication.Contracts.Dtos.Prisons;
using PrisonApplication.Models.Entity.PrisonGroups;
using PrisonApplication.Models.Entity.Prisons;
using PrisonApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonApplication.Application.CommandHandlers.PrisonGroups
{
    internal class AddPrisonCommandHandler : IRequestHandler<AddPrisonCommand, PrisonDto>
    {
        private readonly IRepository<Prison> _repository;
        private readonly IPrisonsDxos _prisonsDxos;
        public AddPrisonCommandHandler(IRepository<Prison> repository, IPrisonsDxos prisonsDxo)
        {
            this._repository = repository;
            _prisonsDxos = prisonsDxo;
        }
        public async Task<PrisonDto> Handle(AddPrisonCommand request, CancellationToken cancellationToken)
        {
            //ValidationResult result = await new AddCompanyCommandValidator().ValidateAsync(request);
            //if (!result.IsValid)
            //{
            //    throw new ValidationException(result.Errors);
            //}
            Prison p = new Prison(request.Name)
            {
                Name = request.Name,
                Country = request.Country,
                City = request.City,
                Zip = request.Zip,
                Street = request.Zip,
                Nr = request.Nr,
                Cells = request.Cells
            };
            _repository.Add(p);
            await _repository.SaveChangesAsync();

            return _prisonsDxos.MapPrisonDto(p);
        }
    }
}
