using BansLibraryApi.University.Bases;

namespace BansLibraryApi.University.People;

public class Family : Base
{
    public Guid? StaffId { get; set; }
    public string? PhoneNumber { get; set; }
    public FamilyType FamilyType { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? Residence { get; set; }
}
