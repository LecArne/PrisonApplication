using MediatR;
using PrisonApplication.Application.Dxos.PrisonGroups;
using PrisonApplication.Contracts.Commands;
using PrisonApplication.Contracts.Dtos.PrisonGroups;
using PrisonApplication.Models.Entity.PrisonGroups;
using PrisonApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace PrisonApplication.Application.CommandHandlers.PrisonGroups
{
    internal class AddPrisonGroupCommandHandler : IRequestHandler<AddPrisonGroupCommand, PrisonGroupDto>
    {
        private readonly IRepository<PrisonGroup> _repository;
        private readonly IPrisonGroupsDxos _prisonGroupsDxos;

        public AddPrisonGroupCommandHandler(IRepository<PrisonGroup> repository, IPrisonGroupsDxos prisonGroupDxo)
        {
            this._repository = repository;
            _prisonGroupsDxos = prisonGroupDxo;
        }

        public async Task<PrisonGroupDto> Handle(AddPrisonGroupCommand request, CancellationToken cancellationToken)
        {
            //ValidationResult result = await new AddCompanyCommandValidator().ValidateAsync(request);
            //if (!result.IsValid)
            //{
            //    throw new ValidationException(result.Errors);
            //}
            PrisonGroup pg = new PrisonGroup(request.Name)
            {
                Name = request.Name,
                Country = request.Country,
                City = request.City,
                Zip = request.Zip,
                Street = request.Zip,
                Nr = request.Nr,
            };
            _repository.Add(pg);
            await _repository.SaveChangesAsync();

            return _prisonGroupsDxos.MapPrisonGroupDto(pg);
        }
    }
}
