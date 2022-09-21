using PrisonApplication.Models.Entity.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonApplication.Models.Entity.Prisoners
{
    public class Prisoner : BaseAuditableEntity
    {
        public string Name { get; set; }

        public string FirstName { get; set; }

        public Gender Gender { get; set; }

        public string? ReasonInJail { get; set; }

        public virtual Cell Cell { get; set; }

        public Prisoner(string name, string firstName, Gender gender)
        {
            FirstName = firstName;
            Name = name;
            Gender = gender;
        }

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
