namespace BansLibraryApi.Models;

public class Student : Base
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime? DateOfBirth { get; set; }
}