using BansLibrary.Core.Models;

namespace BansLibrary.Core.Interfaces.Repositories;

public interface IStaffRepository
{
    Task<IEnumerable<Staff>> GetAllAsync();
    Task<Staff> GetById(Guid? id);
}
