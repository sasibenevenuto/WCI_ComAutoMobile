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

        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string FederativeUnit { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string ExternalCode { get; set; }

        #region .:: Many-To-One ::.
        public List<City> Cities { get; set; }
        #endregion

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
