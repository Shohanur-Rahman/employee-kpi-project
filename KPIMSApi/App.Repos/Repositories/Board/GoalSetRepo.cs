using AutoMapper;
using KPIMS.Core.Models;
using KPIMS.Repos.Repositories.Board.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KPIMS.Repos.Repositories.Board
{
    public class GoalSetRepo: IGoalSetRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public GoalSetRepo(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<List<GoalSet>> GetGoalSetsAsync()
        {
            return await _appDbContext.GoalSets.AsNoTracking().Where(x => !x.IsDeleted).OrderByDescending(x => x.Id).ToListAsync();
        }

        public async Task<List<GoalSet>> GetGoalSetsByUserIdAsync(int userId)
        {
            return await _appDbContext.GoalSets.AsNoTracking().Where(x => !x.IsDeleted && x.CreatedId == userId).OrderByDescending(x => x.Id).ToListAsync();
        }

        public async Task<GoalSet?> GetGoalSetByIdAsync(int id)
        {
            return await _appDbContext.GoalSets.AsNoTracking().SingleOrDefaultAsync(x => !x.IsDeleted && x.Id == id);
        }

        public async Task<GoalSet> SaveGoalSetAsync(GoalSet model)
        {
            _appDbContext.GoalSets.Add(model);
            await _appDbContext.SaveChangesAsync();
            return model;
        }

        public async Task<GoalSet?> UpdateGoalSetsAsync(GoalSet model)
        {

            var project = await _appDbContext.GoalSets.AsNoTracking().SingleOrDefaultAsync(b => b.Id == model.Id);

            if (project is null)
                throw new Exception("Goal not found for update!");

            var trackedEntity = _appDbContext.ChangeTracker.Entries<GoalSet>().FirstOrDefault(e => e.Entity.Id == model.Id);
            if (trackedEntity != null)
            {
                _appDbContext.Entry(trackedEntity.Entity).CurrentValues.SetValues(model);
            }
            else
            {
                _appDbContext.Attach(model);
                _appDbContext.Entry(model).State = EntityState.Modified;
            }
            await _appDbContext.SaveChangesAsync();
            return await GetGoalSetByIdAsync(model.Id);
        }

    }
}
