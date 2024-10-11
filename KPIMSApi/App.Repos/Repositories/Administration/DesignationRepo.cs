using KPIMS.Core.Models;
using KPIMS.Repos.Repositories.Administration.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KPIMS.Repos.Repositories.Administration
{
    public class DesignationRepo: IDesignationRepo
    {
        private readonly AppDbContext _appDbContext;
        public DesignationRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<DbDesignation>> GetDesignationsAsync()
        {
            return await _appDbContext.Designations.AsNoTracking().Where(x => !x.IsDeleted).OrderByDescending(x => x.Id).ToListAsync();
        }

        public async Task<DbDesignation?> GetDesignationByIdAsync(int id)
        {
            return await _appDbContext.Designations.AsNoTracking().Where(x => !x.IsDeleted && x.Id == id).SingleOrDefaultAsync();
        }

        public async Task<DbDesignation> SaveDesignationAsync(DbDesignation Designation)
        {
            _appDbContext.Designations.Add(Designation);
            await _appDbContext.SaveChangesAsync();
            return Designation;
        }

        public async Task<DbDesignation?> UpdateDesignationAsync(DbDesignation model)
        {
            var trackedEntity =  _appDbContext.ChangeTracker.Entries<DbDesignation>().FirstOrDefault(e => e.Entity.Id == model.Id);
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
            return await GetDesignationByIdAsync(model.Id);
        }


        public async Task<DbDesignation?> DeleteDesignationAsync(int id)
        {
            var designation = await _appDbContext.Designations.AsNoTracking().SingleOrDefaultAsync(b => b.Id == id && !b.IsDeleted);
            if (designation is null)
                throw new Exception("Designation not found for update!");

            designation.IsDeleted = true;
            return await UpdateDesignationAsync(designation);
        }

    }
}
