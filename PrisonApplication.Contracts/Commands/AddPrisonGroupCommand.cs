using PrisonApplication.Contracts.Dtos.PrisonGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonApplication.Contracts.Commands
{
    public class AddPrisonGroupCommand : CommandBase<PrisonGroupDto>
    {
        public string Name { get; set; }

        #region Address
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Zip { get; set; }
        public string? Street { get; set; }
        public string? Nr { get; set; }
        #endregion
    }
}
