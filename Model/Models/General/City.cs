using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models.General
{
    [Table("City")]
    public class City : BaseModel
    {
        [Key]
        public int CityId { get; set; }

        [Column("nvarchar(200)")]
        public string Name { get; set; }

        [Column("nvarchar(200)")]
        public string ExternalCode { get; set; }

        [ForeignKey("State")]
        public int StateId { get; set; }
        public State State { get; set; }

        //#region .:: PesonalInformation ::.
        //[ForeignKey("PersonalInformationUser")]
        //public override int UserID { get; set; }
        //public PersonalInformation PersonalInformationUser { get; set; }
        //[ForeignKey("PersonalInformationUpdate")]
        //public override int UserIDLastUpdate { get; set; }
        //public PersonalInformation PersonalInformationUpdate { get; set; }
        //#endregion
    }
}
