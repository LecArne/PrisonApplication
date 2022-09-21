using AutoMapper;
using PrisonApplication.Contracts.Dtos.Cells;
using PrisonApplication.Contracts.Dtos.Prisoners;
using PrisonApplication.Contracts.Dtos.Prisons;
using PrisonApplication.Models.Entity.Cells;
using PrisonApplication.Models.Entity.Prisoners;
using PrisonApplication.Models.Entity.Prisons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonApplication.Application.Dxos.Cells
{
    public interface ICellsDxos
    {
        CellDto MapCellDto(Cell cell);
        IEnumerable<CellDto> MapCellDto(IEnumerable<Cell> cell);
    }

    public class CellsDxos : ICellsDxos
    {
        private readonly IMapper _mapper;
        public CellsDxos()
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Cell, CellDto>(); });
            _mapper = config.CreateMapper();
        }
        public CellDto MapCellDto(Cell cell)
        {
            return _mapper.Map<Cell, CellDto>(cell);
        }

        public IEnumerable<CellDto> MapCellDto(IEnumerable<Cell> cell)
        {
            return _mapper.Map<IEnumerable<CellDto>>(cell);
        }
    }
}
