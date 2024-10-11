using AutoMapper;
using KPIMS.Core.Models;
using KPIMS.Core.UiModels;
using KPIMS.Core.Utilities;
using KPIMS.Repos.Repositories.Administration.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KPIMS.Repos.Repositories.Administration
{
    public class EmployeeRepo: IEmployeeRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;
        public EmployeeRepo(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<List<DbEmployee>> GetEmployeesAsync()
        {
            return await _appDbContext.Employees.AsNoTracking().Where(x => !x.IsDeleted).Include(x => x.Designation).OrderByDescending(x => x.Id).ToListAsync();
        }

        public async Task<List<DbEmployee>> GetEmployeesOnlyAsync()
        {
            return await _appDbContext.Employees.AsNoTracking().Where(x => !x.IsDeleted).OrderBy(x => x.FirstName).ToListAsync();
        }

        public async Task<DbEmployee?> GetEmployeeByIdAsync(int id)
        {
            return await _appDbContext.Employees.AsNoTracking().Include(x => x.Designation).SingleOrDefaultAsync(x => !x.IsDeleted && x.Id == id);
        }

        public async Task<DbEmployee?> GetEmployeeByEmailAsync(string email)
        {
            return await _appDbContext.Employees.AsNoTracking().Include(x => x.Designation).SingleOrDefaultAsync(x => !x.IsDeleted && x.Email == email);
        }

        public async Task<DbEmployee> SaveEmployeeAsync(DbEmployee model)
        {
            var employee = await _appDbContext.Employees.AsNoTracking().SingleOrDefaultAsync(b => b.Email == model.Email);
           
            if(employee is not null)
            {
                throw new InvalidOperationException("Email already exists.");
            }

            model.PasswordSalt = EncryptPassword.GetSalt();
            model.Password = EncryptPassword.GetHas(model.Password, model.PasswordSalt);
            _appDbContext.Employees.Add(model);
            await _appDbContext.SaveChangesAsync();
            return model;
        }


        public async Task<DbEmployee?> UpdateEmployeeAsync(DbEmployee model)
        {
            var isExist = await _appDbContext.Employees.AsNoTracking().AnyAsync(b => b.Id != model.Id && b.Email == model.Email);
            if (isExist)
            {
                throw new InvalidOperationException("Email already exists.");
            }

            var employee = await _appDbContext.Employees.AsNoTracking().SingleOrDefaultAsync(b => b.Id == model.Id && !b.IsDeleted);
            if (employee is null)
                throw new Exception("Employee not found for update!");

            var trackedEntity = _appDbContext.ChangeTracker.Entries<DbEmployee>().FirstOrDefault(e => e.Entity.Id == model.Id);
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
            return await GetEmployeeByIdAsync(model.Id);
        }

        public async Task<DbEmployee?> DeleteEmployeeAsync(int id)
        {
            var employee = await _appDbContext.Employees.AsNoTracking().SingleOrDefaultAsync(b => b.Id == id && !b.IsDeleted);
            if (employee is null)
                throw new Exception("Employee not found for update!");

            employee.IsDeleted = true;
            _appDbContext.Entry(employee).State = EntityState.Modified;
            return await UpdateEmployeeAsync(employee);
        }

        public async Task<DbEmployee?> UpdatePasswordAsync(ChangePassword model)
        {
            

            var employee = await _appDbContext.Employees.AsNoTracking().SingleOrDefaultAsync(b => b.Email == model.Email);
            if (employee is null)
                throw new Exception("Employee not found for update!");

            if (!EncryptPassword.IsValid(model.OldPassword, employee.PasswordSalt, employee.Password))
                throw new Exception("Invalid Old Password!");

            employee.PasswordSalt = model.ConfirmPassword;
            employee.Password = EncryptPassword.GetHas(model.ConfirmPassword, model.ConfirmPassword);
            return await UpdateEmployeeAsync(employee);
        }

        public async Task<DbEmployee> GetAutheticateEmployeeAsync(LoginModel model)
        {
            var employee = await _appDbContext.Employees.Where(x => x.Email.ToLower() == model.Email.ToLower() && !x.IsDeleted)
                .Include(x => x.Designation)
                .AsNoTracking()
                .SingleOrDefaultAsync();

            if (employee is null)
                throw new Exception("Employee not found");

            if (!EncryptPassword.IsValid(model.Password, employee.PasswordSalt, employee.Password))
                throw new Exception("Invalid login credential");


            return employee;
        }

    }
}
