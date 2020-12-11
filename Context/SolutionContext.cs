using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model.Models.Companies;
using Model.Models.Customers;
using Model.Models.General;
using Model.Models.Identity;

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
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Atividades_x_Proposta>()
            //    .HasOne(ap => ap.Proposta)
            //    .WithMany(ap => ap.AtividadesProposta)
            //    .HasForeignKey(u => u.IdProposta)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
