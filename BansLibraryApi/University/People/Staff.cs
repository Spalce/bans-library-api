using BansLibraryApi.University.Bases;

namespace BansLibraryApi.University.People;

public class Staff : Base
{
    public Guid? PrefixId { get; set; }
    public string? LastName { get; set; }
    public string? MiddleName { get; set; }
    /// <summary>
    /// this should be auto generated and it should be unique
    /// it should also be in the format of: AA-000000-23
    /// </summary>
    public string? EmployeeNumber { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public bool NonTeaching { get; set; }
}
