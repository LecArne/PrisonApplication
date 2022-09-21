using PrisonApplication.Models.Entity.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonApplication.Models.Entity.Prisons
{
    public class Prison : BaseAuditableEntity
    {
        public string Name { get; set; }

        public Prison(string name)
        {
            Name = name;
        }

        public string? Email { get; set; }
        public int MaxCapacity { get; set; }

        #region Address
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Zip { get; set; }
        public string? Street { get; set; }
        public string? Nr { get; set; }
        #endregion

        public virtual ICollection<Cell> Cells { get; set; } = new HashSet<Cell>();

    }
}
