using KPIMS.Repos.Repositories.Administration;
using KPIMS.Repos.Repositories.Administration.Interfaces;
using KPIMS.Repos.Repositories.Board;
using KPIMS.Repos.Repositories.Board.Interfaces;
using KPIMS.Repos.Repositories.Common;
using KPIMS.Repos.Repositories.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace KPIMS.Repos.Configuration
{
    public static class DependenciInjections
    {
        public static IServiceCollection AddRepoServices(this IServiceCollection services)
        {
            services.AddScoped<IDesignationRepo, DesignationRepo>();
            services.AddTransient<IEmployeeRepo, EmployeeRepo>();
            services.AddTransient<IEmployeeProfileRepo, EmployeeProfileRepo>();

            services.AddTransient<IProjectRepo, ProjectRepo>();
            services.AddTransient<IDropdownRepo, DropdownRepo>();
            services.AddTransient<IWorkItemRepo, WorkItemRepo>();
            services.AddTransient<IWorkItemDiscussionRepo, WorkItemDiscussionRepo>();
            services.AddTransient<IGoalSetRepo, GoalSetRepo>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return services;
        }
    }
}
