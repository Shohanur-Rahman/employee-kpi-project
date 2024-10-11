using KPIMS.Core.Models;

namespace KPIMS.Repos.Repositories.Board.Interfaces
{
    public interface IProjectRepo
    {
        Task<List<DbProject>> GetProjectsAsync();
        Task<DbProject?> GetProjectByIdAsync(int id);
        Task<DbProject> SaveProjectAsync(DbProject model);
        Task<DbProject?> UpdateProjectAsync(DbProject model);
        Task<DbProject?> DeleteProjectAsync(int id);
    }
}
