using System.ComponentModel.DataAnnotations;

namespace BansLibraryApi.Relationship;

public class Elder
{
    [Key]
    public int Id { get; set; }
    public string? FullName { get; set; }
    // what is the larger class
    public Partner? Partner { get; set; }
    public int PartnerId { get; set; }
}
