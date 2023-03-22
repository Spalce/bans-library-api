using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BansLibraryApi.Relationship;

public class Contact
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("StudentId")]
    public Student? Student { get; set; }
    public int StudentId { get; set; }
}
