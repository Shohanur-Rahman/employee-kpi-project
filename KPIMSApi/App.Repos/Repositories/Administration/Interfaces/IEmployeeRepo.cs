using KPIMS.Core.Models;
using KPIMS.Core.UiModels;

namespace KPIMS.Repos.Repositories.Administration.Interfaces
{
    public interface IEmployeeRepo
    {
        Task<List<DbEmployee>> GetEmployeesAsync();
        Task<List<DbEmployee>> GetEmployeesOnlyAsync();
        Task<DbEmployee?> GetEmployeeByIdAsync(int id);
        Task<DbEmployee?> GetEmployeeByEmailAsync(string email);
        Task<DbEmployee> SaveEmployeeAsync(DbEmployee model);
        Task<DbEmployee?> UpdateEmployeeAsync(DbEmployee model);
        Task<DbEmployee?> DeleteEmployeeAsync(int id);
        Task<DbEmployee?> UpdatePasswordAsync(ChangePassword model);
        Task<DbEmployee> GetAutheticateEmployeeAsync(LoginModel model);
    }
}
