using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model.Models.Companies;
using Model.Models.Customers;
using Model.Models.General;
using Model.Models.Identity;
using System.Linq;

namespace Context
{
    public class SolutionContext : IdentityDbContext<User>, ISolutionContext
    {
        public SolutionContext(DbContextOptions<SolutionContext> options)
          : base(options)
        {

        }

        public DbSet<Account> Account { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyConfigNFe> CompanyConfigNFe { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerAddress> CustomerAddress { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<PersonalInformation> PersonalInformation { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Claim> Claim { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Users_x_Claims> Users_x_Claims { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Company>()
                .HasOne(ap => ap.Account)
                .WithMany(ap => ap.Companies)
                .HasForeignKey(u => u.AccountId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
