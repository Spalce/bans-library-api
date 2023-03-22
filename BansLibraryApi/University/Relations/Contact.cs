using BansLibraryApi.University.Bases;

namespace BansLibraryApi.University.Relations;

public class Contact : Base
{
    public Guid? EntityId { get; set; }
    public string? Content { get; set; } // link, email, phone number, etc.
}
