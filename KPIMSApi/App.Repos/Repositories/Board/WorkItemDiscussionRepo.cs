using AutoMapper;
using KPIMS.Core.Models;
using KPIMS.Repos.Repositories.Board.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KPIMS.Repos.Repositories.Board
{
    public class WorkItemDiscussionRepo: IWorkItemDiscussionRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public WorkItemDiscussionRepo(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<List<DbWorkItemDiscussion>> GetWorkItemDiscussionsAsync()
        {
            return await _appDbContext.WorkItemDiscussions.AsNoTracking().Where(x => !x.IsDeleted).OrderByDescending(x => x.Id).ToListAsync();
        }

        public async Task<List<DbWorkItemDiscussion>> GetWorkItemDiscussionByWorkItemIdAsync(int workItemId)
        {
            return await _appDbContext.WorkItemDiscussions.Where(x => x.WorkItemId == workItemId)
                .Include(e => e.Employee)
                .AsNoTracking()
                .OrderByDescending(x => x.Id)
                .ToListAsync();
        }

        public async Task<DbWorkItemDiscussion?> GetWorkItemDiscussionByIdAsync(int id)
        {
            return await _appDbContext.WorkItemDiscussions.AsNoTracking().SingleOrDefaultAsync(x => !x.IsDeleted && x.Id == id);
        }

        public async Task<DbWorkItemDiscussion> SaveWorkItemDiscussionAsync(DbWorkItemDiscussion model)
        {
            _appDbContext.WorkItemDiscussions.Add(model);
            await _appDbContext.SaveChangesAsync();
            return model;
        }

        public async Task<DbWorkItemDiscussion?> UpdateWorkItemDiscussionAsync(DbWorkItemDiscussion model)
        {

            var project = await _appDbContext.WorkItemDiscussions.AsNoTracking().SingleOrDefaultAsync(b => b.Id == model.Id);

            if (project is null)
                throw new Exception("Work not found for update!");

            var trackedEntity = _appDbContext.ChangeTracker.Entries<DbWorkItemDiscussion>().FirstOrDefault(e => e.Entity.Id == model.Id);
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
            return await GetWorkItemDiscussionByIdAsync(model.Id);
        }

        public async Task<DbWorkItemDiscussion?> DeleteWorkItemDiscussionAsync(int id)
        {
            var project = await _appDbContext.WorkItemDiscussions.AsNoTracking().SingleOrDefaultAsync(b => b.Id == id);
            if (project is null)
                throw new Exception("Work not found for update!");

            project.IsDeleted = true;
            _appDbContext.Entry(project).State = EntityState.Modified;
            return await UpdateWorkItemDiscussionAsync(project);
        }
    }
}
