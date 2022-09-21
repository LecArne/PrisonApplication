using AutoMapper;
using PrisonApplication.Contracts.Dtos.Prisoners;
using PrisonApplication.Contracts.Dtos.Prisons;
using PrisonApplication.Models.Entity.Prisoners;
using PrisonApplication.Models.Entity.Prisons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonApplication.Application.Dxos.Prisoners
{
    public interface IPrisonersDxos
    {
        PrisonerDto MapPrisonerDto(Prisoner prisoner);
        IEnumerable<PrisonerDto> MapPrisonerDto(IEnumerable<Prisoner> prisoner);
    }

    public class PrisonersDxos : IPrisonersDxos
    {
        private readonly IMapper _mapper;

        public PrisonersDxos()
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Prisoner, PrisonerDto>(); });
            _mapper = config.CreateMapper();
        }

        public PrisonerDto MapPrisonerDto(Prisoner prisoner)
        {
            return _mapper.Map<Prisoner, PrisonerDto>(prisoner);
        }

        public IEnumerable<PrisonerDto> MapPrisonerDto(IEnumerable<Prisoner> prisoner)
        {
            return _mapper.Map<IEnumerable<PrisonerDto>>(prisoner);
        }
    }
}
