using Model.Models.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models.General
{
    [Table("Personal_Information")]
    public class PersonalInformation : BaseModel
    {
        [Key]
        public int PersonalInformationId { get; set; }
        [Column("nvarchar(20)")]
        public string IndividualResistration { get; set; }
        [Column("nvarchar(20)")]
        public string PhoneNumbers { get; set; }
        [Column("nvarchar(20)")]
        public string PostalCode { get; set; }
        [Column("nvarchar(200)")]
        public string Address { get; set; }
        [Column("nvarchar(20)")]
        public string AddressNumber { get; set; }
        [Column("nvarchar(500)")]
        public string AddressComplement { get; set; }
        [Column("nvarchar(200)")]
        public string Neighborhood { get; set; }

        [ForeignKey("City")]
        public int? CityId { get; set; }
        public City City { get; set; }
    }
}
