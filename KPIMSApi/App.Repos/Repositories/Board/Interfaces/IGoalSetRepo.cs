using KPIMS.Core.Models;

namespace KPIMS.Repos.Repositories.Board.Interfaces
{
    public interface IGoalSetRepo
    {
        Task<List<GoalSet>> GetGoalSetsAsync();
        Task<List<GoalSet>> GetGoalSetsByUserIdAsync(int userId);
        Task<GoalSet?> GetGoalSetByIdAsync(int id);
        Task<GoalSet> SaveGoalSetAsync(GoalSet model);
        Task<GoalSet?> UpdateGoalSetsAsync(GoalSet model);
    }
}
