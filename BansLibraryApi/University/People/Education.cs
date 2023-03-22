using BansLibraryApi.University.Bases;

namespace BansLibraryApi.University.People;

public class Education : Base
{
    public Guid? StaffId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? StartEnd { get; set; }
    public string? Certificate { get; set; }
    public string? CertificateNo { get; set; }
    public bool IsNotCompleted { get; set; }
    public string? ProgrammeName { get; set; }
}
