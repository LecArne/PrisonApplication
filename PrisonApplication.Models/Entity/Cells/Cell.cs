using PrisonApplication.Models.Entity.Prisoners;
using PrisonApplication.Models.Entity.Prisons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonApplication.Models.Entity.Cells
{
    public class Cell : BaseAuditableEntity
    {
        public string CellCode { get; set; }

        public int NumberOfPersons { get; set; }

        public int MaxNumberOfPersons { get; set; }

        public TypeOfCell TypeOfCell { get; set; }

        public ICollection<Prisoner> Prisoners { get; set; } = new HashSet<Prisoner>();

        public Cell(string cellCode)
        {
            CellCode = cellCode;
        }

    }
}
