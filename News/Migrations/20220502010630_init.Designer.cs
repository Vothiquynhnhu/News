﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using News.Data;

namespace News.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220502010630_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "f2952d8b-570f-40ba-9ffd-7fc380f27b6d",
                            RoleId = "e8c545fd-6e21-406f-ab2a-b42a5a4ebcb1"
                        },
                        new
                        {
                            UserId = "2854c38b-85e6-4c82-999c-4423b16cc417",
                            RoleId = "f6fe4511-5da0-4732-bb40-4278e972ca15"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("News.Entities.Categories", b =>
                {
                    b.Property<string>("category_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("category_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("category_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("category_Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            category_Id = "fe5a9974-c234-4817-b421-49e19ed4dba1",
                            IsDelete = false,
                            category_Description = "Des 1",
                            category_Name = "Category1"
                        },
                        new
                        {
                            category_Id = "8779aafa-3456-449b-8334-bc48611da47f",
                            IsDelete = false,
                            category_Description = "Des 2",
                            category_Name = "Category2"
                        },
                        new
                        {
                            category_Id = "baf9b015-8ed9-4d78-a981-e53cfb4fc400",
                            IsDelete = false,
                            category_Description = "Des 3",
                            category_Name = "Category3"
                        });
                });

            modelBuilder.Entity("News.Entities.Comments", b =>
                {
                    b.Property<string>("cmt_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("cmt_Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cmt_IdeaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("cmt_UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("cmt_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("cmt_Id");

                    b.HasIndex("cmt_IdeaId");

                    b.HasIndex("cmt_UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            cmt_Id = "0a485117-5fae-41e3-88cd-64d77dcc8888",
                            IsDelete = false,
                            cmt_Content = "Comment1",
                            cmt_IdeaId = "8628271f-4f71-4c86-92a9-f53b7e46ed8d",
                            cmt_UpdateDate = new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            cmt_UserId = "2854c38b-85e6-4c82-999c-4423b16cc417"
                        },
                        new
                        {
                            cmt_Id = "bd355167-eb19-43f2-8767-53282b09c638",
                            IsDelete = false,
                            cmt_Content = "Comment2",
                            cmt_IdeaId = "8628271f-4f71-4c86-92a9-f53b7e46ed8d",
                            cmt_UpdateDate = new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            cmt_UserId = "f2952d8b-570f-40ba-9ffd-7fc380f27b6d"
                        },
                        new
                        {
                            cmt_Id = "2045b253-6f3a-48c4-a701-bdf35ca1f32d",
                            IsDelete = false,
                            cmt_Content = "Comment3",
                            cmt_IdeaId = "8628271f-4f71-4c86-92a9-f53b7e46ed8d",
                            cmt_UpdateDate = new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            cmt_UserId = "2854c38b-85e6-4c82-999c-4423b16cc417"
                        });
                });

            modelBuilder.Entity("News.Entities.ContactEmail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactEmail");

                    b.HasData(
                        new
                        {
                            Id = "5c8147f3-bee1-427d-94ca-0727414aa615",
                            Email = "Email Test",
                            Message = "Message Test",
                            Name = "Name Test",
                            Subject = "Subject Test"
                        });
                });

            modelBuilder.Entity("News.Entities.Department", b =>
                {
                    b.Property<string>("department_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("department_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("department_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("department_Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            department_Id = "abaf08e5-6645-4b69-9a2d-31b415ce3a62",
                            IsDelete = false,
                            department_Description = "Department 1",
                            department_Name = "Department 1"
                        },
                        new
                        {
                            department_Id = "5a072358-a7aa-43d0-856d-491ba1be0bdd",
                            IsDelete = false,
                            department_Description = "Department 2",
                            department_Name = "Department 2 "
                        },
                        new
                        {
                            department_Id = "fa951cbc-e2ae-4904-8caf-50f9196d1470",
                            IsDelete = false,
                            department_Description = "Department 3",
                            department_Name = "Department 3"
                        });
                });

            modelBuilder.Entity("News.Entities.Idea", b =>
                {
                    b.Property<string>("idea_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("idea_Agree")
                        .HasColumnType("bit");

                    b.Property<string>("idea_CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idea_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_SubmissionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idea_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("idea_UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("idea_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("idea_View")
                        .HasColumnType("int");

                    b.HasKey("idea_Id");

                    b.HasIndex("idea_CategoryId");

                    b.HasIndex("idea_SubmissionId");

                    b.HasIndex("idea_UserId");

                    b.ToTable("Idea");

                    b.HasData(
                        new
                        {
                            idea_Id = "8628271f-4f71-4c86-92a9-f53b7e46ed8d",
                            IsDelete = false,
                            idea_Agree = false,
                            idea_CategoryId = "fe5a9974-c234-4817-b421-49e19ed4dba1",
                            idea_Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ",
                            idea_ImageName = "blog-1.png",
                            idea_SubmissionId = "fe9573ed-cdad-4a4b-a4cb-d0d8aa433f0d",
                            idea_Title = "Title1",
                            idea_UpdateTime = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_UserId = "f2952d8b-570f-40ba-9ffd-7fc380f27b6d",
                            idea_View = 0
                        },
                        new
                        {
                            idea_Id = "0fd29710-0b25-4b39-b30e-d96bf7a9db2c",
                            IsDelete = false,
                            idea_Agree = false,
                            idea_CategoryId = "8779aafa-3456-449b-8334-bc48611da47f",
                            idea_Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ",
                            idea_ImageName = "blog-2.png",
                            idea_SubmissionId = "fe9573ed-cdad-4a4b-a4cb-d0d8aa433f0d",
                            idea_Title = "Title2",
                            idea_UpdateTime = new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_UserId = "f2952d8b-570f-40ba-9ffd-7fc380f27b6d",
                            idea_View = 0
                        },
                        new
                        {
                            idea_Id = "8737c1d6-4cdc-407c-a38c-6c393fe2297b",
                            IsDelete = false,
                            idea_Agree = false,
                            idea_CategoryId = "8779aafa-3456-449b-8334-bc48611da47f",
                            idea_Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ",
                            idea_ImageName = "blog-3.png",
                            idea_SubmissionId = "fe9573ed-cdad-4a4b-a4cb-d0d8aa433f0d",
                            idea_Title = "Title3",
                            idea_UpdateTime = new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_UserId = "2854c38b-85e6-4c82-999c-4423b16cc417",
                            idea_View = 0
                        });
                });

            modelBuilder.Entity("News.Entities.LikeInIdea", b =>
                {
                    b.Property<string>("likeInIdea_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("likeInIdea_CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("likeInIdea_DisLike")
                        .HasColumnType("bit");

                    b.Property<string>("likeInIdea_IdeaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("likeInIdea_Like")
                        .HasColumnType("bit");

                    b.Property<string>("likeInIdea_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("likeInIdea_Id");

                    b.HasIndex("likeInIdea_IdeaId");

                    b.HasIndex("likeInIdea_UserId");

                    b.ToTable("LikeInIdea");
                });

            modelBuilder.Entity("News.Entities.Submission", b =>
                {
                    b.Property<string>("submission_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("submission_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("submission_DueTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("submission_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("submission_StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("submission_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("submission_Id");

                    b.HasIndex("submission_UserId");

                    b.ToTable("Submission");

                    b.HasData(
                        new
                        {
                            submission_Id = "fe9573ed-cdad-4a4b-a4cb-d0d8aa433f0d",
                            IsDelete = false,
                            submission_Description = "Submission1",
                            submission_DueTime = new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            submission_Name = "Submission1",
                            submission_StartTime = new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("News.Entities.UserInDepartment", b =>
                {
                    b.Property<string>("uid_UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("uid_DepartmentId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("uid_UserId", "uid_DepartmentId");

                    b.HasIndex("uid_DepartmentId");

                    b.ToTable("UserInDepartment");

                    b.HasData(
                        new
                        {
                            uid_UserId = "2854c38b-85e6-4c82-999c-4423b16cc417",
                            uid_DepartmentId = "abaf08e5-6645-4b69-9a2d-31b415ce3a62"
                        },
                        new
                        {
                            uid_UserId = "f2952d8b-570f-40ba-9ffd-7fc380f27b6d",
                            uid_DepartmentId = "5a072358-a7aa-43d0-856d-491ba1be0bdd"
                        });
                });

            modelBuilder.Entity("News.Models.AssignToDepartment", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreateDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AssignToDepartment");
                });

            modelBuilder.Entity("News.Models.AssignToRoleModels", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AssignToRoleModels");
                });

            modelBuilder.Entity("News.Models.DetailIdeaModels", b =>
                {
                    b.Property<string>("idea_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idea_CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_SubmissionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("idea_UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("idea_UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idea_Id");

                    b.ToTable("DetailIdeaModels");
                });

            modelBuilder.Entity("News.Entities.AppRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("AppRole");

                    b.HasData(
                        new
                        {
                            Id = "e8c545fd-6e21-406f-ab2a-b42a5a4ebcb1",
                            ConcurrencyStamp = "a9217f64-c92c-4139-a380-e6960b3ac50e",
                            Name = "Coordinator",
                            NormalizedName = "coordinator",
                            Description = "Coordinator",
                            IsDelete = false
                        },
                        new
                        {
                            Id = "f6fe4511-5da0-4732-bb40-4278e972ca15",
                            ConcurrencyStamp = "75b7f1f4-6125-4bc8-8f2c-64eacce313aa",
                            Name = "Admin",
                            NormalizedName = "admin",
                            Description = "Admin",
                            IsDelete = false
                        });
                });

            modelBuilder.Entity("News.Entities.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AppUser");

                    b.HasData(
                        new
                        {
                            Id = "2854c38b-85e6-4c82-999c-4423b16cc417",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "715a68a1-f159-4740-b453-ccb04d2468e9",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEP9ascX6PZDlNLJUdbL3iyku0rcGlVFNOgc8IhcIohX9SrwNfleIGXWvPOQEHTL1WA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0c136c79-1240-41dd-947b-93fed28a879f",
                            TwoFactorEnabled = false,
                            UserName = "Admin",
                            DoB = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastName = "Admin"
                        },
                        new
                        {
                            Id = "f2952d8b-570f-40ba-9ffd-7fc380f27b6d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "be5e62b9-b80e-4e2e-aa5f-10302499fa17",
                            Email = "coordinator@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "COORDINATOR@GMAIL.COM",
                            NormalizedUserName = "COORDINATOR@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEP9KduM9UkO5vBHD4UJ75xo13TbTaOg1c+jrOalQmDINKjic4iefCQnGmp6WowlDbQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6de979e7-f5b0-499e-bd46-633a7b38c3b0",
                            TwoFactorEnabled = false,
                            UserName = "Coordinator",
                            DoB = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastName = "Coordinator"
                        },
                        new
                        {
                            Id = "92bb8b52-2128-476c-8a9e-60c55a3bb39a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3a1a8ddb-02b0-43c6-9b66-138bc607752e",
                            Email = "staff2@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF2@GMAIL.COM",
                            NormalizedUserName = "STAFF2@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKvUKR4OKfkXd5zgNfRoZdxe6WuoJ9adz4m+5KxMnvLuT9BbbeYgCbx7TVjBrHnBfA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "00d5ecd3-0f5e-4d6b-9a06-ec63ef8b60e8",
                            TwoFactorEnabled = false,
                            UserName = "Staff2",
                            DoB = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastName = "Staff2"
                        },
                        new
                        {
                            Id = "4d653a0e-93cc-46cb-97e6-0b2ba70affa9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c5e22ea0-3810-4010-b05e-6cbeb41ad5e4",
                            Email = "anonymous@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ANOYMOUS@GMAIL.COM",
                            NormalizedUserName = "ANOYMOUS@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEB7esNJNRTERukiZJpIUyiR4jCQMjh+A/4Z8Ko1q7UWMTOesXG0W3kpis1ilvtczWQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1ac0f30e-76b0-427a-93ca-b97ea60eb8c1",
                            TwoFactorEnabled = false,
                            UserName = "Anonymous",
                            DoB = new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            LastName = "Anonymous"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("News.Entities.Comments", b =>
                {
                    b.HasOne("News.Entities.Idea", "IdeaFk")
                        .WithMany("Comments")
                        .HasForeignKey("cmt_IdeaId");

                    b.HasOne("News.Entities.AppUser", "AppUserFk")
                        .WithMany("Comments")
                        .HasForeignKey("cmt_UserId");

                    b.Navigation("AppUserFk");

                    b.Navigation("IdeaFk");
                });

            modelBuilder.Entity("News.Entities.Idea", b =>
                {
                    b.HasOne("News.Entities.Categories", "categoriesFK")
                        .WithMany("IdeaList")
                        .HasForeignKey("idea_CategoryId");

                    b.HasOne("News.Entities.Submission", "submissionFK")
                        .WithMany("IdeaList")
                        .HasForeignKey("idea_SubmissionId");

                    b.HasOne("News.Entities.AppUser", "appUserFK")
                        .WithMany("ideasList")
                        .HasForeignKey("idea_UserId");

                    b.Navigation("appUserFK");

                    b.Navigation("categoriesFK");

                    b.Navigation("submissionFK");
                });

            modelBuilder.Entity("News.Entities.LikeInIdea", b =>
                {
                    b.HasOne("News.Entities.Idea", "Idea")
                        .WithMany("likeInIdea")
                        .HasForeignKey("likeInIdea_IdeaId");

                    b.HasOne("News.Entities.AppUser", "AppUser")
                        .WithMany("likeInIdea")
                        .HasForeignKey("likeInIdea_UserId");

                    b.Navigation("AppUser");

                    b.Navigation("Idea");
                });

            modelBuilder.Entity("News.Entities.Submission", b =>
                {
                    b.HasOne("News.Entities.AppUser", "userFK")
                        .WithMany("Submission")
                        .HasForeignKey("submission_UserId");

                    b.Navigation("userFK");
                });

            modelBuilder.Entity("News.Entities.UserInDepartment", b =>
                {
                    b.HasOne("News.Entities.Department", "DepartmentFK")
                        .WithMany("userInDepartmentsList")
                        .HasForeignKey("uid_DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("News.Entities.AppUser", "AppUserFK")
                        .WithMany("userInDepartmentsList")
                        .HasForeignKey("uid_UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUserFK");

                    b.Navigation("DepartmentFK");
                });

            modelBuilder.Entity("News.Entities.Categories", b =>
                {
                    b.Navigation("IdeaList");
                });

            modelBuilder.Entity("News.Entities.Department", b =>
                {
                    b.Navigation("userInDepartmentsList");
                });

            modelBuilder.Entity("News.Entities.Idea", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("likeInIdea");
                });

            modelBuilder.Entity("News.Entities.Submission", b =>
                {
                    b.Navigation("IdeaList");
                });

            modelBuilder.Entity("News.Entities.AppUser", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("ideasList");

                    b.Navigation("likeInIdea");

                    b.Navigation("Submission");

                    b.Navigation("userInDepartmentsList");
                });
#pragma warning restore 612, 618
        }
    }
}
