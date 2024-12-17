using KPIMS.Core.Models;
using KPIMS.Core.Utilities;
using Microsoft.EntityFrameworkCore;

namespace KPIMS.Repos.Data
{
    public class DataBuilder
    {
        #region "Constructors #
        /// <summary>
        /// Inject Model Builder
        /// </summary>
        private ModelBuilder modelBuilder;
        public DataBuilder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        #endregion

        #region Public Methods
        /// <summary>
        /// Build demo data
        /// </summary>
        public void BuildData()
        {
            this.SetupWorkItemData();
            this.SetupPrograsStateData();
            this.SetupRoleData();
            this.SetupEmployeeData();
            this.SetupKpiIndicatorData();
        }

        #endregion


        private void SetupKpiIndicatorData()
        {
            this.modelBuilder.Entity<DbKpiIndicator>().HasData(
                new DbKpiIndicator
                {
                    Id = 1,
                    KPILabel = "Nothing satisfactory has been done",
                    MinPoint = 0,
                    MaxPoint = 50,
                    PerofrmanceBenefit="(0%) Take care yourself"
                },
                new DbKpiIndicator
                {
                    Id = 2,
                    KPILabel = "Performane bellow average",
                    MinPoint = 51,
                    MaxPoint = 60,
                    PerofrmanceBenefit = "2% - 4%"
                },
                new DbKpiIndicator
                {
                    Id = 3,
                    KPILabel = "Average perofrmance",
                    MinPoint = 61,
                    MaxPoint = 70,
                    PerofrmanceBenefit = "5% - 8%"
                },
                new DbKpiIndicator
                {
                    Id = 4,
                    KPILabel = "Performance above average",
                    MinPoint = 71,
                    MaxPoint = 80,
                    PerofrmanceBenefit = "9% - 12%"
                },
                new DbKpiIndicator
                {
                    Id = 5,
                    KPILabel = "Good performer",
                    MinPoint = 81,
                    MaxPoint = 90,
                    PerofrmanceBenefit = "13% - 15%"
                },
                new DbKpiIndicator
                {
                    Id = 6,
                    KPILabel = "Best performer",
                    MinPoint = 90,
                    MaxPoint = 100,
                    PerofrmanceBenefit = "16% - 20%"
                }
            );
        }
        private void SetupWorkItemData()
        {
            this.modelBuilder.Entity<DbWorkItemType>().HasData(
                new DbWorkItemType
                {
                    Id = 1,
                    Title = "Epic",
                },
                new DbWorkItemType
                {
                    Id = 2,
                    Title = "Feature",
                },
                new DbWorkItemType
                {
                    Id = 3,
                    Title = "Incident",
                },
                new DbWorkItemType
                {
                    Id = 4,
                    Title = "Bug",
                },
                new DbWorkItemType
                {
                    Id = 5,
                    Title = "User Story",
                },
                new DbWorkItemType
                {
                    Id = 6,
                    Title = "Task",
                }
            );
        }

        private void SetupPrograsStateData()
        {
            this.modelBuilder.Entity<DbPrograsState>().HasData(
                new DbPrograsState
                {
                    Id = 1,
                    Title = "New",
                    Details = "Just created and planing about implementation",
                },
                new DbPrograsState
                {
                    Id = 2,
                    Title = "Active",
                    Details = "Development started and developer working currently",
                },
                new DbPrograsState
                {
                    Id = 3,
                    Title = "Resolved",
                    Details = "Development closed and validating from specefic team",
                },
                new DbPrograsState
                {
                    Id = 4,
                    Title = "Closed",
                    Details = "Verified by owner and released to owner",
                },
                new DbPrograsState
                {
                    Id = 5,
                    Title = "On Hold",
                    Details = "Some resean it's put on hold",
                },
                new DbPrograsState
                {
                    Id = 6,
                    Title = "Removed",
                    Details = "Created but no longer need to develop",
                }
            );
        }

        private void SetupRoleData()
        {
            this.modelBuilder.Entity<DbDesignation>().HasData(
                new DbDesignation
                {
                    Id = 1,
                    Name = "System Administrator",
                    OrderId = 1,
                },
                new DbDesignation
                {
                    Id = 2,
                    Name = "Managing Director",
                    OrderId= 2,
                },
                new DbDesignation
                {
                    Id = 3,
                    Name = "Deputy Managing Director",
                    OrderId= 3,
                },
                new DbDesignation
                {
                    Id = 4,
                    Name = "General Manager",
                    OrderId = 4,
                },
                new DbDesignation
                {
                    Id = 5,
                    Name = "Deputy General Manager",
                    OrderId = 5,
                },
                new DbDesignation
                {
                    Id = 6,
                    Name = "Director",
                    OrderId = 6,
                },
                new DbDesignation
                {
                    Id = 7,
                    Name = "Department Manager/Tech Lead\r\n",
                    OrderId = 7,
                },
                new DbDesignation
                {
                    Id = 8,
                    Name = "Assistant Manager",
                    OrderId = 8,
                },
                new DbDesignation
                {
                    Id = 9,
                    Name = "Senior Team Leaders",
                    OrderId = 9,
                },
                new DbDesignation
                {
                    Id = 10,
                    Name = "Team Leaders/Lead Developer",
                    OrderId = 10,
                },
                new DbDesignation
                {
                    Id = 11,
                    Name = "Assistant Team Leaders/Senior Software Engineer",
                    OrderId = 11,
                },
                new DbDesignation
                {
                    Id = 12,
                    Name = "Quality Assurance Specialist",
                    OrderId = 12,
                },
                new DbDesignation
                {
                    Id = 13,
                    Name = "Senior Executive Officer/ Software Engineer",
                    OrderId = 13,
                },
                new DbDesignation
                {
                    Id = 14,
                    Name = "Executives Officer/ Associate Software Engineer",
                    OrderId = 14,
                },
                new DbDesignation
                {
                    Id = 15,
                    Name = "Associate Executive Officer",
                    OrderId = 15,
                },
                new DbDesignation
                {
                    Id = 16,
                    Name = "Trainee Executive Officer",
                    OrderId = 16,
                }
            );
        }

        private void SetupEmployeeData()
        {
            string salt = EncryptPassword.GetSalt();
            string has = EncryptPassword.GetHas("Password", salt);

            this.modelBuilder.Entity<DbEmployee>().HasData(
                new DbEmployee
                {
                    Id = 1,
                    FirstName = "Rima",
                    LastName = "Akter",
                    DesignationId = 1,
                    Email = "rima@gmail.com",
                    PasswordSalt = salt,
                    Password = has,
                    Avatar = "images/avatar/1.png"
                },
                new DbEmployee
                {
                    Id = 2,
                    FirstName = "System",
                    LastName = "Admin",
                    DesignationId = 1,
                    Email = "admin@gmail.com",
                    PasswordSalt = salt,
                    Password = has,
                    Avatar = "images/avatar/1.png"
                },
                new DbEmployee
                {
                    Id = 3,
                    FirstName = "IT",
                    LastName = "Admin",
                    DesignationId = 1,
                    Email = "it-admin@gmail.com",
                    PasswordSalt = salt,
                    Password = has,
                    Avatar = "images/avatar/1.png"
                }
            );
        }

    }
}
