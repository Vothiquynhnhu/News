using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace News.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssignToDepartment",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignToDepartment", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AssignToRoleModels",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignToRoleModels", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    category_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    category_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    category_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.category_Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactEmail",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactEmail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    department_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    department_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    department_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.department_Id);
                });

            migrationBuilder.CreateTable(
                name: "DetailIdeaModels",
                columns: table => new
                {
                    idea_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    idea_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idea_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idea_UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idea_ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idea_CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idea_SubmissionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idea_UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailIdeaModels", x => x.idea_Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Submission",
                columns: table => new
                {
                    submission_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    submission_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    submission_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    submission_StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    submission_DueTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    submission_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submission", x => x.submission_Id);
                    table.ForeignKey(
                        name: "FK_Submission_Users_submission_UserId",
                        column: x => x.submission_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInDepartment",
                columns: table => new
                {
                    uid_UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    uid_DepartmentId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInDepartment", x => new { x.uid_UserId, x.uid_DepartmentId });
                    table.ForeignKey(
                        name: "FK_UserInDepartment_Department_uid_DepartmentId",
                        column: x => x.uid_DepartmentId,
                        principalTable: "Department",
                        principalColumn: "department_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInDepartment_Users_uid_UserId",
                        column: x => x.uid_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Idea",
                columns: table => new
                {
                    idea_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    idea_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idea_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idea_View = table.Column<int>(type: "int", nullable: false),
                    idea_UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idea_Agree = table.Column<bool>(type: "bit", nullable: false),
                    idea_ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idea_ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idea_CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    idea_SubmissionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    idea_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idea", x => x.idea_Id);
                    table.ForeignKey(
                        name: "FK_Idea_Categories_idea_CategoryId",
                        column: x => x.idea_CategoryId,
                        principalTable: "Categories",
                        principalColumn: "category_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Idea_Submission_idea_SubmissionId",
                        column: x => x.idea_SubmissionId,
                        principalTable: "Submission",
                        principalColumn: "submission_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Idea_Users_idea_UserId",
                        column: x => x.idea_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    cmt_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cmt_Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cmt_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cmt_UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cmt_IdeaId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.cmt_Id);
                    table.ForeignKey(
                        name: "FK_Comments_Idea_cmt_IdeaId",
                        column: x => x.cmt_IdeaId,
                        principalTable: "Idea",
                        principalColumn: "idea_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Users_cmt_UserId",
                        column: x => x.cmt_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LikeInIdea",
                columns: table => new
                {
                    likeInIdea_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    likeInIdea_Like = table.Column<bool>(type: "bit", nullable: false),
                    likeInIdea_DisLike = table.Column<bool>(type: "bit", nullable: false),
                    likeInIdea_CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    likeInIdea_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    likeInIdea_IdeaId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeInIdea", x => x.likeInIdea_Id);
                    table.ForeignKey(
                        name: "FK_LikeInIdea_Idea_likeInIdea_IdeaId",
                        column: x => x.likeInIdea_IdeaId,
                        principalTable: "Idea",
                        principalColumn: "idea_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LikeInIdea_Users_likeInIdea_UserId",
                        column: x => x.likeInIdea_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_Id", "IsDelete", "category_Description", "category_Name" },
                values: new object[,]
                {
                    { "fe5a9974-c234-4817-b421-49e19ed4dba1", false, "Des 1", "Category1" },
                    { "8779aafa-3456-449b-8334-bc48611da47f", false, "Des 2", "Category2" },
                    { "baf9b015-8ed9-4d78-a981-e53cfb4fc400", false, "Des 3", "Category3" }
                });

            migrationBuilder.InsertData(
                table: "ContactEmail",
                columns: new[] { "Id", "Email", "Message", "Name", "Subject" },
                values: new object[] { "5c8147f3-bee1-427d-94ca-0727414aa615", "Email Test", "Message Test", "Name Test", "Subject Test" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "IsDelete", "department_Description", "department_Name" },
                values: new object[,]
                {
                    { "abaf08e5-6645-4b69-9a2d-31b415ce3a62", false, "Department 1", "Department 1" },
                    { "5a072358-a7aa-43d0-856d-491ba1be0bdd", false, "Department 2", "Department 2 " },
                    { "fa951cbc-e2ae-4904-8caf-50f9196d1470", false, "Department 3", "Department 3" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "IsDelete", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e8c545fd-6e21-406f-ab2a-b42a5a4ebcb1", "a9217f64-c92c-4139-a380-e6960b3ac50e", "Coordinator", "AppRole", false, "Coordinator", "coordinator" },
                    { "f6fe4511-5da0-4732-bb40-4278e972ca15", "75b7f1f4-6125-4bc8-8f2c-64eacce313aa", "Admin", "AppRole", false, "Admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Submission",
                columns: new[] { "submission_Id", "IsDelete", "submission_Description", "submission_DueTime", "submission_Name", "submission_StartTime", "submission_UserId" },
                values: new object[] { "fe9573ed-cdad-4a4b-a4cb-d0d8aa433f0d", false, "Submission1", new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Submission1", new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "IsDelete", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2854c38b-85e6-4c82-999c-4423b16cc417", 0, "715a68a1-f159-4740-b453-ccb04d2468e9", "AppUser", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, null, false, "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEP9ascX6PZDlNLJUdbL3iyku0rcGlVFNOgc8IhcIohX9SrwNfleIGXWvPOQEHTL1WA==", null, false, "0c136c79-1240-41dd-947b-93fed28a879f", false, "Admin" },
                    { "f2952d8b-570f-40ba-9ffd-7fc380f27b6d", 0, "be5e62b9-b80e-4e2e-aa5f-10302499fa17", "AppUser", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "coordinator@gmail.com", true, null, false, "Coordinator", false, null, "COORDINATOR@GMAIL.COM", "COORDINATOR@GMAIL.COM", "AQAAAAEAACcQAAAAEP9KduM9UkO5vBHD4UJ75xo13TbTaOg1c+jrOalQmDINKjic4iefCQnGmp6WowlDbQ==", null, false, "6de979e7-f5b0-499e-bd46-633a7b38c3b0", false, "Coordinator" },
                    { "92bb8b52-2128-476c-8a9e-60c55a3bb39a", 0, "3a1a8ddb-02b0-43c6-9b66-138bc607752e", "AppUser", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff2@gmail.com", true, null, false, "Staff2", false, null, "STAFF2@GMAIL.COM", "STAFF2@GMAIL.COM", "AQAAAAEAACcQAAAAEKvUKR4OKfkXd5zgNfRoZdxe6WuoJ9adz4m+5KxMnvLuT9BbbeYgCbx7TVjBrHnBfA==", null, false, "00d5ecd3-0f5e-4d6b-9a06-ec63ef8b60e8", false, "Staff2" },
                    { "4d653a0e-93cc-46cb-97e6-0b2ba70affa9", 0, "c5e22ea0-3810-4010-b05e-6cbeb41ad5e4", "AppUser", new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "anonymous@gmail.com", true, null, false, "Anonymous", false, null, "ANOYMOUS@GMAIL.COM", "ANOYMOUS@GMAIL.COM", "AQAAAAEAACcQAAAAEB7esNJNRTERukiZJpIUyiR4jCQMjh+A/4Z8Ko1q7UWMTOesXG0W3kpis1ilvtczWQ==", null, false, "1ac0f30e-76b0-427a-93ca-b97ea60eb8c1", false, "Anonymous" }
                });

            migrationBuilder.InsertData(
                table: "Idea",
                columns: new[] { "idea_Id", "IsDelete", "idea_Agree", "idea_CategoryId", "idea_Description", "idea_ImageName", "idea_ImagePath", "idea_SubmissionId", "idea_Title", "idea_UpdateTime", "idea_UserId", "idea_View" },
                values: new object[,]
                {
                    { "8628271f-4f71-4c86-92a9-f53b7e46ed8d", false, false, "fe5a9974-c234-4817-b421-49e19ed4dba1", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ", "blog-1.png", null, "fe9573ed-cdad-4a4b-a4cb-d0d8aa433f0d", "Title1", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "f2952d8b-570f-40ba-9ffd-7fc380f27b6d", 0 },
                    { "0fd29710-0b25-4b39-b30e-d96bf7a9db2c", false, false, "8779aafa-3456-449b-8334-bc48611da47f", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ", "blog-2.png", null, "fe9573ed-cdad-4a4b-a4cb-d0d8aa433f0d", "Title2", new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "f2952d8b-570f-40ba-9ffd-7fc380f27b6d", 0 },
                    { "8737c1d6-4cdc-407c-a38c-6c393fe2297b", false, false, "8779aafa-3456-449b-8334-bc48611da47f", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae ipsum non voluptatum eum repellendus quod aliquid. Vitae, dolorum voluptate quis repudiandae eos molestiae dolores enim. ", "blog-3.png", null, "fe9573ed-cdad-4a4b-a4cb-d0d8aa433f0d", "Title3", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "2854c38b-85e6-4c82-999c-4423b16cc417", 0 }
                });

            migrationBuilder.InsertData(
                table: "UserInDepartment",
                columns: new[] { "uid_DepartmentId", "uid_UserId" },
                values: new object[,]
                {
                    { "abaf08e5-6645-4b69-9a2d-31b415ce3a62", "2854c38b-85e6-4c82-999c-4423b16cc417" },
                    { "5a072358-a7aa-43d0-856d-491ba1be0bdd", "f2952d8b-570f-40ba-9ffd-7fc380f27b6d" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f6fe4511-5da0-4732-bb40-4278e972ca15", "2854c38b-85e6-4c82-999c-4423b16cc417" },
                    { "e8c545fd-6e21-406f-ab2a-b42a5a4ebcb1", "f2952d8b-570f-40ba-9ffd-7fc380f27b6d" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "cmt_Id", "IsDelete", "cmt_Content", "cmt_IdeaId", "cmt_UpdateDate", "cmt_UserId" },
                values: new object[] { "0a485117-5fae-41e3-88cd-64d77dcc8888", false, "Comment1", "8628271f-4f71-4c86-92a9-f53b7e46ed8d", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "2854c38b-85e6-4c82-999c-4423b16cc417" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "cmt_Id", "IsDelete", "cmt_Content", "cmt_IdeaId", "cmt_UpdateDate", "cmt_UserId" },
                values: new object[] { "bd355167-eb19-43f2-8767-53282b09c638", false, "Comment2", "8628271f-4f71-4c86-92a9-f53b7e46ed8d", new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "f2952d8b-570f-40ba-9ffd-7fc380f27b6d" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "cmt_Id", "IsDelete", "cmt_Content", "cmt_IdeaId", "cmt_UpdateDate", "cmt_UserId" },
                values: new object[] { "2045b253-6f3a-48c4-a701-bdf35ca1f32d", false, "Comment3", "8628271f-4f71-4c86-92a9-f53b7e46ed8d", new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "2854c38b-85e6-4c82-999c-4423b16cc417" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_cmt_IdeaId",
                table: "Comments",
                column: "cmt_IdeaId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_cmt_UserId",
                table: "Comments",
                column: "cmt_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Idea_idea_CategoryId",
                table: "Idea",
                column: "idea_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Idea_idea_SubmissionId",
                table: "Idea",
                column: "idea_SubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Idea_idea_UserId",
                table: "Idea",
                column: "idea_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeInIdea_likeInIdea_IdeaId",
                table: "LikeInIdea",
                column: "likeInIdea_IdeaId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeInIdea_likeInIdea_UserId",
                table: "LikeInIdea",
                column: "likeInIdea_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Submission_submission_UserId",
                table: "Submission",
                column: "submission_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInDepartment_uid_DepartmentId",
                table: "UserInDepartment",
                column: "uid_DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignToDepartment");

            migrationBuilder.DropTable(
                name: "AssignToRoleModels");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ContactEmail");

            migrationBuilder.DropTable(
                name: "DetailIdeaModels");

            migrationBuilder.DropTable(
                name: "LikeInIdea");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserInDepartment");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Idea");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Submission");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
