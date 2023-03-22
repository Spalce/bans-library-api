using BansLibraryApi.University.Bases;

namespace BansLibraryApi.University.Faculties;

public class Faculty : Base
{
    public string? Description { get; set; }
    public DateTime? DateFounded { get; set; }
    public DateTime? DateEnded { get; set; }
}
