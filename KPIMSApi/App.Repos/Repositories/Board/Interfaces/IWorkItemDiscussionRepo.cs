using KPIMS.Core.Models;

namespace KPIMS.Repos.Repositories.Board.Interfaces
{
    public interface IWorkItemDiscussionRepo
    {
        Task<List<DbWorkItemDiscussion>> GetWorkItemDiscussionsAsync();
        Task<List<DbWorkItemDiscussion>> GetWorkItemDiscussionByWorkItemIdAsync(int workItemId);
        Task<DbWorkItemDiscussion?> GetWorkItemDiscussionByIdAsync(int id);
        Task<DbWorkItemDiscussion> SaveWorkItemDiscussionAsync(DbWorkItemDiscussion model);
        Task<DbWorkItemDiscussion?> UpdateWorkItemDiscussionAsync(DbWorkItemDiscussion model);
        Task<DbWorkItemDiscussion?> DeleteWorkItemDiscussionAsync(int id);
    }
}
