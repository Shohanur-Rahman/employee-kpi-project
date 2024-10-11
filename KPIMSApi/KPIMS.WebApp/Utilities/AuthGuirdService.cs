using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using KPIMS.Core.Models;
using KPIMS.Repos.Repositories.Administration.Interfaces;
using KPIMS.Core.UiModels;
using KPIMS.Repos.Repositories.Administration;

namespace KPIMS.WebApp.Utilities
{
    public class AuthGuirdService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IEmployeeRepo _emplyeeRepo;
        public AuthGuirdService(IHttpContextAccessor httpContextAccessor, IEmployeeRepo employeeRepo)
        {
            _httpContextAccessor = httpContextAccessor;
            _emplyeeRepo = employeeRepo;
        }
        public async Task SignInAsync(LoginModel loginModel)
        {
            var authenticateEmployee = await _emplyeeRepo.GetAutheticateEmployeeAsync(loginModel);

            if (authenticateEmployee is not null && authenticateEmployee.Id > 0)
            {
                var httpContext = _httpContextAccessor.HttpContext;

                var clims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Authentication, authenticateEmployee.Email.ToString()),
                        new Claim(ClaimTypes.Name,authenticateEmployee.FullName),
                        new Claim(ClaimTypes.Role, authenticateEmployee.DesignationId.ToString()),
                        new Claim(ClaimTypes.UserData, (string.IsNullOrEmpty(authenticateEmployee.Avatar)?"images/avatar/1.png":authenticateEmployee.Avatar)),
                    };

                var claimsIdentity = new ClaimsIdentity(clims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    // Remember me
                    IsPersistent = true,

                    //Till
                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(40)

                };

                await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                            new ClaimsPrincipal(claimsIdentity),
                            authProperties);

                SessionObjects.EmployeeInSession = new();
            }
        }
    }
}
