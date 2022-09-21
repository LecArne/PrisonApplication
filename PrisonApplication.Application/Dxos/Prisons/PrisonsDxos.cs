using AutoMapper;
using PrisonApplication.Contracts.Dtos.PrisonGroups;
using PrisonApplication.Contracts.Dtos.Prisons;
using PrisonApplication.Models.Entity.PrisonGroups;
using PrisonApplication.Models.Entity.Prisons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PrisonApplication.Application.Dxos.Prisons
{
    public interface IPrisonsDxos
    {
        PrisonDto MapPrisonDto(Prison prison);
        IEnumerable<PrisonDto> MapPrisonDto(IEnumerable<Prison> prison);
    }
    public class PrisonsDxos : IPrisonsDxos
    {
        private readonly IMapper _mapper;

        public PrisonsDxos()
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Prison, PrisonDto>(); });
            _mapper = config.CreateMapper();
        }

        public PrisonDto MapPrisonDto(Prison prison)
        {
            return _mapper.Map<Prison, PrisonDto>(prison);
        }

        IEnumerable<PrisonDto> IPrisonsDxos.MapPrisonDto(IEnumerable<Prison> prison)
        {
            return _mapper.Map<IEnumerable<PrisonDto>>(prison);
        }
    }
}
