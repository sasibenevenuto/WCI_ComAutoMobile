using Model.Models.Common;
using Model.Models.General;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models.Customers
{
    [Table("CUS_CustomerAddress")]
    public class CustomerAddress : BaseModel
    {
        [Key]
        public long CustomerAddressId { get; set; }

        [ForeignKey("Customer")]
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Column(TypeName ="nvarchar(20)")]
        public string CellPhone { get; set; }

        [Column(TypeName ="nvarchar(200)")]
        public string PhoneNumbers { get; set; }

        [Column(TypeName ="nvarchar(20)")]
        public string PostalCode { get; set; }

        [Column(TypeName ="nvarchar(250)")]
        public string Address { get; set; }

        [Column(TypeName ="nvarchar(200)")]
        public string AddressNumber { get; set; }

        [Column(TypeName ="nvarchar(400)")]
        public string AddressComplement { get; set; }

        [Column(TypeName ="nvarchar(200)")]
        public string Neighborhood { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }
        public City City { get; set; }

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
