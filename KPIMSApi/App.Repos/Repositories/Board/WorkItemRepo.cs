using AutoMapper;
using KPIMS.Core.Models;
using KPIMS.Core.Utilities;
using KPIMS.Repos.Repositories.Board.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace KPIMS.Repos.Repositories.Board
{
    public class WorkItemRepo: IWorkItemRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public WorkItemRepo(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<List<DbWorkItem>> GetWorkItemsAsync()
        {
            return await _appDbContext.WorkItems.AsNoTracking().Where(x => !x.IsDeleted).OrderByDescending(x => x.Id).ToListAsync();
        }

        public async Task<List<DbWorkItem>> GetWorkItemsByTypeAsync(WorksType typeId, int projectId)
        {
            return await _appDbContext.WorkItems.Where(x => x.WorkTypeId == (int) typeId && !x.IsDeleted && x.ProjectId == projectId)
                .Include(x => x.SubWorks)
                .ThenInclude(x => x.SubWorks)
                .ThenInclude(x => x.SubWorks)
                .AsNoTracking()
                .OrderByDescending(x => x.Id)
                .ToListAsync();
        }

        public async Task<List<DbWorkItem>> GetWorkItemsByProjectAsync(int projectId)
        {
            return await _appDbContext.WorkItems.Where(x => x.ProjectId == projectId && !x.IsDeleted).AsNoTracking().OrderByDescending(x => x.Id).ToListAsync();
        }

        public async Task<DbWorkItem?> GetWorkItemByIdAsync(int id)
        {
            return await _appDbContext.WorkItems.AsNoTracking().SingleOrDefaultAsync(x => !x.IsDeleted && x.Id == id);
        }

        

        public async Task<DbWorkItem> SaveWorkItemAsync(DbWorkItem model)
        {
            _appDbContext.WorkItems.Add(model);
            await _appDbContext.SaveChangesAsync();
            // Save work item log
            DbWorkItemLog log = new DbWorkItemLog();
            log = _mapper.Map<DbWorkItemLog>(model);
            log.Id = 0;
            log.WorkItemId = model.Id;
            log.LogType = "ADDED";
            await SaveWorkItemLogAsync(log);
            return model;
        }

        public async Task<DbWorkItemLog> SaveWorkItemLogAsync(DbWorkItemLog model)
        {
            _appDbContext.WorkItemLogs.Add(model);
            await _appDbContext.SaveChangesAsync();
            return model;
        }

        public async Task<List<DbWorkItemLog>> GetWorkImteChangeLogAsync(int workItemId)
        {
            return await _appDbContext.WorkItemLogs.Where(x => x.WorkItemId == workItemId)
                .Include(x => x.WorkType)
                .Include(x => x.State)
                .AsNoTracking()
                .OrderByDescending(x => x.Id)
                .ToListAsync();
        }

        public async Task<DbWorkItem?> UpdateWorkItemAsync(DbWorkItem model)
        {

            var project = await _appDbContext.WorkItems.AsNoTracking().SingleOrDefaultAsync(b => b.Id == model.Id);

            if (project is null)
                throw new Exception("Work not found for update!");

            var trackedEntity = _appDbContext.ChangeTracker.Entries<DbWorkItem>().FirstOrDefault(e => e.Entity.Id == model.Id);
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

            // Save work item log
            DbWorkItemLog log = new DbWorkItemLog();
            log = _mapper.Map<DbWorkItemLog>(model);
            log.Id = 0;
            log.WorkItemId = model.Id;
            log.LogType = "UPDATED";
            await SaveWorkItemLogAsync(log);

            return await GetWorkItemByIdAsync(model.Id);
        }

        public async Task<DbWorkItem?> DeleteWorkItemAsync(int id)
        {
            var project = await _appDbContext.WorkItems.AsNoTracking().SingleOrDefaultAsync(b => b.Id == id);
            if (project is null)
                throw new Exception("Work not found for update!");

            project.IsDeleted = true;
            _appDbContext.Entry(project).State = EntityState.Modified;
            return await UpdateWorkItemAsync(project);
        }


    }
}
