using System.ComponentModel.DataAnnotations;

namespace BansLibraryApi.Models;

public class Base
{
    [Key]
    public Guid Id { get; set; }
    public bool IsActive { get; set; }
}
