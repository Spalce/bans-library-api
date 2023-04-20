using System.ComponentModel.DataAnnotations;

namespace BansLibrary.Infrastructure.Models;

public class Base
{
    [Key]
    public Guid Id { get; set; }
    public bool IsActive { get; set; }
}
