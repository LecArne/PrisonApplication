using PrisonApplication.Contracts.Dtos.PrisonGroups;
using PrisonApplication.Contracts.Dtos.Prisons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonApplication.Contracts.Queries.Prisons
{
    public class GetPrisonByIdQuery : QueryBase<PrisonDto>
    {
        public Guid Id { get; set; }

        public GetPrisonByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
