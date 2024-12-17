using KPIMS.Core.Models;
using KPIMS.Repos.Data;
using Microsoft.EntityFrameworkCore;

namespace KPIMS.Repos
{
    public class AppDbContext : DbContext
    {
        #region Constructors
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public AppDbContext()
        {
            
        }
        #endregion

        #region Configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbWorkItem>()
           .HasMany(w => w.SubWorks)
           .WithOne(w => w.ParentWork)
           .HasForeignKey(w => w.ParentWorkId)
           .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<DbWorkItemLog>()
            //.Property(w => w.Id)
            //.ValueGeneratedOnAdd();

            DataBuilder dataBuilder = new DataBuilder(modelBuilder);
            dataBuilder.BuildData();
        }

        #endregion

        public virtual DbSet<DbDesignation> Designations { get; set; }
        public virtual DbSet<DbEmployee> Employees { get; set; }
        public virtual DbSet<DbEmployeeProfile> EmployeeProfiles { get; set; }
        public virtual DbSet<DbProject> Projects { get; set; }
        public virtual DbSet<DbPrograsState> PrograsStates { get; set; }
        public virtual DbSet<DbWorkItemType> WorkItemTypes { get; set; }
        public virtual DbSet<DbWorkItem> WorkItems { get; set; }
        public virtual DbSet<DbWorkItemLog> WorkItemLogs { get; set; }
        public virtual DbSet<DbWorkItemDiscussion> WorkItemDiscussions { get; set; }
        public virtual DbSet<GoalSet> GoalSets { get; set; }
        public virtual DbSet<DbKpiIndicator> KpiIndicators { get; set; }
    }
}
