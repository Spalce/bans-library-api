using System.ComponentModel.DataAnnotations;

namespace BansLibraryApi.Relationship;

public class Student
{
    [Key]
    public int Id { get; set; }

    public string? FullName { get; set; }

    public List<Course>? Courses { get; set; }
}
