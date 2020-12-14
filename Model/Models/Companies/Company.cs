using Model.Models.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models.Companies
{
    [Table("Company")]
    public class Company : BaseModel
    {
        [Key]
        public Guid CompanyId { get; set; }

        [ForeignKey("Account")]
        public Guid AccountId { get; set; }
        public Account Account { get; set; }

        [Column(TypeName = "nvarchar(200)")]        
        public string TradingName { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string FantasyName { get; set; }

        [Column(TypeName = "nvarchar(20)")]        
        public string CNPJ { get; set; }

        [Column(TypeName = "nvarchar(20)")]        
        public string StateRegistration { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string CNAE { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string MunicipalityRegistration { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string StateRegistrationReplaceTributary { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string UrlLogo { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string CellPhone { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string PhoneNumbers { get; set; }

        #region .:: Address :..
        [Column(TypeName = "nvarchar(20)")]
        public string PostalCode { get; set; }

        [Column(TypeName = "nvarchar(250)")]        
        public string Address { get; set; }

        [Column(TypeName = "nvarchar(20)")]        
        public string AddressNumber { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string AddressComplement { get; set; }

        [Column(TypeName = "nvarchar(200)")]        
        public string Neighborhood { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }
        public City City { get; set; }
        #endregion

        #region .:: PesonalInformation ::.
        [ForeignKey("PersonalInformationCreate")]
        public override int UserIDCreate { get; set; }
        public PersonalInformation PersonalInformationCreate { get; set; }
        [ForeignKey("PersonalInformationUpdate")]
        public override int UserIDLastUpdate { get; set; }
        public PersonalInformation PersonalInformationUpdate { get; set; }
        #endregion

        #region .:: Many-To-One ::.
        //public List<Invoice> Invoices { get; set; }
        public List<Employee> Employees { get; set; }
        #endregion

        #region .:: One-To-Zero or One ::.
        //public int? CompanyConfigNFeId { get; set; }
        public virtual CompanyConfigNFe CompanyConfigNFe { get; set; }
        #endregion     
    }
}
