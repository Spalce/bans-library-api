using System.ComponentModel.DataAnnotations;

namespace BansLibraryApi.Relationship;

public class Course
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }

    public List<Student>? Students { get; set; }
}
