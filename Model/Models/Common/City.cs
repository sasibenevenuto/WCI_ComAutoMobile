using Model.Models.General;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models.Common
{
    [Table("GEN_City")]
    public class City : BaseModel
    {
        [Key]
        public int CityId { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string ExternalCode { get; set; }

        [ForeignKey("State")]
        public int StateId { get; set; }
        public State State { get; set; }         
    }
}
