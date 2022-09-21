using PrisonApplication.Contracts.Dtos.PrisonGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonApplication.Contracts.Queries.PrisonGroups
{
    public class GetPrisongroupByIdQuery : QueryBase<PrisonGroupDto>
    {
        public Guid Id { get; set; }

        public GetPrisongroupByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
