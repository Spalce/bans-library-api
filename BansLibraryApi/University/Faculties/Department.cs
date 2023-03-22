using BansLibraryApi.University.Bases;

namespace BansLibraryApi.University.Faculties;

public class Department : Base
{
    public Guid? FacultyId { get; set; }
    public string? Description { get; set; }
}
