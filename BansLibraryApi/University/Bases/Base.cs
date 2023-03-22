using System.ComponentModel.DataAnnotations;

namespace BansLibraryApi.University.Bases;

public class Base
{
    [Key]
    public Guid? Id { get; set; }
    public string? Name { get; set; } // Facebook, Google, Microsoft, etc.
    public DateTime? DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? UpdatedBy { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
}
