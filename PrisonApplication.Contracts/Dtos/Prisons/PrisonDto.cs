using PrisonApplication.Models.Entity.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonApplication.Contracts.Dtos.Prisons
{
    public class PrisonDto
    {
        public string Name { get; set; }
        public string? Email { get; set; }
        public int MaxCapacity { get; set; }

        #region Address
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Zip { get; set; }
        public string? Street { get; set; }
        public string? Nr { get; set; }
        #endregion

        public virtual List<Cell> Cells { get; set; }
    }
}
