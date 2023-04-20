using BansLibrary.Core.Interfaces.Repositories;
using BansLibrary.Core.Models;

namespace BansLibrary.Infrastructure.Repositories;

public class StaffRepository : IStaffRepository
{
    public Task<IEnumerable<Staff>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Staff> GetById(Guid? id)
    {
        throw new NotImplementedException();
    }
}
