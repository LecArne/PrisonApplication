using PrisonApplication.Contracts.Dtos.PrisonGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonApplication.Contracts.Queries.PrisonGroups
{
    public class GetAllPrisongroupsQuery : QueryBase<IEnumerable<PrisonGroupDto>>
    {
    }
}
