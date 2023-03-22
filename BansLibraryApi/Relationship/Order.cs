using System.ComponentModel.DataAnnotations;

namespace BansLibraryApi.Relationship;

public class Order
{
    [Key]
    public int Id { get; set; }
    public int StudentId { get; set; }
}
