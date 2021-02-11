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
                name: "COM_Employee",
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
                    table.PrimaryKey("PK_COM_Employee", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "GEN_PersonalInformation",
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
                    table.PrimaryKey("PK_GEN_PersonalInformation", x => x.PersonalInformationId);
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
                        name: "FK_Claim_GEN_PersonalInformation_UserIDCreate",
                        column: x => x.UserIDCreate,
                        principalTable: "GEN_PersonalInformation",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Claim_GEN_PersonalInformation_UserIDLastUpdate",
                        column: x => x.UserIDLastUpdate,
                        principalTable: "GEN_PersonalInformation",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "COM_Account",
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
                    table.PrimaryKey("PK_COM_Account", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_COM_Account_GEN_PersonalInformation_UserIDCreate",
                        column: x => x.UserIDCreate,
                        principalTable: "GEN_PersonalInformation",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_COM_Account_GEN_PersonalInformation_UserIDLastUpdate",
                        column: x => x.UserIDLastUpdate,
                        principalTable: "GEN_PersonalInformation",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GEN_State",
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
                    table.PrimaryKey("PK_GEN_State", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_GEN_State_GEN_PersonalInformation_UserIDCreate",
                        column: x => x.UserIDCreate,
                        principalTable: "GEN_PersonalInformation",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GEN_State_GEN_PersonalInformation_UserIDLastUpdate",
                        column: x => x.UserIDLastUpdate,
                        principalTable: "GEN_PersonalInformation",
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
                        name: "FK_Profile_GEN_PersonalInformation_UserIDCreate",
                        column: x => x.UserIDCreate,
                        principalTable: "GEN_PersonalInformation",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Profile_GEN_PersonalInformation_UserIDLastUpdate",
                        column: x => x.UserIDLastUpdate,
                        principalTable: "GEN_PersonalInformation",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GEN_City",
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
                    table.PrimaryKey("PK_GEN_City", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_GEN_City_GEN_State_StateId",
                        column: x => x.StateId,
                        principalTable: "GEN_State",
                        principalColumn: "StateId",
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
                name: "COM_Company",
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
                    table.PrimaryKey("PK_COM_Company", x => x.CompanyId);
                    table.ForeignKey(
                        name: "FK_COM_Company_COM_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "COM_Account",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_COM_Company_GEN_City_CityId",
                        column: x => x.CityId,
                        principalTable: "GEN_City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_COM_Company_GEN_PersonalInformation_UserIDCreate",
                        column: x => x.UserIDCreate,
                        principalTable: "GEN_PersonalInformation",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_COM_Company_GEN_PersonalInformation_UserIDLastUpdate",
                        column: x => x.UserIDLastUpdate,
                        principalTable: "GEN_PersonalInformation",
                        principalColumn: "PersonalInformationId",
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
                        name: "FK_Users_x_Claims_GEN_PersonalInformation_UserIDCreate",
                        column: x => x.UserIDCreate,
                        principalTable: "GEN_PersonalInformation",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_x_Claims_GEN_PersonalInformation_UserIDLastUpdate",
                        column: x => x.UserIDLastUpdate,
                        principalTable: "GEN_PersonalInformation",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "COM_CompanyConfigNFe",
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
                    table.PrimaryKey("PK_COM_CompanyConfigNFe", x => x.CompanyConfigNFeId);
                    table.ForeignKey(
                        name: "FK_COM_CompanyConfigNFe_COM_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "COM_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_COM_CompanyConfigNFe_GEN_PersonalInformation_UserIDCreate",
                        column: x => x.UserIDCreate,
                        principalTable: "GEN_PersonalInformation",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_COM_CompanyConfigNFe_GEN_PersonalInformation_UserIDLastUpdate",
                        column: x => x.UserIDLastUpdate,
                        principalTable: "GEN_PersonalInformation",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CUS_Customer",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompnayId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TradingName = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    FantasyName = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    TypeCustomer = table.Column<int>(type: "int", nullable: false),
                    CpfCnpj = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    StateRegistration = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    MunicipalityRegistration = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Suframa = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    UserIDCreate = table.Column<int>(type: "int", nullable: false),
                    UserIDLastUpdate = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifieldDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUS_Customer", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_CUS_Customer_COM_Company_CompnayId",
                        column: x => x.CompnayId,
                        principalTable: "COM_Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CUS_Customer_GEN_PersonalInformation_UserIDCreate",
                        column: x => x.UserIDCreate,
                        principalTable: "GEN_PersonalInformation",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CUS_Customer_GEN_PersonalInformation_UserIDLastUpdate",
                        column: x => x.UserIDLastUpdate,
                        principalTable: "GEN_PersonalInformation",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CUS_CustomerAddress",
                columns: table => new
                {
                    CustomerAddressId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_CUS_CustomerAddress", x => x.CustomerAddressId);
                    table.ForeignKey(
                        name: "FK_CUS_CustomerAddress_CUS_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CUS_Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CUS_CustomerAddress_GEN_City_CityId",
                        column: x => x.CityId,
                        principalTable: "GEN_City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CUS_CustomerAddress_GEN_PersonalInformation_UserIDCreate",
                        column: x => x.UserIDCreate,
                        principalTable: "GEN_PersonalInformation",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CUS_CustomerAddress_GEN_PersonalInformation_UserIDLastUpdate",
                        column: x => x.UserIDLastUpdate,
                        principalTable: "GEN_PersonalInformation",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_Claim_UserIDCreate",
                table: "Claim",
                column: "UserIDCreate");

            migrationBuilder.CreateIndex(
                name: "IX_Claim_UserIDLastUpdate",
                table: "Claim",
                column: "UserIDLastUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Account_UserIDCreate",
                table: "COM_Account",
                column: "UserIDCreate");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Account_UserIDLastUpdate",
                table: "COM_Account",
                column: "UserIDLastUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Company_AccountId",
                table: "COM_Company",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Company_CityId",
                table: "COM_Company",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Company_UserIDCreate",
                table: "COM_Company",
                column: "UserIDCreate");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Company_UserIDLastUpdate",
                table: "COM_Company",
                column: "UserIDLastUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_COM_CompanyConfigNFe_CompanyId",
                table: "COM_CompanyConfigNFe",
                column: "CompanyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_COM_CompanyConfigNFe_UserIDCreate",
                table: "COM_CompanyConfigNFe",
                column: "UserIDCreate");

            migrationBuilder.CreateIndex(
                name: "IX_COM_CompanyConfigNFe_UserIDLastUpdate",
                table: "COM_CompanyConfigNFe",
                column: "UserIDLastUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Employee_CompanyId",
                table: "COM_Employee",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Employee_UserId",
                table: "COM_Employee",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Employee_UserIDCreate",
                table: "COM_Employee",
                column: "UserIDCreate");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Employee_UserIDLastUpdate",
                table: "COM_Employee",
                column: "UserIDLastUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_CUS_Customer_CompnayId",
                table: "CUS_Customer",
                column: "CompnayId");

            migrationBuilder.CreateIndex(
                name: "IX_CUS_Customer_UserIDCreate",
                table: "CUS_Customer",
                column: "UserIDCreate");

            migrationBuilder.CreateIndex(
                name: "IX_CUS_Customer_UserIDLastUpdate",
                table: "CUS_Customer",
                column: "UserIDLastUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_CUS_CustomerAddress_CityId",
                table: "CUS_CustomerAddress",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_CUS_CustomerAddress_CustomerId",
                table: "CUS_CustomerAddress",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CUS_CustomerAddress_UserIDCreate",
                table: "CUS_CustomerAddress",
                column: "UserIDCreate");

            migrationBuilder.CreateIndex(
                name: "IX_CUS_CustomerAddress_UserIDLastUpdate",
                table: "CUS_CustomerAddress",
                column: "UserIDLastUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_GEN_City_StateId",
                table: "GEN_City",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_GEN_PersonalInformation_CityId",
                table: "GEN_PersonalInformation",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_GEN_PersonalInformation_UserId",
                table: "GEN_PersonalInformation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GEN_State_UserIDCreate",
                table: "GEN_State",
                column: "UserIDCreate");

            migrationBuilder.CreateIndex(
                name: "IX_GEN_State_UserIDLastUpdate",
                table: "GEN_State",
                column: "UserIDLastUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_Profile_UserIDCreate",
                table: "Profile",
                column: "UserIDCreate");

            migrationBuilder.CreateIndex(
                name: "IX_Profile_UserIDLastUpdate",
                table: "Profile",
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
                name: "FK_COM_Employee_AspNetUsers_UserId",
                table: "COM_Employee",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_COM_Employee_COM_Company_CompanyId",
                table: "COM_Employee",
                column: "CompanyId",
                principalTable: "COM_Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_COM_Employee_GEN_PersonalInformation_UserIDCreate",
                table: "COM_Employee",
                column: "UserIDCreate",
                principalTable: "GEN_PersonalInformation",
                principalColumn: "PersonalInformationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_COM_Employee_GEN_PersonalInformation_UserIDLastUpdate",
                table: "COM_Employee",
                column: "UserIDLastUpdate",
                principalTable: "GEN_PersonalInformation",
                principalColumn: "PersonalInformationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GEN_PersonalInformation_AspNetUsers_UserId",
                table: "GEN_PersonalInformation",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GEN_PersonalInformation_GEN_City_CityId",
                table: "GEN_PersonalInformation",
                column: "CityId",
                principalTable: "GEN_City",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GEN_PersonalInformation_AspNetUsers_UserId",
                table: "GEN_PersonalInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_GEN_State_GEN_PersonalInformation_UserIDCreate",
                table: "GEN_State");

            migrationBuilder.DropForeignKey(
                name: "FK_GEN_State_GEN_PersonalInformation_UserIDLastUpdate",
                table: "GEN_State");

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
                name: "COM_CompanyConfigNFe");

            migrationBuilder.DropTable(
                name: "COM_Employee");

            migrationBuilder.DropTable(
                name: "CUS_CustomerAddress");

            migrationBuilder.DropTable(
                name: "Users_x_Claims");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CUS_Customer");

            migrationBuilder.DropTable(
                name: "Claim");

            migrationBuilder.DropTable(
                name: "COM_Company");

            migrationBuilder.DropTable(
                name: "COM_Account");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropTable(
                name: "GEN_PersonalInformation");

            migrationBuilder.DropTable(
                name: "GEN_City");

            migrationBuilder.DropTable(
                name: "GEN_State");
        }
    }
}
