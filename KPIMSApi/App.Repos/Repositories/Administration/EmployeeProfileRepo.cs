using AutoMapper;
using KPIMS.Core.Models;
using KPIMS.Core.Utilities;
using KPIMS.Repos.Repositories.Administration.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KPIMS.Repos.Repositories.Administration
{
    public class EmployeeProfileRepo: IEmployeeProfileRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;
        public EmployeeProfileRepo(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<List<DbEmployeeProfile>> GetEmployeeProfilesAsync()
        {
            return await _appDbContext.EmployeeProfiles.AsNoTracking().Where(x => !x.IsDeleted).Include(x => x.Employee).OrderByDescending(x => x.Id).ToListAsync();
        }

        public async Task<DbEmployeeProfile?> GetEmployeeProfileByIdAsync(int id)
        {
            return await _appDbContext.EmployeeProfiles.AsNoTracking().Include(x => x.Employee).SingleOrDefaultAsync(x => !x.IsDeleted && x.Id == id);
        }

        public async Task<DbEmployeeProfile?> GetEmployeeProfileByEmployeeIdAsync(int id)
        {
            return await _appDbContext.EmployeeProfiles.AsNoTracking().Include(x => x.Employee).SingleOrDefaultAsync(x => x.EmployeeId == id);
        }

        public async Task<DbEmployeeProfile?> SaveOrUpdateEmployeeProfileAsync(DbEmployeeProfile model)
        {
            var profile = await _appDbContext.EmployeeProfiles.AsNoTracking().AnyAsync(b => b.EmployeeId == model.EmployeeId);

            if(!profile)
            {
                return await SaveEmployeeProfileAsync(model);
            }
            else
            {
                return await UpdateEmployeeProfileAsync(model);
            }

        }
        public async Task<DbEmployeeProfile> SaveEmployeeProfileAsync(DbEmployeeProfile model)
        {
            _appDbContext.EmployeeProfiles.Add(model);
            await _appDbContext.SaveChangesAsync();
            return model;
        }

        public async Task<DbEmployeeProfile?> UpdateEmployeeProfileAsync(DbEmployeeProfile model)
        {
           
            var profile = await _appDbContext.EmployeeProfiles.AsNoTracking().SingleOrDefaultAsync(b => b.Id == model.Id && !b.IsDeleted);
            if (profile is null)
                throw new Exception("Profile not found for update!");

            profile = _mapper.Map<DbEmployeeProfile>(model);
            _appDbContext.Entry(profile).State = EntityState.Modified;
            await _appDbContext.SaveChangesAsync();
            return profile;
        }

        public async Task<int> DeleteEmployeeProfileAsync(int id)
        {
            var employee = await _appDbContext.EmployeeProfiles.AsNoTracking().SingleOrDefaultAsync(b => b.Id == id && !b.IsDeleted);
            if (employee is null)
                throw new Exception("Profile not found for update!");

            employee.IsDeleted = true;
            _appDbContext.Entry(employee).State = EntityState.Modified;
            return await _appDbContext.SaveChangesAsync();
        }

    }
}
