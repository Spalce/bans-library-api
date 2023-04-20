using BansLibrary.Core.Interfaces.Repositories;
using BansLibrary.Core.Interfaces.Services;
using BansLibrary.Core.Models;

namespace BansLibrary.Core.Services;

public class StaffService : IStaffService
{
    private readonly IStaffRepository _staffRepository;

    public StaffService(IStaffRepository staffRepository)
    {
        _staffRepository = staffRepository;
    }

    public Task<IEnumerable<Staff>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Staff> GetById(Guid? id)
    {
        return _staffRepository.GetById(id);
    }
}
