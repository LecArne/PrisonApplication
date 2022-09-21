using PrisonApplication.Models;
using PrisonApplication.Models.Entity.Prisons;
using System.ComponentModel.DataAnnotations;

namespace PrisonApplication.Models.Entity.PrisonGroups;

public class PrisonGroup : BaseAuditableEntity
{
    [Required]
    public string Name { get; set; }

    #region Address
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? Zip { get; set; }
    public string? Street { get; set; }
    public string? Nr { get; set; }
    #endregion

    public virtual ICollection<Prison> Prisons { get; set; } = new HashSet<Prison>();
    public bool IsDeleted => false;

    public PrisonGroup(string name)
    {
        Name = name;
    }
}