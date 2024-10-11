﻿// <auto-generated />
using System;
using KPIMS.Repos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KPIMS.Repos.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KPIMS.Core.Models.DbDesignation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdatedId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Designations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 10, 1, 13, 19, 22, 564, DateTimeKind.Local).AddTicks(8468),
                            CreatedId = 0,
                            IsDeleted = false,
                            Name = "System Administrator",
                            OrderId = 1,
                            UpdatedId = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 10, 1, 13, 19, 22, 564, DateTimeKind.Local).AddTicks(8472),
                            CreatedId = 0,
                            IsDeleted = false,
                            Name = "Managing Director",
                            OrderId = 2,
                            UpdatedId = 0
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 10, 1, 13, 19, 22, 564, DateTimeKind.Local).AddTicks(8473),
                            CreatedId = 0,
                            IsDeleted = false,
                            Name = "Deputy Managing Director",
                            OrderId = 3,
                            UpdatedId = 0
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 10, 1, 13, 19, 22, 564, DateTimeKind.Local).AddTicks(8475),
                            CreatedId = 0,
                            IsDeleted = false,
                            Name = "General Manager",
                            OrderId = 4,
                            UpdatedId = 0
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 10, 1, 13, 19, 22, 564, DateTimeKind.Local).AddTicks(8476),
                            CreatedId = 0,
                            IsDeleted = false,
                            Name = "Deputy General Manager",
                            OrderId = 5,
                            UpdatedId = 0
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 10, 1, 13, 19, 22, 564, DateTimeKind.Local).AddTicks(8477),
                            CreatedId = 0,
                            IsDeleted = false,
                            Name = "Director",
                            OrderId = 6,
                            UpdatedId = 0
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 10, 1, 13, 19, 22, 564, DateTimeKind.Local).AddTicks(8479),
                            CreatedId = 0,
                            IsDeleted = false,
                            Name = "Department Manager/Tech Lead\r\n",
                            OrderId = 7,
                            UpdatedId = 0
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 10, 1, 13, 19, 22, 564, DateTimeKind.Local).AddTicks(8480),
                            CreatedId = 0,
                            IsDeleted = false,
                            Name = "Assistant Manager",
                            OrderId = 8,
                            UpdatedId = 0
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 10, 1, 13, 19, 22, 564, DateTimeKind.Local).AddTicks(8481),
                            CreatedId = 0,
                            IsDeleted = false,
                            Name = "Senior Team Leaders",
                            OrderId = 9,
                            UpdatedId = 0
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2024, 10, 1, 13, 19, 22, 564, DateTimeKind.Local).AddTicks(8482),
                            CreatedId = 0,
                            IsDeleted = false,
                            Name = "Team Leaders/Lead Developer",
                            OrderId = 10,
                            UpdatedId = 0
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(2024, 10, 1, 13, 19, 22, 564, DateTimeKind.Local).AddTicks(8484),
                            CreatedId = 0,
                            IsDeleted = false,
                            Name = "Assistant Team Leaders/Senior Software Engineer",
                            OrderId = 11,
                            UpdatedId = 0
                        },
                        new
                        {
                            Id = 12,
                            CreatedDate = new DateTime(2024, 10, 1, 13, 19, 22, 564, DateTimeKind.Local).AddTicks(8485),
                            CreatedId = 0,
                            IsDeleted = false,
                            Name = "Quality Assurance Specialist",
                            OrderId = 12,
                            UpdatedId = 0
                        },
                        new
                        {
                            Id = 13,
                            CreatedDate = new DateTime(2024, 10, 1, 13, 19, 22, 564, DateTimeKind.Local).AddTicks(8486),
                            CreatedId = 0,
                            IsDeleted = false,
                            Name = "Senior Executive Officer/ Software Engineer",
                            OrderId = 13,
                            UpdatedId = 0
                        },
                        new
                        {
                            Id = 14,
                            CreatedDate = new DateTime(2024, 10, 1, 13, 19, 22, 564, DateTimeKind.Local).AddTicks(8488),
                            CreatedId = 0,
                            IsDeleted = false,
                            Name = "Executives Officer/ Associate Software Engineer",
                            OrderId = 14,
                            UpdatedId = 0
                        },
                        new
                        {
                            Id = 15,
                            CreatedDate = new DateTime(2024, 10, 1, 13, 19, 22, 564, DateTimeKind.Local).AddTicks(8489),
                            CreatedId = 0,
                            IsDeleted = false,
                            Name = "Associate Executive Officer",
                            OrderId = 15,
                            UpdatedId = 0
                        },
                        new
                        {
                            Id = 16,
                            CreatedDate = new DateTime(2024, 10, 1, 13, 19, 22, 564, DateTimeKind.Local).AddTicks(8490),
                            CreatedId = 0,
                            IsDeleted = false,
                            Name = "Trainee Executive Officer",
                            OrderId = 16,
                            UpdatedId = 0
                        });
                });

            modelBuilder.Entity("KPIMS.Core.Models.DbEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedId")
                        .HasColumnType("int");

                    b.Property<int>("DesignationId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdatedId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DesignationId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Avatar = "images/avatar/1.png",
                            CreatedDate = new DateTime(2024, 10, 1, 13, 19, 22, 580, DateTimeKind.Local).AddTicks(2156),
                            CreatedId = 0,
                            DesignationId = 1,
                            Email = "rima@gmail.com",
                            FirstName = "Rima",
                            IsDeleted = false,
                            LastName = "Akter",
                            Mobile = "",
                            Password = "R+XEf/rn63fJ217p/NK6vHDLAoH3GuPHw0XkW6uj4dU=",
                            PasswordSalt = "kd0YYkhDDNB37GbBPmwn8w==",
                            UpdatedId = 0
                        },
                        new
                        {
                            Id = 2,
                            Avatar = "images/avatar/1.png",
                            CreatedDate = new DateTime(2024, 10, 1, 13, 19, 22, 580, DateTimeKind.Local).AddTicks(2164),
                            CreatedId = 0,
                            DesignationId = 1,
                            Email = "admin@gmail.com",
                            FirstName = "System",
                            IsDeleted = false,
                            LastName = "Admin",
                            Mobile = "",
                            Password = "R+XEf/rn63fJ217p/NK6vHDLAoH3GuPHw0XkW6uj4dU=",
                            PasswordSalt = "kd0YYkhDDNB37GbBPmwn8w==",
                            UpdatedId = 0
                        },
                        new
                        {
                            Id = 3,
                            Avatar = "images/avatar/1.png",
                            CreatedDate = new DateTime(2024, 10, 1, 13, 19, 22, 580, DateTimeKind.Local).AddTicks(2167),
                            CreatedId = 0,
                            DesignationId = 1,
                            Email = "it-admin@gmail.com",
                            FirstName = "IT",
                            IsDeleted = false,
                            LastName = "Admin",
                            Mobile = "",
                            Password = "R+XEf/rn63fJ217p/NK6vHDLAoH3GuPHw0XkW6uj4dU=",
                            PasswordSalt = "kd0YYkhDDNB37GbBPmwn8w==",
                            UpdatedId = 0
                        });
                });

            modelBuilder.Entity("KPIMS.Core.Models.DbEmployeeProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ContactPersionEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPersionMobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPersionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Hobby")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("MaritalStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermanentAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PresentAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpouseMobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpouseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdatedId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("EmployeeProfiles");
                });

            modelBuilder.Entity("KPIMS.Core.Models.DbPrograsState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PrograsStates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Details = "Just created and planing about implementation",
                            Title = "New"
                        },
                        new
                        {
                            Id = 2,
                            Details = "Development started and developer working currently",
                            Title = "Active"
                        },
                        new
                        {
                            Id = 3,
                            Details = "Development closed and validating from specefic team",
                            Title = "Resolved"
                        },
                        new
                        {
                            Id = 4,
                            Details = "Verified by owner and released to owner",
                            Title = "Closed"
                        },
                        new
                        {
                            Id = 5,
                            Details = "Some resean it's put on hold",
                            Title = "On Hold"
                        },
                        new
                        {
                            Id = 6,
                            Details = "Created but no longer need to develop",
                            Title = "Removed"
                        });
                });

            modelBuilder.Entity("KPIMS.Core.Models.DbProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedId")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdatedId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("KPIMS.Core.Models.DbWorkItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AcceptanceCreteria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AssignedToId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ParentWorkId")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<int>("StoryPoint")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdatedId")
                        .HasColumnType("int");

                    b.Property<int>("WorkTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssignedToId");

                    b.HasIndex("ParentWorkId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("WorkTypeId");

                    b.ToTable("WorkItems");
                });

            modelBuilder.Entity("KPIMS.Core.Models.DbWorkItemDiscussion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ArticleDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdatedId")
                        .HasColumnType("int");

                    b.Property<int>("WorkItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("WorkItemDiscussions");
                });

            modelBuilder.Entity("KPIMS.Core.Models.DbWorkItemLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AcceptanceCreteria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AssignedToId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LogType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentWorkId")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<int>("StoryPoint")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdatedId")
                        .HasColumnType("int");

                    b.Property<int>("WorkItemId")
                        .HasColumnType("int");

                    b.Property<int>("WorkTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssignedToId");

                    b.HasIndex("ParentWorkId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("StateId");

                    b.HasIndex("WorkTypeId");

                    b.ToTable("WorkItemLogs");
                });

            modelBuilder.Entity("KPIMS.Core.Models.DbWorkItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkItemTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Epic"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Feature"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Incident"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Bug"
                        },
                        new
                        {
                            Id = 5,
                            Title = "User Story"
                        },
                        new
                        {
                            Id = 6,
                            Title = "Task"
                        });
                });

            modelBuilder.Entity("KPIMS.Core.Models.DbEmployee", b =>
                {
                    b.HasOne("KPIMS.Core.Models.DbDesignation", "Designation")
                        .WithMany()
                        .HasForeignKey("DesignationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Designation");
                });

            modelBuilder.Entity("KPIMS.Core.Models.DbEmployeeProfile", b =>
                {
                    b.HasOne("KPIMS.Core.Models.DbEmployee", "Employee")
                        .WithOne("EmployeeProfile")
                        .HasForeignKey("KPIMS.Core.Models.DbEmployeeProfile", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("KPIMS.Core.Models.DbWorkItem", b =>
                {
                    b.HasOne("KPIMS.Core.Models.DbEmployee", "Employee")
                        .WithMany()
                        .HasForeignKey("AssignedToId");

                    b.HasOne("KPIMS.Core.Models.DbWorkItem", "ParentWork")
                        .WithMany("SubWorks")
                        .HasForeignKey("ParentWorkId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("KPIMS.Core.Models.DbProject", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");

                    b.HasOne("KPIMS.Core.Models.DbWorkItemType", "WorkType")
                        .WithMany()
                        .HasForeignKey("WorkTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("ParentWork");

                    b.Navigation("Project");

                    b.Navigation("WorkType");
                });

            modelBuilder.Entity("KPIMS.Core.Models.DbWorkItemDiscussion", b =>
                {
                    b.HasOne("KPIMS.Core.Models.DbEmployee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("KPIMS.Core.Models.DbWorkItemLog", b =>
                {
                    b.HasOne("KPIMS.Core.Models.DbEmployee", "Employee")
                        .WithMany()
                        .HasForeignKey("AssignedToId");

                    b.HasOne("KPIMS.Core.Models.DbWorkItem", "ParentWork")
                        .WithMany()
                        .HasForeignKey("ParentWorkId");

                    b.HasOne("KPIMS.Core.Models.DbProject", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");

                    b.HasOne("KPIMS.Core.Models.DbPrograsState", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KPIMS.Core.Models.DbWorkItemType", "WorkType")
                        .WithMany()
                        .HasForeignKey("WorkTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("ParentWork");

                    b.Navigation("Project");

                    b.Navigation("State");

                    b.Navigation("WorkType");
                });

            modelBuilder.Entity("KPIMS.Core.Models.DbEmployee", b =>
                {
                    b.Navigation("EmployeeProfile");
                });

            modelBuilder.Entity("KPIMS.Core.Models.DbWorkItem", b =>
                {
                    b.Navigation("SubWorks");
                });
#pragma warning restore 612, 618
        }
    }
}
