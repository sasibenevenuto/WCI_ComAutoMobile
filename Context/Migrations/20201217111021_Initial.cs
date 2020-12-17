using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Context.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
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
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TradingName = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    FantasyName = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    StateRegistration = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    CNAE = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    MunicipalityRegistration = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    StateRegistrationReplaceTributary = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    UrlLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellPhone = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PhoneNumbers = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    AddressNumber = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    AddressComplement = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Neighborhood = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    UserIDCreate = table.Column<int>(type: "int", nullable: false),
                    UserIDLastUpdate = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieldDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
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
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Post = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    UserIDCreate = table.Column<int>(type: "int", nullable: false),
                    UserIDLastUpdate = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieldDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Personal_Information",
                columns: table => new
                {
                    PersonalInformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IndividualResistration = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PhoneNumbers = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    AddressNumber = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    AddressComplement = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    Neighborhood = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    UserIDCreate = table.Column<int>(type: "int", nullable: true),
                    UserIDLastUpdate = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieldDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal_Information", x => x.PersonalInformationId);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDCreate = table.Column<int>(type: "int", nullable: false),
                    UserIDLastUpdate = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieldDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_Account_Personal_Information_UserIDCreate",
                        column: x => x.UserIDCreate,
                        principalTable: "Personal_Information",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Account_Personal_Information_UserIDLastUpdate",
                        column: x => x.UserIDLastUpdate,
                        principalTable: "Personal_Information",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Claim",
                columns: table => new
                {
                    ClaimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    TypeFunctionClaim = table.Column<int>(type: "int", nullable: false),
                    UserIDCreate = table.Column<int>(type: "int", nullable: false),
                    UserIDLastUpdate = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieldDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claim", x => x.ClaimId);
                    table.ForeignKey(
                        name: "FK_Claim_Personal_Information_UserIDCreate",
                        column: x => x.UserIDCreate,
                        principalTable: "Personal_Information",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Claim_Personal_Information_UserIDLastUpdate",
                        column: x => x.UserIDLastUpdate,
                        principalTable: "Personal_Information",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyConfigNFe",
                columns: table => new
                {
                    CompanyConfigNFeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentNumberNfe = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    VersionNfe = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    EnvironmentNFE = table.Column<int>(type: "int", nullable: false),
                    UserIDCreate = table.Column<int>(type: "int", nullable: false),
                    UserIDLastUpdate = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieldDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyConfigNFe", x => x.CompanyConfigNFeId);
                    table.ForeignKey(
                        name: "FK_CompanyConfigNFe_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyConfigNFe_Personal_Information_UserIDCreate",
                        column: x => x.UserIDCreate,
                        principalTable: "Personal_Information",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyConfigNFe_Personal_Information_UserIDLastUpdate",
                        column: x => x.UserIDLastUpdate,
                        principalTable: "Personal_Information",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TradingName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    UserIDCreate = table.Column<int>(type: "int", nullable: true),
                    UserIDLastUpdate = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieldDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customer_Personal_Information_UserIDCreate",
                        column: x => x.UserIDCreate,
                        principalTable: "Personal_Information",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Personal_Information_UserIDLastUpdate",
                        column: x => x.UserIDLastUpdate,
                        principalTable: "Personal_Information",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    ProfileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    UserIDCreate = table.Column<int>(type: "int", nullable: false),
                    UserIDLastUpdate = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieldDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.ProfileId);
                    table.ForeignKey(
                        name: "FK_Profile_Personal_Information_UserIDCreate",
                        column: x => x.UserIDCreate,
                        principalTable: "Personal_Information",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Profile_Personal_Information_UserIDLastUpdate",
                        column: x => x.UserIDLastUpdate,
                        principalTable: "Personal_Information",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    FederativeUnit = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ExternalCode = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    UserIDCreate = table.Column<int>(type: "int", nullable: false),
                    UserIDLastUpdate = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieldDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_State_Personal_Information_UserIDCreate",
                        column: x => x.UserIDCreate,
                        principalTable: "Personal_Information",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_State_Personal_Information_UserIDLastUpdate",
                        column: x => x.UserIDLastUpdate,
                        principalTable: "Personal_Information",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProfileId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    ExternalCode = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    UserIDCreate = table.Column<int>(type: "int", nullable: false),
                    UserIDLastUpdate = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieldDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_City_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users_x_Claims",
                columns: table => new
                {
                    Users_x_ClaimsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ClaimId = table.Column<int>(type: "int", nullable: false),
                    UserIDCreate = table.Column<int>(type: "int", nullable: false),
                    UserIDLastUpdate = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieldDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users_x_Claims", x => x.Users_x_ClaimsId);
                    table.ForeignKey(
                        name: "FK_Users_x_Claims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_x_Claims_Claim_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "Claim",
                        principalColumn: "ClaimId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_x_Claims_Personal_Information_UserIDCreate",
                        column: x => x.UserIDCreate,
                        principalTable: "Personal_Information",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_x_Claims_Personal_Information_UserIDLastUpdate",
                        column: x => x.UserIDLastUpdate,
                        principalTable: "Personal_Information",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddress",
                columns: table => new
                {
                    CustomerAddressId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CellPhone = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PhoneNumbers = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    AddressNumber = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    AddressComplement = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    Neighborhood = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    UserIDCreate = table.Column<int>(type: "int", nullable: false),
                    UserIDLastUpdate = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieldDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddress", x => x.CustomerAddressId);
                    table.ForeignKey(
                        name: "FK_CustomerAddress_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerAddress_Personal_Information_UserIDCreate",
                        column: x => x.UserIDCreate,
                        principalTable: "Personal_Information",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerAddress_Personal_Information_UserIDLastUpdate",
                        column: x => x.UserIDLastUpdate,
                        principalTable: "Personal_Information",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_UserIDCreate",
                table: "Account",
                column: "UserIDCreate");

            migrationBuilder.CreateIndex(
                name: "IX_Account_UserIDLastUpdate",
                table: "Account",
                column: "UserIDLastUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProfileId",
                table: "AspNetUsers",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_City_StateId",
                table: "City",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Claim_UserIDCreate",
                table: "Claim",
                column: "UserIDCreate");

            migrationBuilder.CreateIndex(
                name: "IX_Claim_UserIDLastUpdate",
                table: "Claim",
                column: "UserIDLastUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_Company_AccountId",
                table: "Company",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_CityId",
                table: "Company",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_UserIDCreate",
                table: "Company",
                column: "UserIDCreate");

            migrationBuilder.CreateIndex(
                name: "IX_Company_UserIDLastUpdate",
                table: "Company",
                column: "UserIDLastUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyConfigNFe_CompanyId",
                table: "CompanyConfigNFe",
                column: "CompanyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompanyConfigNFe_UserIDCreate",
                table: "CompanyConfigNFe",
                column: "UserIDCreate");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyConfigNFe_UserIDLastUpdate",
                table: "CompanyConfigNFe",
                column: "UserIDLastUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_UserIDCreate",
                table: "Customer",
                column: "UserIDCreate");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_UserIDLastUpdate",
                table: "Customer",
                column: "UserIDLastUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_CityId",
                table: "CustomerAddress",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_UserIDCreate",
                table: "CustomerAddress",
                column: "UserIDCreate");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_UserIDLastUpdate",
                table: "CustomerAddress",
                column: "UserIDLastUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CompanyId",
                table: "Employee",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UserId",
                table: "Employee",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UserIDCreate",
                table: "Employee",
                column: "UserIDCreate");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UserIDLastUpdate",
                table: "Employee",
                column: "UserIDLastUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_Information_CityId",
                table: "Personal_Information",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_Information_UserId",
                table: "Personal_Information",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Profile_UserIDCreate",
                table: "Profile",
                column: "UserIDCreate");

            migrationBuilder.CreateIndex(
                name: "IX_Profile_UserIDLastUpdate",
                table: "Profile",
                column: "UserIDLastUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_State_UserIDCreate",
                table: "State",
                column: "UserIDCreate");

            migrationBuilder.CreateIndex(
                name: "IX_State_UserIDLastUpdate",
                table: "State",
                column: "UserIDLastUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_Users_x_Claims_ClaimId",
                table: "Users_x_Claims",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_x_Claims_UserId",
                table: "Users_x_Claims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_x_Claims_UserIDCreate",
                table: "Users_x_Claims",
                column: "UserIDCreate");

            migrationBuilder.CreateIndex(
                name: "IX_Users_x_Claims_UserIDLastUpdate",
                table: "Users_x_Claims",
                column: "UserIDLastUpdate");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Account_AccountId",
                table: "Company",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_City_CityId",
                table: "Company",
                column: "CityId",
                principalTable: "City",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Personal_Information_UserIDCreate",
                table: "Company",
                column: "UserIDCreate",
                principalTable: "Personal_Information",
                principalColumn: "PersonalInformationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Personal_Information_UserIDLastUpdate",
                table: "Company",
                column: "UserIDLastUpdate",
                principalTable: "Personal_Information",
                principalColumn: "PersonalInformationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_AspNetUsers_UserId",
                table: "Employee",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Personal_Information_UserIDCreate",
                table: "Employee",
                column: "UserIDCreate",
                principalTable: "Personal_Information",
                principalColumn: "PersonalInformationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Personal_Information_UserIDLastUpdate",
                table: "Employee",
                column: "UserIDLastUpdate",
                principalTable: "Personal_Information",
                principalColumn: "PersonalInformationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personal_Information_AspNetUsers_UserId",
                table: "Personal_Information",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personal_Information_City_CityId",
                table: "Personal_Information",
                column: "CityId",
                principalTable: "City",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profile_Personal_Information_UserIDCreate",
                table: "Profile");

            migrationBuilder.DropForeignKey(
                name: "FK_Profile_Personal_Information_UserIDLastUpdate",
                table: "Profile");

            migrationBuilder.DropForeignKey(
                name: "FK_State_Personal_Information_UserIDCreate",
                table: "State");

            migrationBuilder.DropForeignKey(
                name: "FK_State_Personal_Information_UserIDLastUpdate",
                table: "State");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CompanyConfigNFe");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "CustomerAddress");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Users_x_Claims");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Claim");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Personal_Information");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropTable(
                name: "State");
        }
    }
}
