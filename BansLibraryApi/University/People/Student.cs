using BansLibraryApi.University.Bases;

namespace BansLibraryApi.University.People;

public class Student : Base
{
    public Guid? PrefixId { get; set; }
    public string? LastName { get; set; }
    public string? MiddleName { get; set; }
    /// <summary>
    /// this should be auto generated and it should be unique
    /// it should also be in the format of: 2021/0001
    /// </summary>
    public string? IndexNumber { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public Guid? ProgrammeId { get; set; }
}
