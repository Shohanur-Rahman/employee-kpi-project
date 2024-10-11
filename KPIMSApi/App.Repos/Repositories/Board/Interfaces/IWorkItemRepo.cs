using KPIMS.Core.Models;
using KPIMS.Core.Utilities;

namespace KPIMS.Repos.Repositories.Board.Interfaces
{
    public interface IWorkItemRepo
    {
        Task<List<DbWorkItem>> GetWorkItemsAsync();
        Task<List<DbWorkItemLog>> GetWorkImteChangeLogAsync(int workItemId);
        Task<List<DbWorkItem>> GetWorkItemsByTypeAsync(WorksType typeId, int projectId);
        Task<List<DbWorkItem>> GetWorkItemsByProjectAsync(int projectId);
        Task<DbWorkItem?> GetWorkItemByIdAsync(int id);
        Task<DbWorkItem> SaveWorkItemAsync(DbWorkItem model);
        Task<DbWorkItem?> UpdateWorkItemAsync(DbWorkItem model);
        Task<DbWorkItem?> DeleteWorkItemAsync(int id);
    }
}
