using System.ComponentModel.DataAnnotations;

namespace BansLibraryApi.Relationship;

public class Partner
{
    [Key]
    public int Id { get; set; }
    public string? FullName { get; set; }
}
