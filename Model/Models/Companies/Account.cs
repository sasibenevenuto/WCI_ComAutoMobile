using Model.Models.Common;
using Model.Models.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models.Companies
{
    [Table("COM_Account")]
    public class Account : BaseModel
    {
        [Key]
        public Guid AccountId { get; set; }

        public List<Company> Companies { get; set; }

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
