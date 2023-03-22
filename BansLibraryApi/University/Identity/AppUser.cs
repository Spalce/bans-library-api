using System.ComponentModel.DataAnnotations;

namespace BansLibraryApi.University.Identity;

public class AppUser
{
    [Key]
    public Guid? Id { get; set; }
    public string? UserName { get; set; }
}
