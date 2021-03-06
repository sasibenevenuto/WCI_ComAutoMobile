﻿using Model.Models.Common;
using Model.Models.General;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models.Identity
{
    [Table("IDE_Profile")]
    public class Profile : BaseModel
    {
        [Key]
        public int ProfileId { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Description { get; set; }

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
