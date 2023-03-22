using BansLibraryApi.University.Bases;

namespace BansLibraryApi.University.Faculties;

public class Course : Base
{
    public Guid? ProgrammeId { get; set; }
    public string? Code { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? StartEmd { get; set; }
    public Guid? LevelId { get; set; }
}
