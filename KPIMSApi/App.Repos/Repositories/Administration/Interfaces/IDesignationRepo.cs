using KPIMS.Core.Models;

namespace KPIMS.Repos.Repositories.Administration.Interfaces
{
    public interface IDesignationRepo
    {
        Task<List<DbDesignation>> GetDesignationsAsync();
        Task<DbDesignation?> GetDesignationByIdAsync(int id);
        Task<DbDesignation> SaveDesignationAsync(DbDesignation Designation);
        Task<DbDesignation?> UpdateDesignationAsync(DbDesignation model);
        Task<DbDesignation?> DeleteDesignationAsync(int id);
    }
}
