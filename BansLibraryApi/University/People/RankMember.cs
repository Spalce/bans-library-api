using BansLibraryApi.University.Bases;

namespace BansLibraryApi.University.People;

public class RankMember : Base
{
    /// <summary>
    /// ensure that staff a staff does not
    /// have more than one rank at a time
    /// flag all past ranks as inactive
    /// </summary>
    public Guid? StaffId { get; set; }
    public Guid? RankId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}
