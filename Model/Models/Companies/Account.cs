﻿using Microsoft.EntityFrameworkCore;
using Model.Models.General;
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
        [ForeignKey("PersonalInformationUser")]
        public override int UserIDCreate { get; set; }
        public PersonalInformation PersonalInformationCreate { get; set; }
        [ForeignKey("PersonalInformationUpdate")]
        public override int UserIDLastUpdate { get; set; }
        public PersonalInformation PersonalInformationUpdate { get; set; }
        #endregion


    }
}
