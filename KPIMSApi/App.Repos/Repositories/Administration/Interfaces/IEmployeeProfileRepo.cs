using KPIMS.Core.Models;

namespace KPIMS.Repos.Repositories.Administration.Interfaces
{
    public interface IEmployeeProfileRepo
    {
        Task<List<DbEmployeeProfile>> GetEmployeeProfilesAsync();
        Task<DbEmployeeProfile?> GetEmployeeProfileByIdAsync(int id);
        Task<DbEmployeeProfile?> GetEmployeeProfileByEmployeeIdAsync(int id);
        Task<DbEmployeeProfile> SaveEmployeeProfileAsync(DbEmployeeProfile model);
        Task<DbEmployeeProfile?> UpdateEmployeeProfileAsync(DbEmployeeProfile model);
        Task<int> DeleteEmployeeProfileAsync(int id);
        Task<DbEmployeeProfile?> SaveOrUpdateEmployeeProfileAsync(DbEmployeeProfile model);

    }
}
