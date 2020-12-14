using Model.Models.General;
using Model.Models.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models.Companies
{
    [Table("Employee")]
    public class Employee : BaseModel
    {
        [Key]
        public long EmployeeId { get; set; }

        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Post { get; set; }

        #region .:: PesonalInformation ::.
        [ForeignKey("PersonalInformationCreate")]
        public override int UserIDCreate { get; set; }
        public PersonalInformation PersonalInformationCreate { get; set; }
        [ForeignKey("PersonalInformationUpdate")]
        public override int UserIDLastUpdate { get; set; }
        public PersonalInformation PersonalInformationUpdate { get; set; }
        #endregion
    }
}
