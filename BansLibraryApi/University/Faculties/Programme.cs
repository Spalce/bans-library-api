using BansLibraryApi.University.Bases;

namespace BansLibraryApi.University.Faculties;

public class Programme : Base
{
    public Guid? FacultyId { get; set; }
    public string? Code { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? StartEmd { get; set; }
}
