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

        [Column("nvarchar(200)")]
        public string Post { get; set; }

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
