using System.ComponentModel.DataAnnotations.Schema;

namespace BansLibraryApi.Models;

public class Contact : Base
{
    [ForeignKey("StudentId")]
    public Student? Student { get; set; }
    public Guid? StudentId { get; set; }
    public string? Content { get; set; }
}
