using BansLibraryApi.University.Bases;

namespace BansLibraryApi.University.Faculties;

public class Division : Base
{
    public Guid? DepartmentId { get; set; }
    public string? Description { get; set; }
}
