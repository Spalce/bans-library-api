using BansLibrary.Core.Models;

namespace BansLibrary.Core.Interfaces.Services;

public interface IStaffService
{
    Task<IEnumerable<Staff>> GetAllAsync();
    Task<Staff> GetById(Guid? id);
}
