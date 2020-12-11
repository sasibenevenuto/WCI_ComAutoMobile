using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models.General
{
    [Table("State")]
    public class State : BaseModel
    {
        [Key]
        public int StateId { get; set; }

        [Required, Column("nvarchar(200)")]
        public string Name { get; set; }

        [Column("nvarchar(20)")]
        public string FederativeUnit { get; set; }
        [Column("nvarchar(20)")]
        public string ExternalCode { get; set; }

        #region .:: Many-To-One ::.
        public List<City> Cities { get; set; }
        #endregion

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
