using AutoMapper;
using KPIMS.Core.Models;
using KPIMS.Core.Utilities;
using KPIMS.Repos.Repositories.Board.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KPIMS.Repos.Repositories.Board
{
    public class ProjectRepo: IProjectRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public ProjectRepo(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<List<DbProject>> GetProjectsAsync()
        {
            return await _appDbContext.Projects.AsNoTracking().Where(x => !x.IsDeleted).OrderByDescending(x => x.Id).ToListAsync();
        }

        public async Task<DbProject?> GetProjectByIdAsync(int id)
        {
            return await _appDbContext.Projects.AsNoTracking().SingleOrDefaultAsync(x => !x.IsDeleted && x.Id == id);
        }

        public async Task<DbProject> SaveProjectAsync(DbProject model)
        {
            _appDbContext.Projects.Add(model);
            await _appDbContext.SaveChangesAsync();
            return model;
        }

        public async Task<DbProject?> UpdateProjectAsync(DbProject model)
        {

            var project = await _appDbContext.Projects.AsNoTracking().SingleOrDefaultAsync(b => b.Id == model.Id);

            if (project is null)
                throw new Exception("Project not found for update!");

            var trackedEntity = _appDbContext.ChangeTracker.Entries<DbProject>().FirstOrDefault(e => e.Entity.Id == model.Id);
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
            return await GetProjectByIdAsync(model.Id);
        }

        public async Task<DbProject?> DeleteProjectAsync(int id)
        {
            var project = await _appDbContext.Projects.AsNoTracking().SingleOrDefaultAsync(b => b.Id == id);
            if (project is null)
                throw new Exception("Project not found for update!");

            project.IsDeleted = true;
            _appDbContext.Entry(project).State = EntityState.Modified;
            return await UpdateProjectAsync(project);
        }


    }
}
