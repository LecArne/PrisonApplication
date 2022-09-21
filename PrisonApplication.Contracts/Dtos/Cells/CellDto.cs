using PrisonApplication.Models.Entity.Cells;
using PrisonApplication.Models.Entity.Prisoners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonApplication.Contracts.Dtos.Cells
{
    public class CellDto
    {
        public string CellCode { get; set; }
        public int NumberOfPersons { get;set; }
        public int MaxNumberOfPersons { get; set; }

        public TypeOfCell TypeOfCell { get; set; }

        public List<Prisoner> Prisoners { get; set; }

    }
}
