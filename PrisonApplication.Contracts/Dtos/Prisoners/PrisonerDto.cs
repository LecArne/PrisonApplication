using PrisonApplication.Models.Entity.Cells;
using PrisonApplication.Models.Entity.Prisoners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonApplication.Contracts.Dtos.Prisoners
{
    public class PrisonerDto
    {
        public string Name { get; set; }

        public string FirstName { get; set; }

        public Gender Gender { get; set; }

        public string? ReasonInJail { get; set; }

        public virtual Cell Cell { get; set; }

        #region Address
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Zip { get; set; }
        public string? Street { get; set; }
        public string? Nr { get; set; }
        #endregion

        public int TotalTermInMonths { get; set; }

        public bool CanComeOutEarly { get; set; }
    }
}
