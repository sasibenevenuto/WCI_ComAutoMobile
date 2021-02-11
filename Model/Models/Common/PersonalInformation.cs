using Model.Models.General;
using Model.Models.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models.Common
{
    [Table("GEN_PersonalInformation")]
    public class PersonalInformation : BaseModel
    {
        [Key]
        public int PersonalInformationId { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string IndividualResistration { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string PhoneNumbers { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string PostalCode { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Address { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string AddressNumber { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string AddressComplement { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Neighborhood { get; set; }

        [ForeignKey("City")]
        public int? CityId { get; set; }
        public City City { get; set; }

        public new int? UserIDCreate { get; set; }
        public new int? UserIDLastUpdate { get; set; }
    }
}
