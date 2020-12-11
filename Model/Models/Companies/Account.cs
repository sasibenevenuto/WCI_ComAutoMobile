﻿using Model.Models.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models.Companies
{
    [Table("Account")]
    public class Account : BaseModel
    {
        [Key]
        public Guid AccountId { get; set; }

        public List<Company> Companies { get; set; }

        #region .:: PesonalInformation ::.
        [ScaffoldColumn(false), ForeignKey("PersonalInformationUser")]
        public override int UserID { get; set; }
        [ScaffoldColumn(false)]
        public PersonalInformation PersonalInformationUser { get; set; }
        [ScaffoldColumn(false), ForeignKey("PersonalInformationUpdate")]
        public override int UserIDLastUpdate { get; set; }
        [ScaffoldColumn(false)]
        public PersonalInformation PersonalInformationUpdate { get; set; }
        #endregion


    }
}
