using Model.Enums.Companies;
using Model.Models.General;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models.Companies
{
    [Table("CompanyConfigNFe")]
    public class CompanyConfigNFe : BaseModel
    {
        [Key]
        public int CompanyConfigNFeId { get; set; }

        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public int CurrentNumberNfe { get; set; }

        [Required, Column("nvarchar(200)")]
        public string VersionNfe { get; set; }

        [Required]
        public EEnvironment EnvironmentNFE { get; set; }

        #region .:: PesonalInformation ::.
        [ForeignKey("PersonalInformationUser")]
        public override int UserIDCreate { get; set; }
        public PersonalInformation PersonalInformationUser { get; set; }
        [ForeignKey("PersonalInformationUpdate")]
        public override int UserIDLastUpdate { get; set; }
        public PersonalInformation PersonalInformationUpdate { get; set; }
        #endregion    
    }
}
