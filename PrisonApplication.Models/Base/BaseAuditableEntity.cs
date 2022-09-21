using System.ComponentModel.DataAnnotations;

namespace PrisonApplication.Models;

public abstract class BaseAuditableEntity : BaseEntity
{
    [DataType(DataType.Date)]
    public DateTime Created { get; set; }
    [DataType(DataType.Date)]
    public DateTime Modified { get; set; }
}