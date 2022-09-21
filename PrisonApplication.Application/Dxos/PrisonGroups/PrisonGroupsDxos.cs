using AutoMapper;
using PrisonApplication.Contracts.Dtos.PrisonGroups;
using PrisonApplication.Models.Entity.PrisonGroups;

namespace PrisonApplication.Application.Dxos.PrisonGroups
{
    public interface IPrisonGroupsDxos
    {
        PrisonGroupDto MapPrisonGroupDto(PrisonGroup prisonGroup);
        IEnumerable<PrisonGroupDto> MapPrisonGroupDto(IEnumerable<PrisonGroup> prisonGroups);
    }
    public class PrisonGroupsDxos : IPrisonGroupsDxos
    {
        private readonly IMapper _mapper;

        public PrisonGroupsDxos()
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<PrisonGroup, PrisonGroupDto>(); });
            _mapper = config.CreateMapper();
        }

        public PrisonGroupDto MapPrisonGroupDto(PrisonGroup prisonGroup)
        {
            return _mapper.Map<PrisonGroup, PrisonGroupDto>(prisonGroup);
        }

        public IEnumerable<PrisonGroupDto> MapPrisonGroupDto(IEnumerable<PrisonGroup> prisonGroups)
        {
            return _mapper.Map<IEnumerable<PrisonGroupDto>>(prisonGroups);
        }
    }
}
